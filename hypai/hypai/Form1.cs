using hypai.classes;
using hypai.classes.Audio;
using hypai.classes.Domain;
using hypai.classes.Speech;
using hypai.hypreference;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace hypai
{
    public partial class frmhyp : Form
    {

        private hypreference.Service1Client hyprserrvice = new hypreference.Service1Client();
        private List<Ad> ads = new List<Ad>();

        public frmhyp()
        {
            InitializeComponent();
            txtConsole.ScrollBars = ScrollBars.Vertical;
            ads = hyprserrvice.getAllAds().ToList();

        }

        private void frmhyp_Load(object sender, EventArgs e)
        {

            hyprserrvice.updateReportRSTATUS(1, 1);
            if (hyprserrvice.getAllAds().Count() < 1)
            {
                DataManager.loadReportsIntoDB();
            }
            if (hyprserrvice.getAllReports().Count() < 1)
            {
                DataManager.loadAdsIntoDB();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "==================Advertisements Conversion Started=====================\r\n";
            AdvertsAudioToText att = new AdvertsAudioToText();
            foreach (Ad a in ads)
            {
                att.a = a;
                backgroundWorker1.RunWorkerAsync(att);
            }
        }

        private void convertAdsToText()
        {

            if (txtConsole.InvokeRequired)
            {
                txtConsole.Invoke(new Action(() =>
                {
                    txtConsole.Text = "Preparing Ads \r\n";
                    ads = hyprserrvice.getAllAds().ToList();
                    txtConsole.Text += "Converting WAV Ads to text \r\n";
                    foreach (Ad a in ads)
                    {
                        txtConsole.Text += a.AUDIO_DIR + " \r\n";
                    }
                    txtConsole.Text = "Conversion Completed \r\n";
                }));
            }
        }

        protected class AdvertsAudioToText
        {
            private SpeechProcessor pr;
            public Ad a;
            public AdvertsAudioToText()
            {
                pr = new SpeechProcessor();
            }
            public String beginConversion()
            {
                return a.AUDIO_DIR + " \r\n" + pr.getTextFromAudio(a.AUDIO_DIR) + "\r\n";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            AdvertsAudioToText att2 = (AdvertsAudioToText)e.Argument;
            e.Result = att2.beginConversion();

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            String conversionResult = (String)e.Result;
            txtConsole.Text += conversionResult;
        }

        private void btnConcatinate_Click(object sender, EventArgs e)
        {
            List<String> files = new List<String>();
            files.Add(@"C:\hypai\hyp_connect\App_Data\SoundTracks\soundtrack1.wav");
            files.Add(@"C:\hypai\hyp_connect\App_Data\Ads\CURRYS.wav");
            files.Add(@"C:\hypai\hyp_connect\App_Data\SoundTracks\soundtrack2.wav");
            AudioProcessor.Concatenate(@"C:\hypai\hyp_connect\App_Data\output.wav", files);
            TimeSpan time = GetAudioDuration(@"C:\hypai\hyp_connect\App_Data\output.wav");
            MessageBox.Show(time.ToString(@"hh\:mm\:ss"));



        }


        private static TimeSpan GetAudioDuration(string filePath)
        {
            using (var shell = ShellObject.FromParsingName(filePath))
            {
                IShellProperty prop = shell.Properties.System.Media.Duration;
                var t = (ulong)prop.ValueAsObject;
                return TimeSpan.FromTicks((long)t);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<String> articles = new List<string>();
            articles.Add("The dog barks at night.");
            articles.Add("University of Johannesburg has been closed down.");
            articles.Add("Political struggles in johhaneburg.");
            articles.Add("Sharks won the tournament, they beat bluelions in a tough match.");
        
            //File.ReadAllText(@"C:\hypai\hyp_connect\App_Data\Reports\bbc\business\001.txt")
            foreach (var s in articles)
            {
                SpeechProcessor.ConvertToAudio(s, KeyGenerator.GetUniqueKey(10));
            }
            String report = NewsComposer.createReportAudio();
            NewsComposer.clearCache();

            // Create a SoundPlayer instance to play output audio file.
            //System.Media.SoundPlayer m_SoundPlayer =
            //  new System.Media.SoundPlayer(@"C:\hypai\hyp_connect\App_Data\test.wav");
            //m_SoundPlayer.Play();
        }


    }
}

using hypai.classes.Exceptions;
using System;
using System.Linq;
using System.Speech.AudioFormat;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;


namespace hypai.classes.Speech
{

    class SpeechProcessor
    {

        private static SpeechRecognitionEngine sre { set; get; }
        private static Grammar gr { set; get; }

        public SpeechProcessor() { }
        public String getTextFromAudio(String DIR)
        {
            try
            {
                sre = new SpeechRecognitionEngine();
                gr = new DictationGrammar();
                sre.LoadGrammar(gr);
                sre.SetInputToWaveFile(DIR);
                sre.BabbleTimeout = new TimeSpan(Int32.MaxValue);
                sre.InitialSilenceTimeout = new TimeSpan(Int32.MaxValue);
                sre.EndSilenceTimeout = new TimeSpan(100000000);
                sre.EndSilenceTimeoutAmbiguous = new TimeSpan(100000000);
                StringBuilder sb = new StringBuilder();
                while (true)
                {
                    try
                    {
                        var recText = sre.Recognize();
                        if (recText == null)
                        {
                            break;
                        }

                        sb.Append(recText.Text);
                    }
                    catch (Exception ex)
                    {
                        //handle exception      
                        //...

                        break;
                    }
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                Logger._failed_converts++;
            }
            return "";

        }

        public static void ConvertToAudio(String text, String audioname)
        {

            // Initialize a new instance of the SpeechSynthesizer.
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {

                // show installed voices
                foreach (var v in synth.GetInstalledVoices().Select(v => v.VoiceInfo))
                {
                    System.Diagnostics.Debug.WriteLine("Name:{0}, Gender:{1}, Age:{2}",
                      v.Description, v.Gender, v.Age);
                }
                synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
                synth.Rate = 1; //Ranges -10 to 10
                // Configure the audio output. 
                synth.SetOutputToWaveFile(@"C:\hypai\hyp_connect\App_Data\cache\" + audioname + ".wav",
                  new SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));
                // Build a prompt.
                PromptBuilder builder = new PromptBuilder();

                builder.AppendText(text);

                // Speak the prompt.
                synth.Speak(builder);

            }

        }
    }
}

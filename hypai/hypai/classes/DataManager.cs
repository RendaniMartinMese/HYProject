using hypai.hypreference;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hypai.classes
{
    class DataManager
    {

        public static void loadAdsIntoDB()
        {
            hypreference.Service1Client hyprserrvice = new hypreference.Service1Client();
            DirectoryInfo di = new DirectoryInfo(@"C:\hypai\hyp_connect\App_Data\Ads");
            FileInfo[] files = di.GetFiles("*.wav");
            foreach (FileInfo file in files)
            {
                Ad newAd = new Ad();
                newAd.AD_TYPE = "SPONSORSHIP";
                newAd.AUDIO_DIR = file.FullName;
                newAd.DATE_DURATION = DateTime.Now;
                hyprserrvice.addAd(newAd);
            }


        }
        public static void loadReportsIntoDB()
        {
            hypreference.Service1Client hyprserrvice = new hypreference.Service1Client();
            //loading all the business reports into the database
            DirectoryInfo di = new DirectoryInfo(@"C:\hypai\hyp_connect\App_Data\Reports\bbc\business");
            FileInfo[] files = di.GetFiles("*.txt");
            foreach (FileInfo file in files)
            {
                Report report = new Report();
                report.CATEGORY = "BUSINESS";
                report.READ_STATUS = 0;
                report.INDEX = Path.GetFileNameWithoutExtension(file.FullName);
                hyprserrvice.addReport(report);
            }
            //loading all the tech reports into the database
            di = new DirectoryInfo(@"C:\hypai\hyp_connect\App_Data\Reports\bbc\entertainment");
            files = di.GetFiles("*.txt");
            foreach (FileInfo file in files)
            {
                Report report = new Report();
                report.CATEGORY = "ENTERTAINMENT";
                report.READ_STATUS = 0;
                report.INDEX = Path.GetFileNameWithoutExtension(file.FullName);
                hyprserrvice.addReport(report);
            }
            //loading all the entertainment reports into the database
            di = new DirectoryInfo(@"C:\hypai\hyp_connect\App_Data\Reports\bbc\politics");
            files = di.GetFiles("*.txt");
            foreach (FileInfo file in files)
            {
                Report report = new Report();
                report.CATEGORY = "POLITICS";
                report.READ_STATUS = 0;
                report.INDEX = Path.GetFileNameWithoutExtension(file.FullName);
                hyprserrvice.addReport(report);
            }
            //loading all the politics reports into the database
            di = new DirectoryInfo(@"C:\hypai\hyp_connect\App_Data\Reports\bbc\entertainment");
            files = di.GetFiles("*.txt");
            foreach (FileInfo file in files)
            {
                Report report = new Report();
                report.CATEGORY = "SPORTS";
                report.READ_STATUS = 0;
                report.INDEX = Path.GetFileNameWithoutExtension(file.FullName);
                hyprserrvice.addReport(report);
            }
            //loading all the sports reports into the database
            di = new DirectoryInfo(@"C:\hypai\hyp_connect\App_Data\Reports\bbc\entertainment");
            files = di.GetFiles("*.txt");
            foreach (FileInfo file in files)
            {
                Report report = new Report();
                report.CATEGORY = "TECH";
                report.READ_STATUS = 0;
                report.INDEX = Path.GetFileNameWithoutExtension(file.FullName);
                hyprserrvice.addReport(report);
            }

        }

    }
}

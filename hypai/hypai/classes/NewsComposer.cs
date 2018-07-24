using hypai.classes.Audio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hypai.classes.Domain
{
    class NewsComposer
    {


        public static String createReportAudio()
        {
            string[] files = Directory.GetFiles(@"C:\hypai\hyp_connect\App_Data\cache");

            AudioProcessor.Concatenate(@"C:\hypai\hyp_connect\App_Data\Reports\audio\conct.wav", files);

            return "";
        }
        public static void clearCache()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\hypai\hyp_connect\App_Data\cache");
            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }

    }
}

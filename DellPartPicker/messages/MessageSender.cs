using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DellPartPicker
{
    class MessageSender
    {

        static String ip = Constants.REMOTE_SERVER;

        public static bool sendMessage(String message, String ip)
        {
            String url;

            string externalip = new WebClient().DownloadString("http://icanhazip.com");

            if (externalip.Equals(Constants.REMOTE_SERVER))
            {
                ip = Constants.LOCAL_SERVER;
            }

            if (ip == Constants.REMOTE_SERVER)
            {
                url = "http://73.17.34.121/hosted/simpleInjector.exe";
            }
            else
            {
                url = "http://10.0.0.4/hosted/simpleInjector.exe";
            }
            //bool fetched = FetchItem.downloadFile(url, @"C:\Temp\simpleInjector.exe", false);
            bool exists = File.Exists(@"C:\Temp\simpleInjector.exe");

            if (!exists)
            {
                return false;
            }

            return run(message, ip);
        }

        private static bool run(String message, String ip)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Temp\simpleInjector.exe", ip + " \"" + message + "\"");
            startInfo.CreateNoWindow = false;
            startInfo.RedirectStandardOutput = true;



            Process process = new Process();
            process.StartInfo = startInfo;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            


            try
            {
                process.Start();
                process.WaitForExit();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
            
        }
    }
}

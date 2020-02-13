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

        public static bool sendMessage(String message, String ip)
        {
            String url;

            bool exists = File.Exists(@"C:\Temp\simpleInjector.exe");
            if (exists)
            {
                return run(message, ip);
            }
            else
            {
                //download the file
                Loader.downloadFile("simpleInjector.exe");

                //return the message attempt
                return run(message, ip);
            }          
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

        private static bool download(String url)
        {
            return false;
        }
    }
}

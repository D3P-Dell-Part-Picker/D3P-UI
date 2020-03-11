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

        public static String sendMessage(String message, String ip)
        {

            bool exists = File.Exists(@"C:\Temp\simpleInjector.exe");
            if (exists)
            {
                Console.WriteLine("running");
                return run(message, ip);
            }
            else
            {
                Console.WriteLine("file was not found");
                //download the file
                Loader.downloadFile("simpleInjector.exe");

                //return the message attempt
                return run(message, ip);
            }          
        }

        private static String run(String message, String ip)
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
                StringBuilder sb = new StringBuilder();
                while (!process.StandardOutput.EndOfStream)
                {
                    String line = process.StandardOutput.ReadLine();
                    
                    sb.AppendLine(line);
                }
                Console.WriteLine(sb.ToString());
                return sb.ToString();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellPartPicker
{
    class MessageFormatter
    {
        public static void sendMessage(String message, String ip, int port, Destination d)
        {
            string NewMessage = formatMessage(message);
            SocketComms.sendMessage(NewMessage, ip, port, d);
        }

        private static String formatMessage(String message)
        {
            int length = message.ToArray().Length + 16 + 1 + 1;

            Console.WriteLine(length);

            Char StartingChar = (char)length;

            Console.WriteLine(StartingChar);

            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            sb.Append(StartingChar);
            for(int i = 0; i < 8; i++)
            {
                sb.Append(randomByte(random));
            }
            sb.Append(":");
            sb.Append(message);
            return sb.ToString();
        }

        private static String randomByte(Random random)
        {
            
            byte ran = (byte)random.Next(0, 255);
            return ran.ToString("X2").ToLower();
        }
    }
}

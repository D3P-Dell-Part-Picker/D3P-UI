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
            int length = message.ToArray().Length;
            Char StartingChar = (char)length;
            Random random = new Random();
            StringBuilder sb = new StringBuilder(StartingChar);
            for(int i = 0; i < 8; i++)
            {
                sb.Append(randomOctet(random));
            }
            sb.Append(":");
            sb.Append(message);
            return sb.ToString();
        }

        private static String randomOctet(Random random)
        {
            
            byte ran = (byte)random.Next(0, 255);
            return ran.ToString("X2");
        }
    }
}

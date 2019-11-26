using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellPartPicker
{
    class MessageFormatter
    {
        public static void sendMessage(String message, String ip, int port)
        {
            string NewMessage = formatMessage(message);
        }

        private static String formatMessage(String message)
        {
            int length = message.ToArray().Length;
            Char StartingChar = (char)length;
            return null;
        }

        private String randomOctet()
        {
            Random random = new Random();
            byte ran = (byte)random.Next(0, 255);
            return ran.ToString("X2");
        }
    }
}

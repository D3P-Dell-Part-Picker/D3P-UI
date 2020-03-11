using DellPartPicker.constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellPartPicker.messages
{
    public class MessageSimplifier
    {
        public static void sendMessage(int linenum, String ip, CommandType t) 
        {
            if(t == CommandType.DISPOSE)
            {
                dispose(linenum, ip);
            }
            else if(t == CommandType.FIND)
            {
                find(linenum, ip);
            }
            else
            {
                Console.WriteLine("ummmmm");
            }
        }

        private static void dispose(int linenum, String ip)
        {
            Console.WriteLine("Sending DISPOSE message");
            String command = Commands.DISPOSE + linenum.ToString();
            MessageSender.sendMessage(command, ip);
        }

        private static void find(Int32 linenum, String ip)
        {
            Console.WriteLine("Sending find message");
            String command = Commands.FIND + linenum.ToString() + ":" + linenum.ToString();
            MessageSender.sendMessage(command, ip);
        }
    }
}

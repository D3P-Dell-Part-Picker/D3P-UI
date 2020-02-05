using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DellPartPicker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
	        Application.EnableVisualStyles();
		    Application.SetCompatibleTextRenderingDefault(false);
		    Application.Run(new Form1());
            */
            //MessageFormatter.sendMessage("thisisatest", "127.0.0.1", 3705, Destination.inputted);
            MessageSender.sendMessage("hello owen", "10.0.0.4");
        }
    }
}

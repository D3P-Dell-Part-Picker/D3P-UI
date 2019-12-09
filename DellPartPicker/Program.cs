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
               
	        Application.EnableVisualStyles();
		    Application.SetCompatibleTextRenderingDefault(false);
		    Application.Run(new Form1());

            //SocketComms.sendMessage("test", "73.17.34.121", 9876);
            //SocketComms.sendMessage("exit", "73.17.34.121", 9876);
        }
    }
}

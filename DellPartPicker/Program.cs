using DellPartPicker.utils;
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

            //read configuration
            Constants.config = Json.getConfig();


            Constants.PIMESH = Constants.config.PiMeshIP;
            Constants.LOCAL_SERVER = Constants.config.LocalServerIP;
            Constants.REMOTE_SERVER = Constants.config.RemoteServerIP;

            
	        Application.EnableVisualStyles();
		    Application.SetCompatibleTextRenderingDefault(false);
		    Application.Run(new Form1());
            
            //MessageSender.sendMessage("hello owen", "192.168.53.33");
        }
    }
}

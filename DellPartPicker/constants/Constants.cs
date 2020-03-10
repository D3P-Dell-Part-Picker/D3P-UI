using DellPartPicker.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellPartPicker
{
    class Constants
    {
        public static String LOCAL_SERVER = "10.0.0.4";
        public static String REMOTE_SERVER = "73.17.34.121";

        public static String PIMESH = "192.168.53.33";


        static String appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static String CONFIG_FILE = appdata + @"\D3P\config.json";
        
        public static String CONFIG_LOC = appdata + @"\D3P";

        public static D3PConfig config;

        public static void renewConf()
        {
            config = new D3PConfig
            {
                LocalServerIP = LOCAL_SERVER,
                PiMeshIP = PIMESH,
                RemoteServerIP = REMOTE_SERVER
                
            };
        }
    }

    public enum Destination
    {
        localServer = 0,
        remoteServer = 1,
        inputted = 3
    }

    public enum Field
    {
        PartNumber = 0,
        Desc = 1,
        Location = 2
    }
}

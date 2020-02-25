using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellPartPicker
{
    class Constants
    {
        public const String LOCAL_SERVER = "10.0.0.4";
        public const String REMOTE_SERVER = "73.17.34.121";

        public static String PIMESH = "192.168.53.33";

        public static String CONFIG_FILE = @"%APPDATA%\D3P\config.json";
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

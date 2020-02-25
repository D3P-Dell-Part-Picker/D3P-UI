using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellPartPicker.utils
{
    public class Json
    {
        public static D3PConfig getConfig()
        {
            using (StreamReader r = new StreamReader(Constants.))
            {
                string json = r.ReadToEnd();
                if(json == "")
                {
                    D3PConfig conf = new D3PConfig();

                    conf.PiMeshIP = Constants.PIMESH;
                    conf.RemoteServerIP = Constants.LOCAL_SERVER;
                }
                D3PConfig config = JsonConvert.DeserializeObject<D3PConfig>(json);
                return config;
            }
        }

        public static void
    }

    public class D3PConfig
    {
        public String PiMeshIP;
        public String RemoteServerIP;

    }
}

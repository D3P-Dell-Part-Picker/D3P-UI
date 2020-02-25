using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DellPartPicker.utils
{
    public class Json
    {
            
        public static D3PConfig getConfig()
        {
            Console.WriteLine("Dir exists? " + Directory.Exists(Constants.CONFIG_LOC));
            Console.WriteLine("File exists? " + File.Exists(Constants.CONFIG_FILE));
            if (!Directory.Exists(Constants.CONFIG_LOC) || !File.Exists(Constants.CONFIG_FILE))
            {
                if (!Directory.Exists(Constants.CONFIG_LOC))
                {
                    Directory.CreateDirectory(Constants.CONFIG_LOC);
                }
                
                
                Thread.Sleep(100);

                D3PConfig conf = new D3PConfig();

                conf.PiMeshIP = Constants.PIMESH;
                conf.RemoteServerIP = Constants.LOCAL_SERVER;
                conf.LocalServerIP = Constants.LOCAL_SERVER;

                using (StreamWriter file = File.CreateText(Constants.CONFIG_FILE))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, conf);
                    file.Dispose();
                }
                

                Constants.config = conf;
                return conf;
            }



            using (StreamReader r = new StreamReader(Constants.CONFIG_FILE))
            {
                string json = r.ReadToEnd();

                Console.WriteLine("json in file: " + json);

                if (json.Length == 0)
                {
                    D3PConfig conf = new D3PConfig();

                    conf.PiMeshIP = Constants.PIMESH;
                    conf.RemoteServerIP = Constants.LOCAL_SERVER;

                    r.Close();
                    writeJson(conf);

                    return conf;

                }
                D3PConfig config = JsonConvert.DeserializeObject<D3PConfig>(json);
                r.Close();
                writeJson(config);
                return config;
            }
        }

        public static void writeJson(D3PConfig config)
        {

            Console.WriteLine("json: " + JsonConvert.SerializeObject(config));

            Thread.Sleep(200);

            

            using (StreamWriter file = File.CreateText(Constants.CONFIG_FILE))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, config);
            }


        }
    }

    public class D3PConfig
    {
        public String PiMeshIP;
        public String RemoteServerIP;
        public String LocalServerIP;

    }
}

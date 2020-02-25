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
            //check to see if the files exist and print result
            Console.WriteLine("Dir exists? " + Directory.Exists(Constants.CONFIG_LOC));
            Console.WriteLine("File exists? " + File.Exists(Constants.CONFIG_FILE));

            //if the directory or file does not exist act accordingly
            if (!Directory.Exists(Constants.CONFIG_LOC) || !File.Exists(Constants.CONFIG_FILE))
            {
                //if the dir does not
                if (!Directory.Exists(Constants.CONFIG_LOC))
                {
                    //create the directory
                    Directory.CreateDirectory(Constants.CONFIG_LOC);
                }

                //create a new config
                D3PConfig conf = new D3PConfig
                {
                    PiMeshIP = Constants.PIMESH,
                    RemoteServerIP = Constants.LOCAL_SERVER,
                    LocalServerIP = Constants.LOCAL_SERVER
                };

                //write the config to the file
                using (StreamWriter file = File.CreateText(Constants.CONFIG_FILE))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, conf);
                    file.Close();
                }
                
                //set the config variable in constants
                Constants.config = conf;

                //return the config
                return conf;
            }


            //read from the json config
            using (StreamReader r = new StreamReader(Constants.CONFIG_FILE))
            {
                //the json read from the file
                string json = r.ReadToEnd();

                //debug: output the json
                Console.WriteLine("json in file: " + json);

                //if there is nothing
                if (json.Length == 0)
                {

                    D3PConfig conf = new D3PConfig
                    {
                        PiMeshIP = Constants.PIMESH,
                        RemoteServerIP = Constants.LOCAL_SERVER
                    };

                    //close the stream
                    r.Close();

                    //write the file
                    writeJson(conf);


                    //return the conf
                    return conf;

                }
                //deserialize
                D3PConfig config = JsonConvert.DeserializeObject<D3PConfig>(json);

                //close the stream
                r.Close();

                //write the files
                writeJson(config);

                //return config
                return config;
            }
        }

        public static void writeJson(D3PConfig config)
        {
            //print the json
            Console.WriteLine("json: " + JsonConvert.SerializeObject(config));

            //write to the file
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

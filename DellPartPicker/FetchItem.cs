using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace DellPartPicker
{
    class FetchItem
    {
        public static bool downloadFile(String fromUrl, String toUrl, bool doOverride){

            bool exists = File.Exists(fromUrl);

            if(exists && !doOverride)
            {
                return false;
            }

            try
            {
                WebClient Client = new WebClient();
                Client.DownloadFile(fromUrl, toUrl);
            }
            catch (WebException e)
            {
                Console.WriteLine(e.Message);
                return false;       
            }

            return true;
        }
    }
}

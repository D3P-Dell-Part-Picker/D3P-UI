using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace DellPartPicker
{
    public class Loader
    {
        public List<String> partnumList;
        public List<String> descList;
        public List<String> locList;
        private String[] partnum, desc, loc;
        String ip = "73.17.34.121";





        public Loader()
        {
            partnumList = new List<String>();
            string externalip = new WebClient().DownloadString("http://icanhazip.com");

            if (externalip.Equals("73.17.34.121"))
            {
                ip = "10.0.0.4";
            }
            

            descList = new List<String>();
            locList = new List<String>();
            downloadFile();
            readToMemory();

            //Console.WriteLine(partnum[287]);
            //Console.WriteLine(desc[287]);
            //Console.WriteLine(loc[287]);

            //String[][] temp = getData("042", Field.PartNumber);
            //Console.WriteLine(temp[0][0]);
        }

        private void downloadFile()
        {
            string userName = Environment.UserName;
            Console.WriteLine(userName);
            WebClient Client = new WebClient();
            if (!Directory.Exists(@"C:\Temp"))
            {
                Directory.CreateDirectory(@"C:\Temp");
            }
            
            Client.DownloadFile("http://" + ip + "/Racks.csv", @"C:\Temp\Racks.csv");
        }

        private void readToMemory()
        {
            StreamReader reader = new StreamReader(File.OpenRead(@"C:\Temp\Racks.csv"));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(',');
                    if (values.Length >= 3)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            if (values[i].Equals(""))
                            {

                                values[i] = "(N/A)";
                            }
                        }
                        partnumList.Add(values[0]);
                        descList.Add(values[1]);
                        locList.Add(values[2]);
                    }
                }
            }
            partnum = partnumList.ToArray();
            desc = descList.ToArray();
            loc = locList.ToArray();
        }

        //gets data given search data and the field
        //will throw ArgumentException if incorrect field is passed through
        public String[][] getData(String input, Field f)
        {
            String[][] data;
            int[] indexes;

            List<String> temp = new List<String>();
            List<int> indexlist = new List<int>();
            //if the field being searched is the field for description
            if (f == Field.Desc)
            {
                //find elements containing input in field f
                for (int i = 0; i < descList.Count; i++)
                {
                    if (descList[i].ToUpper().Contains(input.ToUpper())) {
                        indexlist.Add(i);
                    }
                    indexes = indexlist.ToArray();

                }
                //create a list of all indexes
                indexes = indexlist.ToArray();
            }
            else if (f == Field.PartNumber)
            {
                for (int i = 0; i < partnumList.Count; i++)
                {
                    if (partnumList[i].ToUpper().Contains(input.ToUpper()))
                        indexlist.Add(i);
                }
                indexes = indexlist.ToArray();
            }
            else if (f == Field.Location)
            {
                for (int i = 0; i < locList.Count; i++)
                {
                    if (locList[i].ToUpper().Contains(input.ToUpper()))
                        indexlist.Add(i);
                }
                indexes = indexlist.ToArray();
            }
            else
            {
                throw new System.ArgumentException("Invalid Field");
            }
            Console.WriteLine("index length " + indexes.Length);
            data = new String[indexes.Length][];
            for (int i = 0; i < indexes.Length; i++)
            {
                data[i] = new String[] { partnumList[indexes[i]],
                descList[indexes[i]], locList[indexes[i]] };
            }

            return data;
        }

        

    }
}

namespace DellPartPicker
{
    //the different fields
    public enum Field
    {
        PartNumber = 0,
        Desc = 1,
        Location = 2
    }
}
namespace DellPartPicker
{

    internal class Parser
    {
        public Parser()
        {

        }

        public void parse(String data, Field f, DataGridView dgv, Loader loader)
        {
            DataGridView dgvTemp = dgv;
            dgvTemp.ColumnCount = 3;
            dgvTemp.Columns[0].Name = "Part Number";
            dgvTemp.Columns[1].Name = "Description";
            dgvTemp.Columns[2].Name = "Location";


            String[][] found = loader.getData(data, f);

            for (int i = 0; i < found.Length; i++)
            {
                string[] row = new string[] { found[i][0], found[i][1], found[i][2] };
                dgvTemp.Rows.Add(row);
            }
            dgvTemp.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;



        }
    }
}
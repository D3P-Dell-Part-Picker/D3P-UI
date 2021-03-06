﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace DellPartPicker
{
    public class Loader
    {
        public static List<String> partnumList;
        public static List<String> descList;
        public static List<String> locList;
        private String[] partnum, desc, loc;
        static String ip = Constants.REMOTE_SERVER;





        public Loader()
        {
            partnumList = new List<String>();
           
            

            descList = new List<String>();
            locList = new List<String>();
            downloadFile("Racks.csv");
            readToMemory();

            // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // Console.WriteLine(partnum[287]);
            // Console.WriteLine(desc[287]);
            // Console.WriteLine(loc[287]);

            String[][] temp = getData("042", Field.PartNumber);
            Console.WriteLine(temp[0][0]);
        }

        public static void downloadFile(String file)
        {
            string externalip = new WebClient().DownloadString("http://icanhazip.com");

            if (externalip.Equals(Constants.REMOTE_SERVER))
            {
                ip = Constants.LOCAL_SERVER;
            }
            string userName = Environment.UserName;
            Console.WriteLine(userName);
            WebClient Client = new WebClient();

            if (!Directory.Exists(@"C:\Temp"))
            {
                Directory.CreateDirectory(@"C:\Temp");
            }
            if (!File.Exists(@"C:\Temp\" + file)) //if the file does not exist currently
            {
                try
                {
                    Client.DownloadFile("http://" + ip + "/hosted/" + file, @"C:\Temp\" + file);
                }
                catch (Exception e)
                {
                    //check for existing backups

                }
            }
            
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

        public static int getLineNumber(String partnum, String name)
        {
            int index = 0;
            if(!(Loader.partnumList.IndexOf(partnum) == -1)) // check if the partnum is in the list
            {
                index = Loader.partnumList.IndexOf(partnum);
            }else if(!(Loader.descList.IndexOf(name) == -1)) //check for the item name existing
            {
                index = Loader.descList.IndexOf(name);
            }
            else //no item found, return -1
            {
                index = -1;
            }
            

            //return the line number
            return index + 1;
        }
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

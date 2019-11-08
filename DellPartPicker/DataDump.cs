using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DellPartPicker
{
    class DataDump
    {
        Loader loader;
        Parser parser = new Parser();

        public DataDump()
        {

        }

        public String[] find(string find, Loader l)
        {
            this.loader = l;
            String[] found = new string[3];

            int index = loader.partnumList.IndexOf(find);

            found[0] = loader.partnumList[index];
            found[1] = loader.descList[index];
            found[2] = loader.locList[index];

            return found;
        }

        public void addArray(String[][] stringarray, DataGridView dgv)
        {
            dgv.ColumnCount = 3;
            dgv.Columns[0].Name = "Part Number";
            dgv.Columns[1].Name = "Description";
            dgv.Columns[2].Name = "Location";
            for (int i = 0; i < stringarray.Length; i++)
            {
                string[] row = new string[] { stringarray[i][0], stringarray[i][1], stringarray[i][2] };
                dgv.Rows.Add(row);
            }
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

    }

    class ParseList
    {
        DataDump dd = new DataDump();
        
        public ParseList()
        {

        }

        public void searchList(String[] data, DataGridView dgv, Loader l)
        {
            String[] dataString = data;
            List<String[]> foundList = new List<String[]>();
            String[][] found;
            DataGridView table = dgv;
            Loader loader = l;

            for (int i = 0; i < dataString.Length; i++){
                foundList.Add(dd.find(dataString[i], loader));
            }
            found = foundList.ToArray();
            dd.addArray(found, table);

        }
    }
}

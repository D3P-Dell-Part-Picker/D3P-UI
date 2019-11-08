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
        Loader loader = new Loader();
        Parser parser = new Parser();

        public DataDump()
        {

        }

    }

    class ParseList
    {
        
        public ParseList()
        {

        }

        public void searchList(String[] data, DataGridView dgv, Loader l)
        {
            String[] dataString;
            DataGridView table = dgv;
            Loader loader = l;

        }
    }
}

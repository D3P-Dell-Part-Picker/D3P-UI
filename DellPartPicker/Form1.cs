using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DellPartPicker
{
    public partial class Form1 : Form
    {
        Loader loader = new Loader();
        Parser parser = new Parser();

        public Form1()
        {
            InitializeComponent();
            
            disableFunctions();
            
        }
        private void disableFunctions()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            error.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if(searchBox.Text == null || searchBox.Text == "")
            {
                error.Show();
            }
            else if(IDsearch.Checked == true)
            {
                
                parser.parse(searchBox.Text, Field.PartNumber, dataGridView1, loader);
            }else if(nameSearch.Checked == true)
            {
                parser.parse(searchBox.Text, Field.Desc, dataGridView1, loader);
            }
            else if (locSearch.Checked == true)
            {
                parser.parse(searchBox.Text, Field.Location, dataGridView1, loader);
            }
        }

        private void pictureSettings_Click(object sender, EventArgs e)
        {
            OptionsMenu form = new OptionsMenu(this);
            this.Hide();
            form.Show();
        }

       
    }
}

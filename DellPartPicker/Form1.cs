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

            initCollective();
            
        }

        private void initCollective()
        {
            collectiveTable.ColumnCount = 3;
            collectiveTable.Columns[0].Name = "Part Number";
            collectiveTable.Columns[1].Name = "Description";
            collectiveTable.Columns[2].Name = "Location";
        }
        private void disableFunctions()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            addSingletable.AllowUserToResizeColumns = false;
            addSingletable.AllowUserToResizeRows = false;
            addSingletable.ReadOnly = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            error.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            addSingletable.Rows.Clear();

            if(searchBox.Text == null || searchBox.Text == "")
            {
                error.Show();
            }
            else if(IDsearch.Checked == true)
            {
                
                parser.parse(searchBox.Text, Field.PartNumber, addSingletable, loader);
            }else if(nameSearch.Checked == true)
            {
                parser.parse(searchBox.Text, Field.Desc, addSingletable, loader);
            }
            else if (locSearch.Checked == true)
            {
                parser.parse(searchBox.Text, Field.Location, addSingletable, loader);
            }
        }

        private void pictureSettings_Click(object sender, EventArgs e)
        {
            OptionsMenu form = new OptionsMenu(this);
            this.Hide();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OptionsMenu form = new OptionsMenu(this);
            this.Hide();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OptionsMenu form = new OptionsMenu(this);
            this.Hide();
            form.Show();
        }

        private void listSearchBttn_Click(object sender, EventArgs e)
        {
            addListTable.Rows.Clear();
            String data = listTextBox.Text;
            String[] dataArray = data.Split(
                new[] { Environment.NewLine }
                ,StringSplitOptions.None);
            ParseList pl = new ParseList();
            pl.searchList(dataArray, addListTable, loader);

        }

        private void bttnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.collectiveTable.SelectedRows)
            {
                collectiveTable.Rows.RemoveAt(item.Index);
            }
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            collectiveTable.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            collectiveTable.Rows.Add(addListTable.Rows);
            collectiveTable.Rows.Clear();
        }

        private void addSelectedBttn_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow item in this.addSingletable.SelectedRows)
            {
                collectiveTable.Rows.Add(addSingletable.Rows[item.Index]);
                addSingletable.Rows.RemoveAt(item.Index);
            }

        }
    }
}

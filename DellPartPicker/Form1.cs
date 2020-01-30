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
        public static Boolean isDark = false;
        Parser parser = new Parser();
        public Color shelfColorNormal = Color.FromKnownColor(KnownColor.Gray);
        public Color shelfColorHighlight = Color.FromKnownColor(KnownColor.ActiveCaption);

        public Form1()
        {
            InitializeComponent();
            
            disableFunctions();

            initCollective();

            initMapList();
        }
        
        private void initCollective()
        {
            collectiveTable.ColumnCount = 3;
            collectiveTable.Columns[0].Name = "Part Number";
            collectiveTable.Columns[1].Name = "Description";
            collectiveTable.Columns[2].Name = "Location";
        }
        private void initMapList()
        {
            mapList.ColumnCount = 3;
            mapList.Columns[0].Name = "Part Number";
            mapList.Columns[1].Name = "Description";
            mapList.Columns[2].Name = "Location";

            // also init map
        }
        private void disableFunctions()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            addSingletable.AllowUserToResizeColumns = false;
            addSingletable.AllowUserToResizeRows = false;
            addSingletable.ReadOnly = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            error.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            addSingletable.Rows.Clear();

            if(searchBox.Text == null || searchBox.Text == "")
            {
                error.Show();
            }           
            parser.parse(searchBox.Text, Field.PartNumber, addSingletable, loader);
        }

        // the options button in some tab
        private void pictureSettings_Click(object sender, EventArgs e)
        {
            OpenOptions();
        }


        // the other options button in some tab
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenOptions();
        }

        // another options button in some tab
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenOptions();
        }

        // open the options menu and hide the main form
        private void OpenOptions()
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
            // remove all selected items from the collected list
            foreach (DataGridViewRow item in this.collectiveTable.SelectedRows)
            {
                collectiveTable.Rows.RemoveAt(item.Index);
                
            }
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            // clear the list
            collectiveTable.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e) {
            
            DataTable dt = toTable(addListTable);

            // prepare columns for the lists
            foreach (DataColumn dc in dt.Columns)
            {

                collectiveTable.Columns.Add(new DataGridViewTextBoxColumn());
                mapList.Columns.Add(new DataGridViewTextBoxColumn());

            }

            // prepare rows for the lists
            foreach (DataRow dr in dt.Rows)
            {
                collectiveTable.Rows.Add(dr.ItemArray);
                mapList.Rows.Add(dr.ItemArray);
            }
        }

        private void addSelectedBttn_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < addSingletable.SelectedRows.Count; i++)
            {
                //add empty rows to table
                int index = collectiveTable.Rows.Add();
                int index2 = mapList.Rows.Add();

                //add to collective list
                collectiveTable.Rows[index].Cells[0].Value = addSingletable.SelectedRows[i].Cells[0].Value.ToString();
                collectiveTable.Rows[index].Cells[1].Value = addSingletable.SelectedRows[i].Cells[1].Value.ToString();
                collectiveTable.Rows[index].Cells[2].Value = addSingletable.SelectedRows[i].Cells[2].Value.ToString();

                //add too map list
                mapList.Rows[index2].Cells[0].Value = addSingletable.SelectedRows[i].Cells[0].Value.ToString();
                mapList.Rows[index2].Cells[1].Value = addSingletable.SelectedRows[i].Cells[1].Value.ToString();
                mapList.Rows[index2].Cells[2].Value = addSingletable.SelectedRows[i].Cells[2].Value.ToString();
            }

        }

    

        private DataTable toTable(DataGridView dgv)
        {

            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }

        private void d3pLogo1_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            error.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addSingletable.Rows.Clear();

            if (searchBox.Text == null || searchBox.Text == "")
            {
                error.Show();
            }
            parser.parse(searchBox.Text, Field.Desc, addSingletable, loader);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            addSingletable.Rows.Clear();

            if (searchBox.Text == null || searchBox.Text == "")
            {
                error.Show();
            }
            parser.parse(searchBox.Text, Field.Location, addSingletable, loader);
        }



        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateMap()
        {
            
        }
    }
}

using DellPartPicker.utils;
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
        public static int selectedRow = 0;

        public Form1()
        {
            InitializeComponent();
            
            disableFunctions();

            initCollective();
            
        }

        private void initCollective()
        {
            //the column count
            dataGridList.ColumnCount = 3;

            //set the column headers
            dataGridList.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //select the whole row
            dataGridList.Columns[0].Name = "Part Number";
            dataGridList.Columns[1].Name = "Description";
            dataGridList.Columns[2].Name = "Location";
        }
        private void disableFunctions()
        {
            //disable some functions
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            addSingletable.AllowUserToResizeColumns = false;
            addSingletable.AllowUserToResizeRows = false;
            addSingletable.ReadOnly = true;
            dataGridList.ReadOnly = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            error.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            //clear the table
            addSingletable.Rows.Clear();

            //test for null input
            if(searchBox.Text == null || searchBox.Text == "")
            {
                error.Show();
            }           
            //search
            parser.parse(searchBox.Text, Field.PartNumber, addSingletable, loader);
        }

        private void pictureSettings_Click(object sender, EventArgs e)
        {
            //show the options menu
            OptionsMenu form = new OptionsMenu(this);
            this.Hide();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //show the options menu
            OptionsMenu form = new OptionsMenu(this);
            this.Hide();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //show the options menue
            OptionsMenu form = new OptionsMenu(this);
            this.Hide();
            form.Show();
        }

        private void listSearchBttn_Click(object sender, EventArgs e)
        {
            //just search
            search();
        }

        private void search()
        {
            //clear the table
            addListTable.Rows.Clear();

            //get the data in teh textbox
            String data = listTextBox.Text;
            //make an array splitting on a newline
            String[] dataArray = data.Split(
                new[] { Environment.NewLine }
                , StringSplitOptions.None);

            //parse the list
            ParseList pl = new ParseList();

            //search and add
            pl.searchList(dataArray, addListTable, loader);
        }

        private void bttnRemove_Click(object sender, EventArgs e)
        {
            // remove the all selected items from the collected list
            foreach (DataGridViewRow item in this.dataGridList.SelectedRows)
            {
                dataGridList.Rows.RemoveAt(item.Index);
            }
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            // clear the list
            dataGridList.Rows.Clear();
        }

        private void addAll_click(object sender, EventArgs e) {
            search();
            DataTable dt = toTable(addListTable);

            foreach (DataColumn dc in dt.Columns)
            {

                dataGridList.Columns.Add(new DataGridViewTextBoxColumn());

            }
            foreach (DataRow dr in dt.Rows)
            {

                dataGridList.Rows.Add(dr.ItemArray);

            }
            
            


        }

        private void addSelectedBttn_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < addSingletable.SelectedRows.Count; i++)
            {
                int index = dataGridList.Rows.Add();
                dataGridList.Rows[index].Cells[0].Value = addSingletable.SelectedRows[i].Cells[0].Value.ToString();
                dataGridList.Rows[index].Cells[1].Value = addSingletable.SelectedRows[i].Cells[1].Value.ToString();
                dataGridList.Rows[index].Cells[2].Value = addSingletable.SelectedRows[i].Cells[2].Value.ToString();
            }

        }

        private DataTable toTable(DataGridView dgv)
        {
            //convert the datagridview to a table

            //make a new datatable
            DataTable dt = new DataTable();

            //iterate through the columns
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                //add the column names to the table
                dt.Columns.Add(col.Name);
            }

            //iterate through the rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                //make a new row
                DataRow dRow = dt.NewRow();
                //iterate through the cells
                foreach (DataGridViewCell cell in row.Cells)
                {
                    //add the cells to the datatable
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                //add the row
                dt.Rows.Add(dRow);
            }
            //return the datatable
            return dt;
        }

        private void d3pLogo1_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            //hide the error
            error.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear the table
            addSingletable.Rows.Clear();

            //test for null or empty input
            if (searchBox.Text == null || searchBox.Text == "")
            {
                //show the error
                error.Show();
            }
            //search
            parser.parse(searchBox.Text, Field.Desc, addSingletable, loader);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //clear the table
            addSingletable.Rows.Clear();

            //test for null or empty input
            if (searchBox.Text == null || searchBox.Text == "")
            {
                //show the error
                error.Show();
            }
            //search for the items
            parser.parse(searchBox.Text, Field.Location, addSingletable, loader);
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void removeSelected_Click(object sender, EventArgs e)
        {
            // remove the all selected items from the collected list
            foreach (DataGridViewRow item in this.dataGridList.SelectedRows)
            {
                Console.WriteLine("item index" + item.Index);
                dataGridList.Rows.RemoveAt(item.Index);
            }
        }

        private void clearbttn_click(object sender, EventArgs e)
        {
            // clear the list
            dataGridList.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void findbtn_Click(object sender, EventArgs e)
        {
            //reset the picture boxes
            TestingUtils.clearAll(this);

            //if the selected row is the last one
            if(selectedRow <= 0)
            {
                //reset to 0
                selectedRow = 0;

                //try to select it
                Selectors.select(this);
            }

            //it is not the last one so deincrement and select
            selectedRow--;
            Selectors.select(this);
        }

        

        
        // TODO
        // remove this function as it serves no purpose
        private void map_Click(object sender, EventArgs e)
        {

        }

        //find the selected stuff in the table
        private void findSelected_Click(object sender, EventArgs e)
        {
            //clear all the picture boxes
            TestingUtils.clearAll(this);

            //turn the selected row a white
            Selectors.select(dataGridList.SelectedRows, this);
            try
            {
                //try to set selectedRow to the current selected Row's index
                selectedRow = dataGridList.SelectedRows[0].Index;
            }catch
            {
                //if you did not select this message should display
                maperrorLabel.Visible = true;
                maperrorLabel.Text = "please select something before using this button";
            }
        }
        

        //this is the function for clicking onto the next selection
        private void next_Click(object sender, EventArgs e)
        {
            //set all the pictureboxes to white
            TestingUtils.clearAll(this);

            //test to see if out of bounds
            if (selectedRow >= dataGridList.Rows.Count - 1)
            {
                //set to the very last row
                selectedRow = dataGridList.Rows.Count - 1;

                //call select
                Selectors.select(this);
            }
            //if the selected row is not the last
            selectedRow++;
            Selectors.select(this);
        }

        private void d3pTitle1_Click(object sender, EventArgs e)
        {

        }

        private void listTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    

    //class that we use to help determine what each thing is equal to
    

    
}

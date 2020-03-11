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
                select();
            }

            //it is not the last one so deincrement and select
            selectedRow--;
            select();
        }

        private bool select()
        {
            TestingUtils.clearAll(this);
            if (selectedRow >= (dataGridList.Rows.Count)) //if the selected row is out of bounds
            {
                //reset the selected row to 0
                selectedRow = 0;

                //set the error message
                maperrorLabel.Text = "can't select any further";
                maperrorLabel.Visible = true;

                //return false, there is no more previous items
                return false;
            }
            try
            {
                //try to get the location
                String loc = dataGridList.Rows[selectedRow].Cells[2].Value.ToString();
                if (loc == "not found") //if the location does not exist
                {
                    //set the error accordingly
                    maperrorLabel.Text = "This item does not exist.";
                    maperrorLabel.Visible = true;

                    //return false, as it didn't work out
                    return false;
                }
                //turn the location into a shelf enum
                Shelf en = TestingUtils.getShelf(loc);

                //get the picturebox that corresponds to that enum and set its color to white
                TestingUtils.getBox(en, this).BackColor = Color.White;

                //go through all of the rows and deselect them
                foreach (DataGridViewRow r in dataGridList.Rows)
                {
                    r.Selected = false;
                }

                //select the current row
                dataGridList.Rows[selectedRow].Selected = true;

                //any error now disappears
                maperrorLabel.Visible = false;

                //get the linumber for whatever the selected item is
                int linenum = Loader.getLineNumber(
                    dataGridList.Rows[selectedRow].Cells[0].Value.ToString(),
                    dataGridList.Rows[selectedRow].Cells[1].Value.ToString());

                // TODO
                // do something with the line number

                return true;
            }
            catch(ArgumentOutOfRangeException e)
            {
                //assume that there is nothing in the table and set the error accordingly
                maperrorLabel.Visible = true;
                maperrorLabel.Text = "nothing is in that table";

                //return false because something failed
                return false;
            }
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
            select(dataGridList.SelectedRows);
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
        //this is the picture finder method for selected files
        private bool select(DataGridViewSelectedRowCollection sel)
        {
            
            try
            {
                //try to get the location
                String loc = sel[0].Cells[2].Value.ToString();
                if (loc == "not found")
                {
                    //not found then set the error to correspond
                    maperrorLabel.Text = "This item does not exist.";
                    maperrorLabel.Visible = true;

                    //return false because it failed
                    return false;
                }
                //get the enum for the location
                Shelf en = TestingUtils.getShelf(loc);

                //enum -> picturebox; picturebox.color = white
                //enum to picturebox then change the color to white
                TestingUtils.getBox(en, this).BackColor = Color.White;

                //any error disappears
                maperrorLabel.Visible = false;

                //get the line number of that selected item
                int linenum = Loader.getLineNumber(
                    sel[0].Cells[0].Value.ToString(),
                    sel[0].Cells[1].Value.ToString());

                // TODO
                // do something with the line number

                return true;
            }
            catch (ArgumentOutOfRangeException e)
            {
                //assume that there is nothing in the table and set the error accordingly
                maperrorLabel.Visible = true;
                maperrorLabel.Text = "nothing is selected";

                //return false because it failed
                return false;
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
                select();
            }
            //if the selected row is not the last
            selectedRow++;
            select();
        }

        private void d3pTitle1_Click(object sender, EventArgs e)
        {

        }

        private void listTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    //this is the enum with all the shelf names
    public enum Shelf
    {
        A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X
    }

    //class that we use to help determine what each thing is equal to
    public class TestingUtils
    {
        //this resets the color of all the picture boxes
        public static void clearAll(Form1 form)
        {
            form.shelfA.BackColor = Color.Gray;
            form.shelfB.BackColor = Color.Gray;
            form.shelfC.BackColor = Color.Gray;
            form.shelfD.BackColor = Color.Gray;
            form.shelfE.BackColor = Color.Gray;
            form.shelfF.BackColor = Color.Gray;
            form.shelfG.BackColor = Color.Gray;
            form.shelfH.BackColor = Color.Gray;
            form.shelfI.BackColor = Color.Gray;
            form.shelfJ.BackColor = Color.Gray;
            form.shelfK.BackColor = Color.Gray;
            form.shelfL.BackColor = Color.Gray;
            form.shelfM.BackColor = Color.Gray;
            form.shelfN.BackColor = Color.Gray;
            form.shelfO.BackColor = Color.Gray;
            form.shelfP.BackColor = Color.Gray;
            form.shelfQ.BackColor = Color.Gray;
            form.shelfR.BackColor = Color.Gray;
            form.shelfS.BackColor = Color.Gray;
            form.shelfT.BackColor = Color.Gray;
            form.shelfU.BackColor = Color.Gray;
            form.shelfV.BackColor = Color.Gray;
            form.shelfW.BackColor = Color.Gray;
            form.shelfX.BackColor = Color.Gray;
        }

        //picture box getting function
        public static PictureBox getBox(Shelf shelf, Form1 form)
        {
            //all of the functions to cycle through
            if (shelf == Shelf.A)
            {
                return form.shelfA;
            }
            else if (shelf == Shelf.B)
            {
                return form.shelfB;
            }
            else if (shelf == Shelf.C)
            {
                return form.shelfC;
            }
            else if (shelf == Shelf.D)
            {
                return form.shelfD;
            }
            else if (shelf == Shelf.E)
            {
                return form.shelfE;
            }
            else if (shelf == Shelf.F)
            {
                return form.shelfF;
            }
            else if (shelf == Shelf.G)
            {
                return form.shelfG;
            }
            else if (shelf == Shelf.H)
            {
                return form.shelfH;
            }
            else if (shelf == Shelf.I)
            {
                return form.shelfI;
            }
            else if (shelf == Shelf.J)
            {
                return form.shelfJ;
            }
            else if (shelf == Shelf.K)
            {
                return form.shelfK;
            }
            else if (shelf == Shelf.L)
            {
                return form.shelfL;
            }
            else if (shelf == Shelf.M)
            {
                return form.shelfM;
            }
            else if (shelf == Shelf.N)
            {
                return form.shelfN;
            }
            else if (shelf == Shelf.O)
            {
                return form.shelfO;
            }
            else if (shelf == Shelf.P)
            {
                return form.shelfP;
            }
            else if (shelf == Shelf.Q)
            {
                return form.shelfQ;
            }
            else if (shelf == Shelf.R)
            {
                return form.shelfR;
            }
            else if (shelf == Shelf.S)
            {
                return form.shelfS;
            }
            else if (shelf == Shelf.T)
            {
                return form.shelfT;
            }
            else if (shelf == Shelf.U)
            {
                return form.shelfU;
            }
            else if (shelf == Shelf.V)
            {
                return form.shelfV;
            }
            else if (shelf == Shelf.W)
            {
                return form.shelfW;
            }
            else if (shelf == Shelf.X)
            {
                return form.shelfX;
            }
            else
            {
                //if something happened do something
                throw new Exception("something went wrong with location " + shelf.ToString());
            }
        }

        //get the enum
        public static Shelf getShelf(String loc)
        {
            //get the location letter
            char locLetter = loc.ToCharArray()[0];

            //tests
            if (locLetter == (Shelf.A.ToString().ToCharArray()[0]))
            {
                return Shelf.A;
            }
            else if (locLetter == (Shelf.B.ToString().ToCharArray()[0]))
            {
                return Shelf.B;
            }
            else if (locLetter == (Shelf.C.ToString().ToCharArray()[0]))
            {
                return Shelf.C;
            }
            else if (locLetter == (Shelf.D.ToString().ToCharArray()[0]))
            {
                return Shelf.D;
            }
            else if (locLetter == (Shelf.E.ToString().ToCharArray()[0]))
            {
                return Shelf.E;
            }
            else if (locLetter == (Shelf.F.ToString().ToCharArray()[0]))
            {
                return Shelf.F;
            }
            else if (locLetter == (Shelf.G.ToString().ToCharArray()[0]))
            {
                return Shelf.G;
            }
            else if (locLetter == (Shelf.H.ToString().ToCharArray()[0]))
            {
                return Shelf.H;
            }
            else if (locLetter == (Shelf.I.ToString().ToCharArray()[0]))
            {
                return Shelf.I;
            }
            else if (locLetter == (Shelf.J.ToString().ToCharArray()[0]))
            {
                return Shelf.J;
            }
            else if (locLetter == (Shelf.K.ToString().ToCharArray()[0]))
            {
                return Shelf.K;
            }
            else if (locLetter == (Shelf.L.ToString().ToCharArray()[0]))
            {
                return Shelf.L;
            }
            else if (locLetter == (Shelf.M.ToString().ToCharArray()[0]))
            {
                return Shelf.M;
            }
            else if (locLetter == (Shelf.N.ToString().ToCharArray()[0]))
            {
                return Shelf.N;
            }
            else if (locLetter == (Shelf.O.ToString().ToCharArray()[0]))
            {
                return Shelf.O;
            }
            else if (locLetter == (Shelf.P.ToString().ToCharArray()[0]))
            {
                return Shelf.P;
            }
            else if (locLetter == (Shelf.Q.ToString().ToCharArray()[0]))
            {
                return Shelf.Q;
            }
            else if (locLetter == (Shelf.R.ToString().ToCharArray()[0]))
            {
                return Shelf.R;
            }
            else if (locLetter == (Shelf.S.ToString().ToCharArray()[0]))
            {
                return Shelf.S;
            }
            else if (locLetter == (Shelf.T.ToString().ToCharArray()[0]))
            {
                return Shelf.T;
            }
            else if (locLetter == (Shelf.U.ToString().ToCharArray()[0]))
            {
                return Shelf.U;
            }
            else if (locLetter == (Shelf.V.ToString().ToCharArray()[0]))
            {
                return Shelf.V;
            }
            else if (locLetter == (Shelf.W.ToString().ToCharArray()[0]))
            {
                return Shelf.W;
            }
            else if (locLetter == (Shelf.X.ToString().ToCharArray()[0]))
            {
                return Shelf.X;
            }
            else
            {
                //something went wrong!
                throw new Exception("something went wrong with location " + loc);
            }

        }
    }
}

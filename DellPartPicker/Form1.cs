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

        public Form1()
        {
            InitializeComponent();
            
            disableFunctions();

            initCollective();
            
        }

        private void initCollective()
        {
            dataGridList.ColumnCount = 3;

            dataGridList.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //select the whole row
            dataGridList.Columns[0].Name = "Part Number";
            dataGridList.Columns[1].Name = "Description";
            dataGridList.Columns[2].Name = "Location";
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
            search();
        }

        private void search()
        {
            addListTable.Rows.Clear();
            String data = listTextBox.Text;
            String[] dataArray = data.Split(
                new[] { Environment.NewLine }
                , StringSplitOptions.None);
            ParseList pl = new ParseList();
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

        private void button2_Click(object sender, EventArgs e) {
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

        private void removeSelected_Click(object sender, EventArgs e)
        {
            // remove the all selected items from the collected list
            foreach (DataGridViewRow item in this.dataGridList.SelectedRows)
            {
                Console.WriteLine("item index" + item.Index);
                dataGridList.Rows.RemoveAt(item.Index);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // clear the list
            dataGridList.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void findbtn_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dataGridList.GetCellCount(DataGridViewElementStates.Selected);
            if(selectedCellCount > 0)
            {
                if (dataGridList.AreAllCellsSelected(true))
                {
                    try
                    {
                        String loc = dataGridList.Rows[0].Cells[2].Value.ToString();
                        if(loc == "not found")
                        {
                            int temp = 1;
                            do
                            {
                                loc = dataGridList.Rows[temp].Cells[2].Value.ToString();
                            } while (loc == "not found" && dataGridList.Rows.Count >= temp);
                            if (loc == "not found")
                            {

                            }
                            else
                            {
                                Shelf en = getShelf(loc);

                                getBox(en).BackColor = Color.White;
                            }

                        }
                    }catch(Exception ex)
                    {
                        //nothing is in the table
                    }
                }
                else
                {
                    try
                    {
                        String loc = dataGridList.SelectedRows[0].Cells[2].Value.ToString();

                        if (loc == "not found" && dataGridList.SelectedRows.Count != 1)
                        {
                            int temp = 1;
                            do
                            {
                                loc = dataGridList.SelectedRows[temp].Cells[2].Value.ToString();
                            } while (loc == "not found" && dataGridList.Rows.Count >= temp);
                            
                        }
                        if(loc == "not found")
                        {

                        }
                        else
                        {
                            Shelf en = getShelf(loc);

                            getBox(en).BackColor = Color.White;
                        }
                        
                    }catch(Exception exc)
                    {

                    }
                }
            }
        }

        private PictureBox getBox(Shelf shelf)
        {
            if (shelf == Shelf.A)
            {
                return shelfA;
            }
            else if (shelf == Shelf.B)
            {
                return shelfB;
            }
            else if (shelf == Shelf.C)
            {
                return shelfC;
            }
            else if (shelf == Shelf.D)
            {
                return shelfD;
            }
            else if (shelf == Shelf.E)
            {
                return shelfE;
            }
            else if (shelf == Shelf.F)
            {
                return shelfF;
            }
            else if (shelf == Shelf.G)
            {
                return shelfG;
            }
            else if (shelf == Shelf.H)
            {
                return shelfH;
            }
            else if (shelf == Shelf.I)
            {
                return shelfI;
            }
            else if (shelf == Shelf.J)
            {
                return shelfJ;
            }
            else if (shelf == Shelf.K)
            {
                return shelfK;
            }
            else if (shelf == Shelf.L)
            {
                return shelfL;
            }
            else if (shelf == Shelf.M)
            {
                return shelfM;
            }
            else if (shelf == Shelf.N)
            {
                return shelfN;
            }
            else if (shelf == Shelf.O)
            {
                return shelfO;
            }
            else if (shelf == Shelf.P)
            {
                return shelfP;
            }
            else if (shelf == Shelf.Q)
            {
                return shelfQ;
            }
            else if (shelf == Shelf.R)
            {
                return shelfR;
            }
            else if (shelf == Shelf.S)
            {
                return shelfS;
            }
            else if (shelf == Shelf.T)
            {
                return shelfT;
            }
            else if (shelf == Shelf.U)
            {
                return shelfU;
            }
            else if (shelf == Shelf.V)
            {
                return shelfV;
            }
            else if (shelf == Shelf.W)
            {
                return shelfW;
            }
            else if (shelf == Shelf.X)
            {
                return shelfX;
            }
            else
            {
                throw new Exception("something went wrong with location " + shelf.ToString());
            }
        }

        private Shelf getShelf(String loc)
        {
            char locLetter = loc.ToCharArray()[0];

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
                throw new Exception("something went wrong with location " + loc);
            }

        }

        
    }
    public enum Shelf
    {
        A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X
    }
}

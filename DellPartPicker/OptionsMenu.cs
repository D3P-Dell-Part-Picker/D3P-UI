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
    public partial class OptionsMenu : Form
    {
        Form1 form1;
        Boolean isDark;
        public OptionsMenu(Form1 f)
        {
            form1 = f;
            
            InitializeComponent();
            if (form1.BackColor == Color.FromArgb(46, 48, 54))
            {
                isDark = true;
                radioDrk.Checked = true;
            }
            toggleDark(isDark);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            form1.Show();
        }

        private void radioLt_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void radioDrk_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (radioDrk.Checked == true)
            {
                toggleDark(true);
            }
            if (radioLt.Checked == true)
            {
                toggleDark(false);
            }
        }
        private void toggleDark(Boolean b)
        {
            if (b)
            {
                this.BackColor = Color.FromArgb(46, 48, 54);
                radioLt.ForeColor = Color.White;
                radioDrk.ForeColor = Color.White;
                optionsLbl.ForeColor = Color.White;

                form1.BackColor = Color.FromArgb(46, 48, 54);
                form1.Searchlbl.ForeColor = Color.White;
                form1.locSearch.ForeColor = Color.White;
                form1.nameSearch.ForeColor = Color.White;
                form1.IDsearch.ForeColor = Color.White;
                form1.searchBox.BackColor = Color.Gray;
                form1.searchBox.ForeColor = Color.White;
                form1.error.ForeColor = Color.Pink;
                form1.title.ForeColor = Color.White;
                form1.title.BackColor = Color.FromArgb(46, 48, 54);

                radioDrk.Checked = true;
                //TODO make this work for the table
                /*
                 * change the background color of the cells in the table
                 */
                 /*
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                style.BackColor = Color.FromArgb(((GesTest.dsEssais.FMstatusAnomalieRow)row.DataBoundItem).iColor);
                style.ForeColor = Color.Black;
                row.Cells[color.Index].Style = style;
                */
            }
            else
            {
                this.BackColor = Color.White;
                radioLt.ForeColor = Color.Black;
                radioDrk.ForeColor = Color.Black;
                optionsLbl.ForeColor = SystemColors.Highlight;

                form1.BackColor = Color.White;
                form1.Searchlbl.ForeColor = Color.Black;
                form1.locSearch.ForeColor = Color.Black;
                form1.nameSearch.ForeColor = Color.Black;
                form1.IDsearch.ForeColor = Color.Black;
                form1.searchBox.BackColor = Color.White;
                form1.searchBox.ForeColor = Color.Black;
                form1.error.ForeColor = Color.Maroon;
                form1.title.ForeColor = SystemColors.Highlight;
                form1.title.BackColor = Color.White;

                radioLt.Checked = true;
            }
        }
    }
}

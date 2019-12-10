﻿using System;
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
                /*
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

                

                //title

                form1.d3pTitle1.ForeColor = Color.White;
                form1.d3pTitle1.BackColor = Color.FromArgb(46, 48, 54);
                form1.d3pTitle2.ForeColor = Color.White;
                form1.d3pTitle2.BackColor = Color.FromArgb(46, 48, 54);
                form1.d3pTitle3.ForeColor = Color.White;
                form1.d3pTitle3.BackColor = Color.FromArgb(46, 48, 54);

                //labels

                form1.collectiveLbl.ForeColor = Color.White;
                form1.dumpLbl.ForeColor = Color.White;
                form1.enterHere.ForeColor = Color.White;


                //checked

                radioDrk.Checked = true;

                //edit tab1

                form1.listTab.BackColor = Color.FromArgb(46, 48, 54);
                form1.collectiveTab.BackColor = Color.FromArgb(46, 48, 54);
                form1.singleItemTab.BackColor = Color.FromArgb(46, 48, 54);

                //edit textboxes

                form1.listTextBox.BackColor = Color.Gray;
                form1.listTextBox.ForeColor = Color.White;



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
                radioDrk.Checked = true;
                foreach (Control subC in this.Controls)
                {
                    UpdateColorControlsDrk(subC);
                }
                foreach (Control subC in form1.Controls)
                {
                    UpdateColorControlsDrk(subC);
                }
                
            }
            else
            {
                /*
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

                //title


                form1.d3pTitle1.ForeColor = SystemColors.Highlight;
                form1.d3pTitle1.BackColor = Color.White;
                form1.d3pTitle2.ForeColor = SystemColors.Highlight;
                form1.d3pTitle2.BackColor = Color.White;
                form1.d3pTitle3.ForeColor = SystemColors.Highlight;
                form1.d3pTitle3.BackColor = Color.White;

                radioLt.Checked = true;

                //labels

                form1.collectiveLbl.ForeColor = Color.Black;
                form1.dumpLbl.ForeColor = Color.Black;
                form1.enterHere.ForeColor = Color.Black;

                //edit tabs

                form1.listTab.BackColor = Color.White;
                form1.collectiveTab.BackColor = Color.White;
                form1.singleItemTab.BackColor = Color.White;
                */
                radioLt.Checked = true;
                foreach (Control subC in this.Controls)
                {
                    UpdateColorControlsLite(subC);
                }
                foreach (Control subC in form1.Controls)
                {
                    UpdateColorControlsLite(subC);
                }
                
            }
        }
        public void UpdateColorControlsDrk(Control myControl)
        {
            this.BackColor = Color.FromArgb(46, 48, 54);
            form1.BackColor = Color.FromArgb(46, 48, 54);
            form1.error.BackColor = Color.White;
            form1.listTab.BackColor = Color.FromArgb(46, 48, 54);
            form1.collectiveTab.BackColor = Color.FromArgb(46, 48, 54);
            form1.singleItemTab.BackColor = Color.FromArgb(46, 48, 54);
            myControl.BackColor = Color.Transparent;
            myControl.ForeColor = Color.White;
        }
            
        public void UpdateColorControlsLite(Control myControl)
        {
            this.BackColor = Color.White;
            form1.BackColor = Color.White;
            form1.error.BackColor = Color.White;
            form1.listTab.BackColor = Color.White;
            form1.collectiveTab.BackColor = Color.White;
            form1.singleItemTab.BackColor = Color.White;
            myControl.BackColor = Color.Transparent;
            myControl.ForeColor = Color.Black;
        }
    }
}

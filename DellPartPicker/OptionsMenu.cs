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
        List<Label> labels;
        public OptionsMenu(Form1 f)
        {
            form1 = f;

            labels = new List<Label>();
            
            InitializeComponent();
            addLabels();
            
            if (Form1.isDark)
            {
                isDark = true;
                radioDrk.Checked = true;
            }
            toggleDark(isDark);

        }

        private void addLabels()
        {
            labels.Add(form1.enterHere);
            labels.Add(form1.dumpLbl);
            labels.Add(form1.Searchlbl);
            labels.Add(form1.results);
            labels.Add(form1.enterHere);
            labels.Add(form1.enterHere);
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
                //If the user goes back into the options menu, the radio is still checked
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
                //If the user goes back into the options menu, the radio is still checked
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

        //Function for Dark theme
        public void UpdateColorControlsDrk(Control myControl)
        {

            //set boolean variable
            Form1.isDark = true;

            //Attempt at condensing code
            var optionb = from controls in this.Controls.OfType<Button>()
                    select controls;
            foreach (var control in optionb)
            {
                control.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
                control.BackColor = Color.FromArgb(115, 138, 214);
                control.ForeColor = Color.White;
            }

            //Changes color of the radio buttons in option menu
            var optionrb = from controls in this.Controls.OfType<RadioButton>()
                          select controls;
            foreach (var control in optionrb)
            {
                control.ForeColor = Color.White;
            }

            //Changes color of labels in option menu
            var optionlbl = from controls in this.Controls.OfType<Label>()
                          select controls;
            foreach (var control in optionlbl)
            {
                control.ForeColor = Color.White;
            }

            //Changes color of labels in form1
            foreach (Label l in labels)
            {
                l.ForeColor = Color.White;
            }
                
                    
            //Changes background color
            this.BackColor = Color.FromArgb(44, 47, 51);
            form1.BackColor = Color.FromArgb(35, 39, 42);
            form1.listTab.BackColor = Color.FromArgb(44, 47, 51);
            form1.map.BackColor = Color.FromArgb(44, 47, 51);
            form1.singleItemTab.BackColor = Color.FromArgb(44, 47, 51);
            form1.error.BackColor = Color.White;
            form1.d3pTitle1.ForeColor = Color.White;
            form1.d3pTitle2.ForeColor = Color.White;

            //Changes settings to Dark Ver.
            form1.pictureSettings1.Image = Properties.Resources.settingsicon_dark;
            form1.pictureSettings2.Image = Properties.Resources.settingsicon_dark;


            //Changes logo to Dark Ver.
            form1.d3pLogo1.Image = Properties.Resources.Dell_logo_2016_dark;
            form1.d3pLogo2.Image = Properties.Resources.Dell_logo_2016_dark;
            //Exceptions from the function (form background, title backcolor)
            
            

            
            
            //Change table colors
            form1.addSingletable.BackgroundColor = Color.FromArgb(35, 39, 42);
            form1.addSingletable.ForeColor = Color.Gray;
            form1.addSingletable.GridColor = Color.Gray;
            form1.addListTable.BackgroundColor = Color.FromArgb(35, 39, 42);
            form1.addListTable.ForeColor = Color.Gray;
            form1.addListTable.GridColor = Color.Gray;
            form1.dataGridList.BackgroundColor = Color.FromArgb(35, 39, 42);
            form1.dataGridList.ForeColor = Color.Gray;
            form1.dataGridList.GridColor = Color.Gray;

            form1.searchName.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.searchLoc.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.searchID.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.listSearchBttn.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.addAll.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.bttnClear.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.bttnRemove.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.searchName.BackColor = Color.FromArgb(115, 138, 214);
            form1.searchLoc.BackColor = Color.FromArgb(115, 138, 214);
            form1.searchID.BackColor = Color.FromArgb(115, 138, 214);
            form1.listSearchBttn.BackColor = Color.FromArgb(115, 138, 214);
            form1.addAll.BackColor = Color.FromArgb(115, 138, 214);
            form1.bttnClear.BackColor = Color.FromArgb(115, 138, 214);
            form1.bttnRemove.BackColor = Color.FromArgb(115, 138, 214);
            form1.addSelectedBttn.BackColor = Color.FromArgb(115, 138, 214);
            form1.addSelectedBttn.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
        }
            
        //Light theme function
        public void UpdateColorControlsLite(Control myControl)
        {
            //change the boolean variable
            Form1.isDark = false;


            //Exceptions from the function (form background, title backcolor)
            this.BackColor = Color.White;
            form1.BackColor = Color.White;
            form1.error.BackColor = Color.White;
            form1.listTab.BackColor = Color.White;
            form1.map.BackColor = Color.White;
            form1.singleItemTab.BackColor = Color.White;
            form1.d3pTitle1.ForeColor = SystemColors.Highlight;
            form1.d3pTitle2.ForeColor = SystemColors.Highlight;
            
            
            form1.addSingletable.BackgroundColor = Color.FromArgb(240, 255, 252);

            //Change table colors
            form1.addListTable.BackgroundColor = Color.FromArgb(240, 255, 252);
            form1.dataGridList.BackgroundColor = Color.FromArgb(240, 255, 252);

            //Changes backcolor and forecolor of everything it can change
            myControl.BackColor = Color.Transparent;
            myControl.ForeColor = Color.Black;

            //Change logo to Light Ver.
            form1.d3pLogo1.Image = Properties.Resources.Dell_logo_2016;
            form1.d3pLogo2.Image = Properties.Resources.Dell_logo_2016;

            //Changes settings to Light Ver.
            form1.pictureSettings1.Image = Properties.Resources.settingsicon;
            form1.pictureSettings2.Image = Properties.Resources.settingsicon;

            //Change color of all buttons manually
            myControl.BackColor = Color.Transparent;
            this.buttonApply.FlatAppearance.BorderColor = Color.FromArgb(199,204,209);
            this.buttonBack.FlatAppearance.BorderColor = Color.FromArgb(199, 204, 209);
            this.buttonApply.BackColor = Color.FromArgb(199, 204, 209);
            this.buttonBack.BackColor = Color.FromArgb(199, 204, 209);
            form1.searchName.FlatAppearance.BorderColor = Color.Black;
            form1.searchLoc.FlatAppearance.BorderColor = Color.Black;
            form1.searchID.FlatAppearance.BorderColor = Color.Black;
            form1.listSearchBttn.FlatAppearance.BorderColor = Color.Black;
            form1.addAll.FlatAppearance.BorderColor = Color.Black;
            form1.bttnClear.FlatAppearance.BorderColor = Color.Black;
            form1.bttnRemove.FlatAppearance.BorderColor = Color.Black;
            form1.searchName.BackColor = Color.Transparent;
            form1.searchLoc.BackColor = Color.Transparent;
            form1.searchID.BackColor = Color.Transparent;
            form1.listSearchBttn.BackColor = Color.Transparent;
            form1.addAll.BackColor = Color.Transparent;
            form1.bttnClear.BackColor = Color.Transparent;
            form1.bttnRemove.BackColor = Color.Transparent;
            form1.addSelectedBttn.BackColor = Color.Transparent;
            form1.addSelectedBttn.FlatAppearance.BorderColor = Color.Black;
        }
    }
}

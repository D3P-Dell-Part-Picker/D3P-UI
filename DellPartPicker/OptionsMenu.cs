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
        List<Button> buttonList;

        public Color color1 = Color.FromArgb(211, 205, 181);
        public Color color2 = Color.FromArgb(103, 123, 166);
        public Color color3 = Color.FromArgb(48, 67, 102);
        public Color color4 = Color.FromArgb(25, 26, 45);
        public Color color5 = Color.FromArgb(43, 35, 55);

        public OptionsMenu(Form1 f)
        {
            form1 = f;

            labels = new List<Label>();
            buttonList = new List<Button>();
            
            InitializeComponent();
            addLabels();
            addButtons();
            
            if (Form1.isDark)
            {
                isDark = true;
                radioDrk.Checked = true;
            }
            toggleDark(isDark);

        }

        //Put all labels here so theme colors work
        private void addLabels()
        {
            labels.Add(form1.enterHere);
            labels.Add(form1.dumpLbl);
            labels.Add(form1.Searchlbl);
            labels.Add(form1.results);
            labels.Add(form1.enterHere);
            labels.Add(form1.enterHere);
        }
        
        private void addButtons()
        {
            buttonList.Add(form1.defaultBtnID);
            buttonList.Add(form1.defaultBtnLoc);
            buttonList.Add(form1.defaultBtnName);
            buttonList.Add(form1.defaultAddSel);
            buttonList.Add(form1.listBtnSearch);
            buttonList.Add(form1.listBtnAddAll);
            buttonList.Add(form1.mapBtnClear);
            buttonList.Add(form1.mapBtnRmv);
            buttonList.Add(form1.mapBtnNxt);
            buttonList.Add(form1.mapBtnPrv);
            buttonList.Add(form1.mapBtnClear);

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
                makeColors(true);
            }
            if (radioLt.Checked == true)
            {
                makeColors(false);
            }
        }

        private void makeColors(bool isDark)
        {
            if (isDark)
            {
                radioDrk.Checked = true;

                // set dark colors
                color1 = Color.FromArgb(211, 205, 181);
                color2 = Color.FromArgb(103, 123, 166);
                color3 = Color.FromArgb(48, 67, 102);
                color4 = Color.FromArgb(25, 26, 45);
                color5 = Color.FromArgb(43, 35, 55);

                // apply colors
                foreach (Control subC in this.Controls)
                {
                    UpdateColorControls(subC, true, color1, color2, color3, color4, color5);
                }
                foreach (Control subC in form1.Controls)
                {
                    UpdateColorControls(subC, true, color1, color2, color3, color4, color5);
                }
            }

            if (!isDark)
            {
                radioDrk.Checked = false;
                // set light colors
                color1 = Color.FromArgb(247, 234, 219);
                color2 = Color.FromArgb(209, 200, 194);
                color3 = Color.FromArgb(203, 226, 206);
                color4 = Color.FromArgb(39, 86, 93);
                color5 = Color.FromArgb(83, 48, 66);

                // apply colors
                foreach (Control subC in this.Controls)
                {
                    UpdateColorControls(subC, false, color1, color2, color3, color4, color5);
                }
                foreach (Control subC in form1.Controls)
                {
                    UpdateColorControls(subC, false, color1, color2, color3, color4, color5);
                }
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

        public void UpdateColorControls(Control myControl, bool isDark, Color color1, Color color2, Color color3, Color color4, Color color5)
        {
            Form1.isDark = isDark;

            //Attempt at condensing code
            var optionb = from controls in this.Controls.OfType<Button>()
                          select controls;
            foreach (var control in optionb)
            {
                control.FlatAppearance.BorderColor = color4;
                control.BackColor = color4;
                control.ForeColor = color1;
            }

            //Changes color of the radio buttons in option menu
            var optionrb = from controls in this.Controls.OfType<RadioButton>()
                           select controls;
            foreach (var control in optionrb)
            {
                control.ForeColor = color1;
            }

            //Changes color of labels in option menu
            var optionlbl = from controls in this.Controls.OfType<Label>()
                            select controls;
            foreach (var control in optionlbl)
            {
                control.ForeColor = color1;
            }

            //Changes color of labels in form1
            foreach (Label l in labels)
            {
                l.ForeColor = color1;
            }


            //Changes background color
            this.BackColor = color4;
            form1.BackColor = color4;
            form1.listTab.BackColor = color4;
            form1.map.BackColor = color4;
            form1.singleItemTab.BackColor = color4;
            form1.error.BackColor = color1;
            form1.d3pTitle1.ForeColor = color1;
            form1.d3pTitle2.ForeColor = color1;

            if (isDark)
            {
                //Changes settings to Dark Ver.
                form1.pictureSettings1.Image = Properties.Resources.settingsicon_dark;
                form1.pictureSettings2.Image = Properties.Resources.settingsicon_dark;

                //Changes logo to Dark Ver.
                form1.d3pLogo1.Image = Properties.Resources.Dell_logo_2016_dark;
                form1.d3pLogo2.Image = Properties.Resources.Dell_logo_2016_dark;
            }
            else if (!isDark)
            {
                //Change logo to Light Ver.
                form1.d3pLogo1.Image = Properties.Resources.Dell_logo_2016;
                form1.d3pLogo2.Image = Properties.Resources.Dell_logo_2016;

                //Changes settings to Light Ver.
                form1.pictureSettings1.Image = Properties.Resources.settingsicon;
                form1.pictureSettings2.Image = Properties.Resources.settingsicon;
            }
            
            //Exceptions from the function (form background, title backcolor)

            //Change table colors
            form1.addSingletable.BackgroundColor = color5;
            form1.addSingletable.ForeColor = color2;
            form1.addSingletable.GridColor = color2;
            form1.addListTable.BackgroundColor = color5;
            form1.addListTable.ForeColor = color2;
            form1.addListTable.GridColor = color2;
            form1.dataGridList.BackgroundColor = color5;
            form1.dataGridList.ForeColor = color2;
            form1.dataGridList.GridColor = color2;

            form1.defaultBtnName.FlatAppearance.BorderColor = color2;
            form1.defaultBtnLoc.FlatAppearance.BorderColor = color2;
            form1.defaultBtnID.FlatAppearance.BorderColor = color2;
            form1.listBtnSearch.FlatAppearance.BorderColor = color2;
            form1.listBtnAddAll.FlatAppearance.BorderColor = color2;
            form1.mapBtnClear.FlatAppearance.BorderColor = color2;
            form1.mapBtnRmv.FlatAppearance.BorderColor = color2;
            form1.defaultBtnName.BackColor = color2;
            form1.defaultBtnLoc.BackColor = color2;
            form1.defaultBtnID.BackColor = color2;
            form1.listBtnSearch.BackColor = color2;
            form1.listBtnAddAll.BackColor = color2;
            form1.mapBtnClear.BackColor = color2;
            form1.mapBtnRmv.BackColor = color2;
            form1.defaultAddSel.BackColor = color2;
            form1.defaultAddSel.FlatAppearance.BorderColor = color2;
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
                control.ForeColor = color1;
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

            form1.defaultBtnName.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.defaultBtnLoc.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.defaultBtnID.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.listBtnSearch.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.listBtnAddAll.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.mapBtnClear.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.mapBtnRmv.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
            form1.defaultBtnName.BackColor = Color.FromArgb(115, 138, 214);
            form1.defaultBtnLoc.BackColor = Color.FromArgb(115, 138, 214);
            form1.defaultBtnID.BackColor = Color.FromArgb(115, 138, 214);
            form1.listBtnSearch.BackColor = Color.FromArgb(115, 138, 214);
            form1.listBtnAddAll.BackColor = Color.FromArgb(115, 138, 214);
            form1.mapBtnClear.BackColor = Color.FromArgb(115, 138, 214);
            form1.mapBtnRmv.BackColor = Color.FromArgb(115, 138, 214);
            form1.defaultAddSel.BackColor = Color.FromArgb(115, 138, 214);
            form1.defaultAddSel.FlatAppearance.BorderColor = Color.FromArgb(115, 138, 214);
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
            form1.defaultBtnName.FlatAppearance.BorderColor = Color.Black;
            form1.defaultBtnLoc.FlatAppearance.BorderColor = Color.Black;
            form1.defaultBtnID.FlatAppearance.BorderColor = Color.Black;
            form1.listBtnSearch.FlatAppearance.BorderColor = Color.Black;
            form1.listBtnAddAll.FlatAppearance.BorderColor = Color.Black;
            form1.mapBtnClear.FlatAppearance.BorderColor = Color.Black;
            form1.mapBtnRmv.FlatAppearance.BorderColor = Color.Black;
            form1.defaultBtnName.BackColor = Color.Transparent;
            form1.defaultBtnLoc.BackColor = Color.Transparent;
            form1.defaultBtnID.BackColor = Color.Transparent;
            form1.listBtnSearch.BackColor = Color.Transparent;
            form1.listBtnAddAll.BackColor = Color.Transparent;
            form1.mapBtnClear.BackColor = Color.Transparent;
            form1.mapBtnRmv.BackColor = Color.Transparent;
            form1.defaultAddSel.BackColor = Color.Transparent;
            form1.defaultAddSel.FlatAppearance.BorderColor = Color.Black;
        }
    }
}

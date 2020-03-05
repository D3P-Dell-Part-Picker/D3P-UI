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
            checkboxTheme.Appearance = System.Windows.Forms.Appearance.Button;

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
            //DARK THEME COLORS
            if (isDark)
            {
                radioDrk.Checked = true;
                // colors go from LIGHTEST to DARKEST
                color1 = Color.FromArgb(239, 240, 215);
                color2 = Color.FromArgb(93, 78, 80);
                color3 = Color.FromArgb(56, 49, 58);
                color4 = Color.FromArgb(19, 19, 17);
                // accent color
                color5 = Color.FromArgb(240, 215, 95);

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

            //LIGHT THEME COLORS
            if (!isDark)
            {
                radioDrk.Checked = false;
                // colors go from DARKEST to LIGHTEST
                color1 = Color.FromArgb(49, 48, 54);
                color2 = Color.FromArgb(128, 123, 125);
                color3 = Color.FromArgb(156, 153, 149);
                color4 = Color.FromArgb(242, 246, 242);
                // accent color
                color5 = Color.FromArgb(152, 147, 145);

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
                    makeColors(true);
                }
                foreach (Control subC in form1.Controls)
                {
                    makeColors(true);
                }
                
            }
            else
            {
                //If the user goes back into the options menu, the radio is still checked
                radioLt.Checked = true;

                foreach (Control subC in this.Controls)
                {
                    makeColors(false);
                }
                foreach (Control subC in form1.Controls)
                {
                    makeColors(false);
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
                control.FlatAppearance.BorderColor = color2;
                control.BackColor = color3;
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
                control.BackColor = Color.Transparent;
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
            form1.error.BackColor = color4;
            form1.d3pTitle1.ForeColor = color1;
            form1.d3pTitle2.ForeColor = color1;

            //Change logo color
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

            DataGridViewCellStyle tableColors = new DataGridViewCellStyle();
            tableColors.BackColor = color4;

            //Change table colors
            form1.addSingletable.BackgroundColor = color3;
            form1.addSingletable.ForeColor = Color.Black;
            form1.addSingletable.GridColor = color4;
            form1.addListTable.BackgroundColor = color3;
            form1.addListTable.ForeColor = Color.Black;
            form1.addListTable.GridColor = color2;
            form1.dataGridList.BackgroundColor = color3;
            form1.dataGridList.ForeColor = Color.Black;
            form1.dataGridList.GridColor = color2;

            // change header colors
            headerBar.BackColor = color3;
            headerBar2.BackColor = color4;
            optionsLbl.BackColor = headerBar.BackColor;
            form1.defaultHeader.BackColor = color5;
            form1.listdumpHeader.BackColor = color5;
            form1.d3pTitle1.BackColor = Color.Transparent;
            form1.d3pLogo1.BackColor = Color.Transparent;
            form1.pictureSettings1.BackColor = Color.Transparent;
            

            // change button colors
            // default tab
            form1.defaultBtnID.BackColor = color3;
            form1.defaultAddSel.BackColor = color3;
            form1.defaultBtnLoc.BackColor = color3;
            form1.defaultBtnName.BackColor = color3;
            form1.defaultBtnID.ForeColor = color1;
            form1.defaultAddSel.ForeColor = color1;
            form1.defaultBtnLoc.ForeColor = color1;
            form1.defaultBtnName.ForeColor = color1;
            form1.defaultBtnName.FlatAppearance.BorderColor = color3;
            form1.defaultBtnID.FlatAppearance.BorderColor = color3;
            form1.defaultBtnLoc.FlatAppearance.BorderColor = color3;
            form1.defaultAddSel.FlatAppearance.BorderColor = color5;
            // list-dump tab
            form1.listBtnAddAll.BackColor = color3;
            form1.listBtnSearch.BackColor = color3;
            form1.listBtnAddAll.ForeColor = color1;
            form1.listBtnSearch.ForeColor = color1;
            form1.listBtnAddAll.FlatAppearance.BorderColor = color3;
            form1.listBtnSearch.FlatAppearance.BorderColor = color3;
            /*
            form1.defaultBtnName.FlatAppearance.BorderColor = color5;
            form1.defaultBtnLoc.FlatAppearance.BorderColor = color5;
            form1.defaultBtnID.FlatAppearance.BorderColor = color5;
            form1.listBtnSearch.FlatAppearance.BorderColor = color5;
            form1.listBtnAddAll.FlatAppearance.BorderColor = color5;
            form1.mapBtnClear.FlatAppearance.BorderColor = color5;
            form1.mapBtnRmv.FlatAppearance.BorderColor = color2;
            form1.defaultBtnName.BackColor = color3;
            form1.defaultBtnLoc.BackColor = color3;
            form1.defaultBtnID.BackColor = color3;
            form1.listBtnSearch.BackColor = color3;
            form1.listBtnAddAll.BackColor = color3;
            form1.mapBtnClear.BackColor = color3;
            form1.mapBtnRmv.BackColor = color3;
            form1.defaultAddSel.BackColor = color3;
            form1.defaultAddSel.FlatAppearance.BorderColor = color5;
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string RSIP, PiIP, LSIP;
            // RSIP = Remote Server IP
            // PiIP = Raspberry Pi IP
            // LSIP = Local Server IP

            RSIP = remoteserverIP.Text;
            PiIP = piIP.Text;
            LSIP = localserverIP.Text;
        }

        private void labelPiIP_Click(object sender, EventArgs e)
        {

        }

        
    }
}

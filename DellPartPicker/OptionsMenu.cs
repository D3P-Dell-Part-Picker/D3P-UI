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
    public partial class OptionsMenu : Form
    {
        Form1 form1;
        Boolean isDark;
        List<Label> labels;
        List<Button> buttonList;

        public Color buttoncolor2, buttoncolor1, buttoncolor3, textcolor, color1, color2, accentcolor;

        public OptionsMenu(Form1 f)
        {

            /*Form = new Main();
            Form.*/
            form1 = f;

            labels = new List<Label>();
            buttonList = new List<Button>();
            
            InitializeComponent();
            buttonLightThm.Enabled = false;
            makeColors(false);

            remoteserverIP.Text = Constants.REMOTE_SERVER;
            piIP.Text = Constants.PIMESH;
            localserverIP.Text = Constants.LOCAL_SERVER;

            if (Form1.isDark)
            {
                isDark = true;
            }
            toggleDark(isDark);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            form1.Show();
        }

        public void makeColors(bool isDark)
        {
            if (isDark)
            {
                // Lightest to darkest color
                buttoncolor1 = Color.FromArgb(60, 60, 60); //Normal button color
                buttoncolor2 = Color.FromArgb(87, 87, 87); //Lighter button color
                buttoncolor3 = Color.FromArgb(40, 40, 40); //Disabled button
                color1 = Color.FromArgb(60, 60, 60); //Lighter color
                color2 = Color.FromArgb(21, 21, 21); //Darker color
                accentcolor = Color.FromArgb(108, 230, 255); //Accent color
                textcolor = Color.White;

                buttonDrkThm.Enabled = false;
                buttonLightThm.Enabled = true;
                buttonLightThm.BackColor = buttoncolor1;
                buttonLightThm.ForeColor = textcolor;
                buttonLightThm.FlatAppearance.BorderColor = buttoncolor1;
                buttonDrkThm.BackColor = buttoncolor3;
                buttonDrkThm.ForeColor = textcolor;
                buttonDrkThm.FlatAppearance.BorderColor = buttoncolor3;

                //Apply colors
                foreach (Control subC in this.Controls)
                {
                    UpdateColorControls(subC, true, color1, color2, accentcolor, textcolor, buttoncolor1, buttoncolor2, buttoncolor3);
                }
                foreach (Control subC in form1.Controls)
                {
                    UpdateColorControls(subC, true, color1, color2, accentcolor, textcolor, buttoncolor1, buttoncolor2, buttoncolor3);
                }
            }

            //LIGHT THEME COLORS
            if (!isDark)
            {
                //Darkest to lightest color
                buttoncolor1 = Color.FromArgb(202, 202, 202); //Normal button color
                buttoncolor2 = Color.FromArgb(172, 172, 172); //Lighter button color
                buttoncolor3 = Color.FromArgb(164, 164, 164); //Disabled button
                color1 = Color.FromArgb(202, 202, 202); //Darker color
                color2 = Color.FromArgb(255, 255, 255); //Lighter color
                accentcolor = Color.FromArgb(253, 156, 91); //Accent color
                textcolor = Color.FromArgb(0, 0, 0);

                buttonLightThm.Enabled = false;
                buttonDrkThm.Enabled = true;
                buttonLightThm.BackColor = buttoncolor3;
                buttonLightThm.ForeColor = textcolor;
                buttonLightThm.FlatAppearance.BorderColor = buttoncolor3;
                buttonDrkThm.BackColor = buttoncolor1;
                buttonDrkThm.ForeColor = textcolor;
                buttonDrkThm.FlatAppearance.BorderColor = buttoncolor1;
<<<<<<< HEAD
                
=======

>>>>>>> master

                //Apply
                foreach (Control subC in this.Controls)
                {
                    UpdateColorControls(subC, false, color1, color2, accentcolor, textcolor, buttoncolor1, buttoncolor2, buttoncolor3);
                }
                foreach (Control subC in form1.Controls)
                {
                    UpdateColorControls(subC, false, color1, color2, accentcolor, textcolor, buttoncolor1, buttoncolor2, buttoncolor3);
                }
            }

        }

        private void toggleDark(Boolean b)
        {
            if (b)
            {
                //If the user goes back into the options menu, the buttons are disabled/enabled accordingly
                buttonDrkThm.Enabled = true;
                buttonLightThm.Enabled = false;

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
                //If the user goes back into the options menu, the buttons are disabled/enabled accordingly
                buttonLightThm.Enabled = true;
                buttonDrkThm.Enabled = false;

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

        private void buttonLightThm_Click(object sender, EventArgs e)
        {
            makeColors(false);
        }

        private void buttonDrkThm_Click(object sender, EventArgs e)
        {
            
            makeColors(true);
        }

        public void UpdateColorControls(Control myControl, bool isDark, Color color1, Color color2, Color accentcolor, Color textcolor, Color buttoncolor1, Color buttoncolor2, Color buttoncolor3)
        {
            Form1.isDark = isDark;

            //Changes background color
            this.BackColor = color2;
            form1.BackColor = color2;
            form1.listTab.BackColor = color2;
            form1.map.BackColor = color2;
            form1.singleItemTab.BackColor = color2;
            form1.error.BackColor = color1;
<<<<<<< HEAD
            
=======

>>>>>>> master

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
            tableColors.BackColor = color2;

            //Change table colors
            form1.addSingletable.BackgroundColor = color1;
            form1.addSingletable.ForeColor = Color.Black;
            form1.addSingletable.GridColor = color1;
            form1.addListTable.BackgroundColor = color1;
            form1.addListTable.ForeColor = Color.Black;
            form1.addListTable.GridColor = color2;
            form1.dataGridList.BackgroundColor = color1;
            form1.dataGridList.ForeColor = Color.Black;
            form1.dataGridList.GridColor = color2;

            // change header/footer colors
            footerBar.BackColor = color1;
            headerBar.BackColor = color1;
            headerBar2.BackColor = color1;
            optionsLbl.BackColor = headerBar.BackColor;
            optionsLbl.ForeColor = Color.White;
            form1.defaultHeader.BackColor = accentcolor;
            form1.listdumpHeader.BackColor = accentcolor;
            form1.d3pTitle1.BackColor = Color.Transparent;
            form1.d3pLogo1.BackColor = Color.Transparent;
            form1.d3pTitle1.ForeColor = accentcolor;
            form1.d3pTitle2.ForeColor = accentcolor;
            form1.d3pLogo1.ForeColor = accentcolor;
            form1.d3pLogo2.ForeColor = accentcolor;
            form1.pictureSettings1.BackColor = Color.Transparent;

            // change label colors (options tab)
            labelPiIP.ForeColor = textcolor;
            labelLSIP.ForeColor = textcolor;
            labelRSIP.ForeColor = textcolor;
            piIP.ForeColor = textcolor;
            remoteserverIP.ForeColor = textcolor;
            localserverIP.ForeColor = textcolor;
            piIP.BackColor = color2;
            remoteserverIP.BackColor = color2;
            localserverIP.BackColor = color2;

            // change button colors (options tab)
            buttonBack.ForeColor = textcolor;
            buttonBack.BackColor = buttoncolor1;
            buttonBack.FlatAppearance.BorderColor = buttoncolor1;
            button1.ForeColor = textcolor;
            button1.BackColor = buttoncolor1;
            button1.FlatAppearance.BorderColor = buttoncolor1;

            // change label colors (default tab)
            form1.Searchlbl.ForeColor = textcolor;
            form1.dumpLbl.ForeColor = textcolor;
            form1.results.ForeColor = textcolor;
            form1.searchBox.ForeColor = textcolor;
            form1.searchBox.BackColor = color2;
            form1.maplistTitle.ForeColor = textcolor;
            form1.mapTitle.ForeColor = textcolor;
            form1.enterHere.ForeColor = textcolor;
            form1.listTextBox.BackColor = color2;
            form1.listTextBox.ForeColor = textcolor;

            //Change button colors (default tab)
            form1.defaultBtnID.BackColor = buttoncolor1;
            form1.defaultAddSel.BackColor = buttoncolor1;
            form1.defaultBtnLoc.BackColor = buttoncolor1;
            form1.defaultBtnName.BackColor = buttoncolor1;
            form1.defaultBtnID.ForeColor = textcolor;
            form1.defaultAddSel.ForeColor = textcolor;
            form1.defaultBtnLoc.ForeColor = textcolor;
            form1.defaultBtnName.ForeColor = textcolor;
            form1.defaultBtnName.FlatAppearance.BorderColor = buttoncolor1;
            form1.defaultBtnID.FlatAppearance.BorderColor = buttoncolor1;
            form1.defaultBtnLoc.FlatAppearance.BorderColor = buttoncolor1;
            form1.defaultAddSel.FlatAppearance.BorderColor = buttoncolor1;
            form1.mapBtnClear.BackColor = buttoncolor1;
            form1.mapBtnClear.ForeColor = textcolor;
            form1.mapBtnClear.FlatAppearance.BorderColor = buttoncolor1;
            form1.mapBtnNxt.BackColor = buttoncolor1;
            form1.mapBtnNxt.ForeColor = textcolor;
            form1.mapBtnNxt.FlatAppearance.BorderColor = buttoncolor1;
            form1.mapBtnPrv.BackColor = buttoncolor1;
            form1.mapBtnPrv.ForeColor = textcolor;
            form1.mapBtnPrv.FlatAppearance.BorderColor = buttoncolor1;
            form1.mapBtnRmv.BackColor = buttoncolor1;
            form1.mapBtnRmv.ForeColor = textcolor;
            form1.mapBtnRmv.FlatAppearance.BorderColor = buttoncolor1;
            form1.mapFndSlt.BackColor = buttoncolor1;
            form1.mapFndSlt.ForeColor = textcolor;
            form1.mapFndSlt.FlatAppearance.BorderColor = buttoncolor1;

            // change map colors
            form1.mapBackground.BackColor = color1;

            //List-dump tab
            form1.listBtnAddAll.BackColor = buttoncolor1;
            form1.listBtnSearch.BackColor = buttoncolor1;
            form1.listBtnAddAll.ForeColor = textcolor;
            form1.listBtnSearch.ForeColor = textcolor;
            form1.listBtnAddAll.FlatAppearance.BorderColor = buttoncolor1;
            form1.listBtnSearch.FlatAppearance.BorderColor = buttoncolor1;
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

            Constants.REMOTE_SERVER = RSIP;
            Constants.PIMESH = PiIP;
            Constants.LOCAL_SERVER = LSIP;
            Constants.renewConf();
            Json.writeJson(Constants.config);
        }
    }
}

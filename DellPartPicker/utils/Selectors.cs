﻿using DellPartPicker.constants;
using DellPartPicker.messages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DellPartPicker.utils
{
    public class Selectors
    {

        private static Color color2 = Color.White;
        public static int last_line = 0;

        public static bool select(Form1 form1)
        {
            TestingUtils.clearAll(form1);
            if (Form1.selectedRow >= (form1.dataGridList.Rows.Count)) //if the selected row is out of bounds
            {
                //reset the selected row to 0
                Form1.selectedRow = 0;

                //set the error message
                form1.maperrorLabel.Text = "can't select any further";
                form1.maperrorLabel.Visible = true;

                //return false, there is no more previous items
                return false;
            }
            try
            {
                //try to get the location
                String loc = form1.dataGridList.Rows[Form1.selectedRow].Cells[2].Value.ToString();
                if (loc == "not found") //if the location does not exist
                {
                    //set the error accordingly
                    form1.maperrorLabel.Text = "This item does not exist.";
                    form1.maperrorLabel.Visible = true;

                    //return false, as it didn't work out
                    return false;
                }
                

                //get the picturebox that corresponds to that enum and set its color to white
                TestingUtils.getShelf(loc).BackColor = color2;

                //go through all of the rows and deselect them
                foreach (DataGridViewRow r in form1.dataGridList.Rows)
                {
                    r.Selected = false;
                }

                //select the current row
                form1.dataGridList.Rows[Form1.selectedRow].Selected = true;

                //any error now disappears
                form1.maperrorLabel.Visible = false;

                //get the linumber for whatever the selected item is
                int linenum = Loader.getLineNumber(
                    form1.dataGridList.Rows[Form1.selectedRow].Cells[0].Value.ToString(),
                    form1.dataGridList.Rows[Form1.selectedRow].Cells[1].Value.ToString()) - 1;

                form1.maperrorLabel.Text = "Your Token Is: " + linenum;

                if (last_line != 0) //make sure that it is not in the startup config
                {
                    //dispose the previous line
                    MessageSimplifier.sendMessage(last_line, Constants.PIMESH, CommandType.DISPOSE);
                }

                //set lastline to currentline
                last_line = linenum;



                MessageSimplifier.sendMessage(linenum, Constants.PIMESH, CommandType.FIND);

                // TODO
                // do something with the line number

                return true;
            }
            catch
            {
                //assume that there is nothing in the table and set the error accordingly
                form1.maperrorLabel.Visible = true;
                form1.maperrorLabel.Text = "nothing is in that table";

                //return false because something failed
                return false;
            }
        }

        //this is the picture finder method for selected files
        public static bool select(DataGridViewSelectedRowCollection sel, Form1 form1)
        {

            try
            {
                //try to get the location
                String loc = sel[0].Cells[2].Value.ToString();
                if (loc == "not found")
                {
                    //not found then set the error to correspond
                    form1.maperrorLabel.Text = "This item does not exist.";
                    form1.maperrorLabel.Visible = true;

                    //return false because it failed
                    return false;
                }
                

                //enum -> picturebox; picturebox.color = white
                //enum to picturebox then change the color to white
                TestingUtils.getShelf(loc).BackColor = color2;

                //any error disappears
                form1.maperrorLabel.Visible = false;

                //get the line number of that selected item
                int linenum = Loader.getLineNumber(
                    sel[0].Cells[0].Value.ToString(),
                    sel[0].Cells[1].Value.ToString()) - 1;

                form1.maperrorLabel.Text = "Your Token Is: " + linenum;
                form1.maperrorLabel.Visible = true;

                if (last_line != 0) //make sure that it is not in the startup config
                {
                    //dispose the previous line
                    MessageSimplifier.sendMessage(last_line, Constants.PIMESH, CommandType.DISPOSE);
                    form1.Focus();
                }

                //set lastline to currentline
                last_line = linenum;

                MessageSimplifier.sendMessage(linenum, Constants.PIMESH, CommandType.FIND);
                form1.Focus();

                return true;
            }
            catch
            {
                //assume that there is nothing in the table and set the error accordingly
                form1.maperrorLabel.Visible = true;
                form1.maperrorLabel.Text = "nothing is selected";

                //return false because it failed
                return false;
            }
        }
    }
}

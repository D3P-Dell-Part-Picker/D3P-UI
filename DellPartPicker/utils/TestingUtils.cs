using DellPartPicker.constants;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DellPartPicker.utils
{
    public class TestingUtils
    {
        private static Color color1 = Color.Gray;

        public static Dictionary<String, PictureBox> map;

        //initiation class
        public TestingUtils(Form1 form)
        {
            createDict(form);

        }
        
        //create the hashmap
        private static void createDict(Form1 form)
        {

            Console.WriteLine("initializing Dictionary");
            map = new Dictionary<String, PictureBox>();

            map.Add("A", form.shelfA);
            map.Add("B", form.shelfB);
            map.Add("C", form.shelfC);
            map.Add("D", form.shelfD);
            map.Add("E", form.shelfE);
            map.Add("F", form.shelfF);
            map.Add("G", form.shelfG);
            map.Add("H", form.shelfH);
            map.Add("I", form.shelfI);
            map.Add("J", form.shelfJ);
            map.Add("K", form.shelfK);
            map.Add("L", form.shelfL);
            map.Add("M", form.shelfM);
            map.Add("N", form.shelfN);
            map.Add("O", form.shelfO);
            map.Add("P", form.shelfP);
            map.Add("Q", form.shelfQ);
            map.Add("R", form.shelfR);
            map.Add("S", form.shelfS);
            map.Add("T", form.shelfT);
            map.Add("U", form.shelfU);
            map.Add("V", form.shelfV);
            map.Add("W", form.shelfW);
            map.Add("X", form.shelfX);
            map.Add("GL Cube", form.shelfGL);
            map.Add("Front", form.shelfFront);


        }
        //this resets the color of all the picture boxes
        public static void clearAll(Form1 form)
        {
            //reset colors
            foreach(PictureBox p in map.Values){
                p.BackColor = color1;
            }
        }

        //picture box getting function
        

        //get the enum
        public static PictureBox getShelf(String loc)
        {
            //get the location letter
            char locLetter = loc.ToCharArray()[0];
            char locLetter2 = loc.ToCharArray()[1];
            String searchTerm = locLetter.ToString();
            if (Char.IsLetter(locLetter2))
            {
                searchTerm = loc;
            }
            Console.WriteLine("Search Term: " + searchTerm);
            return map[searchTerm];

        }
    }
    
}

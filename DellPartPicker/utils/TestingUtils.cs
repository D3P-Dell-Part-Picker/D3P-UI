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

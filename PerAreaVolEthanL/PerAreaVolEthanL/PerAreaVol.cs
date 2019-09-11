/*
 * Created by: Ethan L
 * Created on: September 10. 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Perimeter, Area, Volume
 * This program calculates the perimeter of a rectangle, the area of a circle, and the volume of a sphere.
 * It displays the answers in labels when the respective button is clicked.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVolEthanL
{
    static class PerAreaVol
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPerAreaVol());
        }
    }
}

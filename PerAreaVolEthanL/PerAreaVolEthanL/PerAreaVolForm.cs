/*
 * Created by: Ethan L
 * Created on: September 10, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - PerAreaVol
 * This program calculates the area of a circle, the perimeter of a rectangle, and the volume of a sphere
*/using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVolEthanL
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        private void BtnQVolume_Click(object sender, EventArgs e)
        {
            lblAVolume.Text = Convert.ToString((double)4 / (double)3 * (Math.PI) * (Math.Pow(4, 3))) + " cm³";
        }

        private void BtnQPerimeter_Click(object sender, EventArgs e)
        {
            lblAPerimeter.Text = Convert.ToString(8 + 8 + 5 + 5) + " cm";
        }

        private void BtnQArea_Click(object sender, EventArgs e)
        {
            lblAArea.Text = Convert.ToString(Math.PI * Math.Pow(7, 2)) + " cm²";
        }

        private void LblAPerimeter_Click(object sender, EventArgs e)
        {

        }

        private void LblAArea_Click(object sender, EventArgs e)
        {

        }

        private void LblAVolume_Click(object sender, EventArgs e)
        {

        }
    }
}

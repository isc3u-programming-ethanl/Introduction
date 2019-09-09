/*
 * Created by: Ethan LeGault
 * Created on: Sep. 6, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - Hello World with Menu
 * This program displays my favourite artist of all time.
 * It also has an exit menu
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramMenuFormEthanL
{
    public partial class frmProgramMenu : Form
    {
        public frmProgramMenu()
        {
            InitializeComponent();
        }

        private void ProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            //This when pressed makes the program shut down
            this.Close();
        }
    }
}

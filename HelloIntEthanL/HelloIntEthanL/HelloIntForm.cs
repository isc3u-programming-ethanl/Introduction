using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloIntEthanL
{
    public partial class frmHelloInt : Form
    {
        public frmHelloInt()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GrbGreetings_Enter(object sender, EventArgs e)
        {

        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to English
            this.lblGreeting.Text = "Hello, World!";
        }

        private void RadGerman_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to German
            this.lblGreeting.Text = "Hallo, Welt!";
        }

        private void RadSwedish_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to Swedish
            this.lblGreeting.Text = "Hej världen";
        }

        private void RadFrench_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to French
            this.lblGreeting.Text = "Bonjour, le Monde!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundoWF
{
    public partial class HolaMundoWF : Form
    {
        public HolaMundoWF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            msg.Text = "Hola Mundo!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            msgMX.Text = "Hola México!";
        }
    }
}

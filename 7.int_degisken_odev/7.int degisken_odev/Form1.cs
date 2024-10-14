using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.int_degisken_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int uzunkenar, kısakenar, alan, cevre;

            uzunkenar = 20;
            kısakenar = 10;
            cevre = uzunkenar + kısakenar;
            alan = kısakenar * uzunkenar;
            label1.Text = "Cevre: " + cevre + "\nAlan: " + alan;
        }
    }
}

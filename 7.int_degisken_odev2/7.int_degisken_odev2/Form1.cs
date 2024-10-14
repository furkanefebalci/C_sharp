using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.int_degisken_odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int sınav1, sınav2, sınav3, ortalama;

            sınav1 = 50;
            sınav2 = 90;
            sınav3 = 70;

            ortalama = sınav1 + sınav2 + sınav3;

            label1.Text = "Okul Ortalamanız; " + ortalama/3 ;    
        }
    }
}

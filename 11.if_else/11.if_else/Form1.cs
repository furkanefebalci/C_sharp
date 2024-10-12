using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.if_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);
            if ( sayi % 2 == 0 && sayi > 10)
            {
                label1.Text = "Sayiniz 10'dan buyuk ve cift sayi";
            }
            else if (sayi % 2 == 0 && sayi < 10)
            {
                label1.Text = "Sayiniz cift ama 10'dan buyuk deil";
            }
            else if ( sayi % 2 != 0 && sayi > 10)
            {
                label1.Text = "Sayiniz cift degil";
            }
            else
            {
                label1.Text = "Sayiniz cift degil ve 10'dan kucuk ";
            } 
                
        }  
    }
}

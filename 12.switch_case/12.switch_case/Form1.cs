using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12.switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mevsim = textBox1.Text;
            switch (mevsim) {

                case "Summer":label2.Text = "June july \n August";
                    break;
                case "Spring": label2.Text = "March April \n May";
                        break;
                case "Autumn": label2.Text = "September October \n November";
                        break;
                case "Winter": label2.Text = "December January \n February";
                    break;
                default: label2.Text = "İncorrect Entry"; break;
            }
        }
    }
}
/*int ay = Convert.ToUInt16(textBox1.Text);
            switch(ay)
            {
                case 1: label2.Text = "Ocak"; break;
                case 2: label2.Text = "Şubat"; break;
                case 3: label2.Text = "Mart"; break;
                case 4: label2.Text = "Nisan"; break;
                case 5: label2.Text = "Mayıs"; break;
                case 6: label2.Text = "Haziran"; break;
                case 7: label2.Text = "Temmuz";break;
                case 8: label2.Text = "Ağustos"; break;
                case 9: label2.Text = "Eylül"; break;
                case 10: label2.Text = "Ekim"; break;
                case 11: label2.Text = "Kasım"; break;
                case 12: label2.Text = "Aralık"; break;
                default :  label2.Text = "Hatalı Ay:"; break;
            }
            */
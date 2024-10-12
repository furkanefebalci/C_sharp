using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.int_degisken_part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi = Convert.ToInt16(textBox1.Text);
            sonuc = sayi * sayi * sayi;

            label2.Text = sonuc.ToString();













            /*int sayi;
            sayi = Convert.ToInt16(textBox1.Text);
            label2.Text = sayi.ToString();

         string int oldu sonra string değişkenli bir araca yazdırmak için ise tekrardan inti stringe yazdırdım 
          Bir şey anlamadım bunu abime sor.

         */
        }
    } 
}

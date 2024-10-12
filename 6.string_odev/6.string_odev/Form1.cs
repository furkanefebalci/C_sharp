using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.string_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim, soyisim, meslek, yas, cinsiyet;
            isim =  "İsminiz: " +textBox1.Text;
            soyisim = "Soyisminiz: " +textBox2.Text;
            meslek = "Mesleğiniz: " +textBox3.Text;
            yas = "Yaşınız:" + maskedTextBox1.Text;
            cinsiyet = "Cinsiyetiniz:" +textBox4.Text;

            listBox1.Items.Add(isim);
            listBox1.Items.Add(soyisim);
            listBox1.Items.Add(meslek);
            listBox1.Items.Add(yas);
            listBox1.Items.Add(cinsiyet);

            /*
             Bu programda isim değişkeni tanıdım ve sonrasında textbox1 e girilen ve aynı şekilde devam eden 
            textbox2 olsun  hepsi için bir değişken tanıdım bu programdaki amacım 
            textboxtaki yazıları listboxa yazdırmak.
             */



        }
    }
}

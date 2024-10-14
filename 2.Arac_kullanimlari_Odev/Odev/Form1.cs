using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Adınız: " + textBox1.Text);
            listBox1.Items.Add("Soy Adınız: " + textBox2.Text);
            listBox1.Items.Add("Mesleğiniz: " + textBox3.Text);
            listBox1.Items.Add("Maaşınız: " + textBox4.Text);
            listBox1.Items.Add("Yaşadığınız şehir: " + textBox5.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
         

        }
    }
}

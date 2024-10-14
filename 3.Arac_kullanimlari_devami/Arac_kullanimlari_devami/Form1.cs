using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_kullanimlari_devami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Telefon No:" + maskedTextBox1.Text);
            listBox1.Items.Add("TC NO: " + maskedTextBox2.Text);
            listBox1.Items.Add("Tarih: " + maskedTextBox3.Text);
            listBox1.Items.Add("Saat : " + maskedTextBox4.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Text);
        }
    }
}

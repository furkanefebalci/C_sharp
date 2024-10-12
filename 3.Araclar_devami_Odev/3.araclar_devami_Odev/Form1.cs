using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.araclar_devami_Odev
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox2.Text);
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(maskedTextBox1.Text);
            listBox1.Items.Add(dateTimePicker1.Text);
            listBox1.Items.Add(comboBox1.Text);
        }
    }
}

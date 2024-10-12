using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucus_rezervasyon_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text);
          listBox1.Items.Add("Tarih:" + dateTimePicker1.Text);
          listBox1.Items.Add("Saat:" + maskedTextBox1.Text);
          listBox1.Items.Add("Yolcu Bilgileri ~ Ad:" +textBox1.Text);
          listBox1.Items.Add("TC:" + maskedTextBox3.Text);
          listBox1.Items.Add("Telefon:" + maskedTextBox2.Text);
    
          MessageBox.Show("Yolcu Kaydı Yapıldı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;

        }
    }
}

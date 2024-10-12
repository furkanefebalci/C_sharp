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
            listBox1.Items.Add(textBox1.Text+ " " + textBox2.Text+ " " +textBox3.Text+ " " +textBox4.Text+ " " +textBox5.Text);
            /*
             Bu kod önce textboxtaki yazıyı alıyor sonra aynı işlemi 
            2.ci texbox için yapıyor vb. yan yana yazdırıyor 
             + " " + bu işaret araya bir boşluk atıyor.
            */

        }

        private void button2_Click(object sender, EventArgs e)
        {
         

        }
    }
}

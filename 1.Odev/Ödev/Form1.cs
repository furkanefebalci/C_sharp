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

namespace Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = textBox2.Text;
            label3.Text = textBox3.Text;
            /*Bu çalışmamda text boxtakı yazıları labele aktardım 
             button sayesinde
             Çalışma mantığı:
             İlk başta text labelli text boxlara atadım sonrasında 
             text boxlara bir şey yazdığımda labele ataması için buttonu çalıştırdım.
             */
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
}
    }
}

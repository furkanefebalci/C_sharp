using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13.degiskenler_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
           btnA.Enabled = false;
           btnB.Enabled = false;
           btnC.Enabled = false;
           btnD.Enabled = false;
           btnSonraki.Enabled = true;

            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text= yanlis.ToString();
                pictureBox2.Visible = true;


            }


        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;


            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;


            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;




            label5.Text = btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else 
             {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

             }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;    
            btnD.Enabled = true;
            btnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;



            soruno++;
            lblSoruNo.Text = soruno.ToString();
            
            if(soruno == 1 )
            {
                richTextBox1.Text = "God of War'daki Güzellik tanrıçası ünvanı ile tanınan karakter kimdir?";
                btnA.Text = "Pandora";
                btnB.Text = "Freya";
                btnC.Text = "Aphrodite";
                btnD.Text = "Faye";
                label4.Text = "Freya";
            
            }
            if  (soruno == 2 )
            {
                richTextBox1.Text = "Sekiro™: Shadows Die Twice Oyunundaki ana karakterin kullandığı kılıcın veya bıçağın ismi nedir ? ";
                btnA.Text = "Blades of Chaos";
                btnB.Text = "Mjölnir";
                btnC.Text = "The Kisabimaru";
                btnD.Text = "Leviathan";
                label4.Text = "The Kisabimaru";


            }
            if (soruno == 3 )
            {
                richTextBox1.Text = "CSGO'da en değerli M4A1-S deseni nedir ?";
                btnA.Text = "Welcome to the Jungle";
                btnB.Text = "Dragon Lore";
                btnC.Text = "Fade";
                btnD.Text = "Medusa";
                label4.Text ="Welcome to the Jungle";
                btnSonraki.Text = "Sonuçlar";
            }
            if (soruno == 4) 
            { 
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);

            
            }

         

        }
    }
}

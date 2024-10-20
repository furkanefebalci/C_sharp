using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10.degiskenler_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            int misir, cay, bilet, su, toplam, biskuvi;

            biskuvi = Convert.ToInt16(txtbiskuvi.Text);
            misir = Convert.ToInt16(txtMisir.Text);
            bilet = Convert.ToInt16(txtBilet.Text);
            su = Convert.ToInt16(txtSu.Text);
            cay = Convert.ToInt16(txtCay.Text);
            //tam sayi girmek için int'e çevirdik

            toplam = misir * 20 + cay * 8 + su * 5 + bilet * 30 + biskuvi * 14;

            lblToplam.Text = toplam.ToString() + " TL";
            kasatutar = kasatutar + toplam;
            lblKasa.Text = kasatutar.ToString() + " TL";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCay.Text = " ";
            txtSu.Text = " ";
            txtBilet.Text = " ";
            txtbiskuvi.Text = " ";
            txtMisir.Text = " ";
            txtMisir.Focus();
            //Bu kod temizle butonuna bastıktan sonra imlecin mısıra gelmesine ve hesabı temizlemesine yarar.
        }
    }
}

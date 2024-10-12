﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11.if_else_alistirma_2
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
            //0-20 ==> %20 
            //21-40 ==> % 40
            // 41++ ==> %50
            /*
              toplam =(kitapadet* 8 ) - (kitapadet* 8 * 0.20); 
            bu satılan kitabı 8 ile çarpıp yani fiyatı ile 
            sonrasında o fiyatın %20 sini çıkartmamıza yarar !!
             */
           
            

            int kitapadet;
            double toplam;
            //kitap 8TL

            kitapadet = Convert.ToInt16(textBox1.Text);
            if (kitapadet >= 0 && kitapadet <= 20) 
            {
                toplam =(kitapadet* 8 ) - (kitapadet* 8 * 0.20);
                //%20 formülü
                label3.Text = toplam + " TL";
            }
            if (kitapadet >= 21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.40);
                label3.Text = toplam + " TL";
            }
            if (kitapadet >= 41)
            {
                toplam = (kitapadet * 8) - (kitapadet * 8 * 0.50);
                label3.Text = toplam + " TL";
            }

            
        }
    }
}
//0-20 ==> %20 
//21-40 ==> % 40
// 41++ ==> %50
//kitap 8 o yüzden 8 ile çarpıcam

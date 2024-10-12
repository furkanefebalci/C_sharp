using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.ınt_degiskeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kare alan ve çevre hesabı

            int kenar, alan, cevre;
            kenar = 10;
            alan = kenar * kenar;
            cevre = kenar * 4;

            label1.Text = "Alan: " + alan + "\nÇevre: " +cevre;

            /*
             label bir string değişkini yazarı normalde int bir değer yazdığımda ekstra olarak .ToString();
            kullanırım ki o ifade dönüşsün yoksa hata olur, ama ben 
            o label satırında bir tane string ifade kullanırsam mesela "Alan" gibi o zaman int değerine 
            To String yapmama gerek kalmaz örneklere bak!!
             */

           /* Sayı toplamak icin;
            
            int sayi1, sayi2, toplam;

            sayi1 = 5;
            sayi2 = 4;

            toplam = sayi1 + sayi2;

            label1.Text = toplam.ToString();
           */
        }
    }
}

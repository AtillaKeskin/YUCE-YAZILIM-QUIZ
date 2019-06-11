using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınavOrtalaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt3.ReadOnly = true;
           
        }
        double sayi1, sayi2, sayi3, puan1, puan2;
        private void button1_Click(object sender, EventArgs e)
        {
      
           
            sayi1 = Convert.ToDouble(txt1.Text);
            sayi2 = Convert.ToDouble(txt2.Text);
            
            puan1 = (sayi1 + sayi2) / 2;
            if (puan1 >= 0 && puan1 <= 50)
            {
                lblOrt.Text = puan1.ToString();
                lblDurum.Text = "Ortalamanız 50 altında dır.3.Sınav Notunuzuda Giriniz";
                txt3.ReadOnly = false;
               
            }
            else
            {
                lblOrt.Text = puan1.ToString();
                lblDurum.Text = "Geçtiniz.";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi3 = Convert.ToDouble(txt3.Text);
            puan2 = (sayi1 + sayi2 + sayi3) / 3;
            if (puan2 > 50)
            {
                lblDurum.Text = "Geçtiniz";
                lblOrt.Text = puan2.ToString();

            }
            else
            {
                lblOrt.Text = puan2.ToString();
                lblDurum.Text = "Ortalamanız 50 altında oldugundan Kaldınız";
            }
        }
    }
}

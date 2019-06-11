using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Test4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //string terskelime="";
            //foreach (char harf in kelime)
            //{
            //    terskelime = harf.ToString() + terskelime;
            //}
            //lblTersKelime.Text = terskelime;
            StringBuilder kelime = new StringBuilder(textBox1.Text);
            int harfSayısı = textBox1.Text.Length;
            for (int i = 0; i <harfSayısı/2;  i++)
            {
                char bastan = kelime[i];
                char sondan = kelime[harfSayısı - 1 - i];
                kelime[i] = sondan;
                kelime[harfSayısı - 1 - i] = bastan;

            }

            lblTersKelime.Text = Convert.ToString(kelime);

        }
    }
}

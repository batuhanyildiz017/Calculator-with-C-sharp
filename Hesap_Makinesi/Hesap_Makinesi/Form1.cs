using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool toplama = false;
        bool cıkarma = false;
        bool carpma = false;
        bool bolme = false;
        private void button11_Click(object sender, EventArgs e)
        { //toplama
            toplama = true;
            textBox2.Text = "+";
            textBox3.Text = textBox1.Text;
            textBox1.Text =  null;
        }

        private void button12_Click(object sender, EventArgs e)
        { //çıkarma
            cıkarma = true;
            textBox2.Text = "-";
            textBox3.Text = textBox1.Text;
            textBox1.Text = null;
        }

        private void button13_Click(object sender, EventArgs e)
        { //çarpma
            carpma = true;
            textBox2.Text = "*";
            textBox3.Text = textBox1.Text;
            textBox1.Text = null;
        }

        private void button14_Click(object sender, EventArgs e)
        { //bölme
            bolme = true;
            textBox2.Text = "/";
            textBox3.Text = textBox1.Text;
            textBox1.Text = null;
        }

        private void button10_Click(object sender, EventArgs e)
        { //rakamlar butonu
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {//eşittir
            if (toplama == true)
                textBox4.Text = Convert.ToString((Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox1.Text)));
            else if(bolme == true)
                textBox4.Text = Convert.ToString((Convert.ToInt32(textBox3.Text) / Convert.ToInt32(textBox1.Text)));
            else if(carpma == true)
                textBox4.Text = Convert.ToString((Convert.ToInt32(textBox3.Text) * Convert.ToInt32(textBox1.Text)));
            else if(cıkarma == true)
                textBox4.Text = Convert.ToString((Convert.ToInt32(textBox3.Text) - Convert.ToInt32(textBox1.Text)));
            toplama = false;
            cıkarma= false;
            carpma= false;
            bolme = false;
        }

        private void button16_Click(object sender, EventArgs e)
        { // sıfırlama
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            toplama = false;
            cıkarma = false;
            carpma = false;
            bolme = false;
        }

        private void button17_Click(object sender, EventArgs e)
        { //+ - butonu
            
            if (textBox1.Text == "-")
                textBox1.Text = "+";
            else
                textBox1.Text = "-";
        }
    }
}

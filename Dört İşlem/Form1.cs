using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonToplama.Checked==true)
            {
                int sayı1, sayı2, toplam;
                sayı1 = Convert.ToInt32(textBox1.Text);
                sayı2 = Convert.ToInt32(textBox2.Text);
                toplam = sayı1 + sayı2;
                richTextBox1.Text = " " + toplam;
            }
            if (radioButtonÇıkarma.Checked == true)
            {
                int sayı1, sayı2, çıkarma;
                sayı1 = Convert.ToInt32(textBox1.Text);
                sayı2 = Convert.ToInt32(textBox2.Text);
                çıkarma = sayı1 - sayı2;
                richTextBox1.Text = " " + çıkarma;
            }
            if (radioButtonÇarpma.Checked == true)
            {
                int sayı1, sayı2, çarpma;
                sayı1 = Convert.ToInt32(textBox1.Text);
                sayı2 = Convert.ToInt32(textBox2.Text);
                çarpma = sayı1 * sayı2;
                richTextBox1.Text = " " + çarpma;
            }
            if (radioButtonBölme.Checked == true)
            {
               double sayı1, sayı2, bölme;
                sayı1 = Convert.ToInt32(textBox1.Text);
                sayı2 = Convert.ToInt32(textBox2.Text);
                bölme = sayı1 / sayı2;
                Math.Round(bölme, 5);
                richTextBox1.Text = " " + bölme;
            }
            if (textBox1.Text == "") 
            {
                MessageBox.Show("1.sayı boş geçilemez");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("2.sayı boş geçilemez");
                textBox2.Focus();
                return;
            }
            if (radioButtonBölme.Checked==true && textBox2.Text=="0")
            {
                MessageBox.Show("0'a bölme işlemi yapılamaz");
                textBox2.Clear();
                textBox2.Focus();
                return;
                
            }
            if (richTextBox1.Text == "") 
            {
                MessageBox.Show("İşlem seçmediniz");
                return;
            

            }

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class text : Form
    {
        public text()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            if (textad.Text=="")
            {
                MessageBox.Show("ad alanı boş geçilemez");
                textad.BackColor = System.Drawing.Color.LemonChiffon;
                textad.Focus();
                return;
            }


            rtbkayıt.Text = "adı: " + textad.Text;
            rtbkayıt.Text += "\nsoyadı: " + textsoyad.Text;
            rtbkayıt.Text += "\nşifre: " + textşifre.Text;

            if (textposta.Text.IndexOf('@')==-1)
            {
                MessageBox.Show("e mail adresi '@' içermeli");
                textposta.BackColor = System.Drawing.Color.LemonChiffon;
                textad.Focus();
                return;
            }
            rtbkayıt.Text += "\ne-posta: " + textposta.Text;
            if (radioerkek.Checked==true)
            {
                rtbkayıt.Text += "\ncinsiyet: erkek";
            }
            else if (radiokadın.Checked==true)
            {
                rtbkayıt.Text += "\ncinsiyet: kadın";
            }
            else
            {
                MessageBox.Show("cinsiyet belirtmediniz");
                return;
            }
        }

        private void textad_Click(object sender, EventArgs e)
        {
           
        }

        private void text_Click(object sender, EventArgs e)
        {

        }

        private void beyz(object sender, EventArgs e)
        {

        }

        private void textad_Enter(object sender, EventArgs e)
        {
            textad.Clear();
        }

        private void textsoyad_Enter(object sender, EventArgs e)
        {
            textsoyad.Clear();
        }

        private void textşifre_Enter(object sender, EventArgs e)
        {
            textşifre.Clear();
        }

        private void textposta_Enter(object sender, EventArgs e)
        {
            textposta.Clear();
        }

        private void textad_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

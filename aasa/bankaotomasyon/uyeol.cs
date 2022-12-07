using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankaotomasyon
{
    public partial class uyeol : Form
    {
        public uyeol()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
            textBox2.SelectionStart = textBox2.Text.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==string.Empty || textBox2.Text == string.Empty || maskedTextBox1.Text == string.Empty || maskedTextBox2.Text == string.Empty || maskedTextBox3.Text == string.Empty) 
            {
                MessageBox.Show("Lütfen Formu Eksiksiz Doldurunuz!!!");
            }
            else
            {

            MessageBox.Show("-Kayıt Başarılı-");
            this.Close();
            }
        }
    }
}

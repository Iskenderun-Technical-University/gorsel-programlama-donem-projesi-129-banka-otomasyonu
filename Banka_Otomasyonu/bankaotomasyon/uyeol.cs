using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

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
        
        sqlbaglanti bgl = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==string.Empty || maskedTextBox1.Text == string.Empty || maskedTextBox2.Text == string.Empty || maskedTextBox3.Text == string.Empty) 
            {
                MessageBox.Show("Lütfen Formu Eksiksiz Doldurunuz!!!");
            }
            else
            {
                
                SqlCommand komut = new SqlCommand("insert into Kullanici (ad,soyad,telefon,tc,sifre,bakiye) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", textBox1.Text);
                komut.Parameters.AddWithValue("@p2", textBox2.Text);
                komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
                komut.Parameters.AddWithValue("@p5", maskedTextBox3.Text);
                komut.Parameters.AddWithValue("@p6", 0);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();


                MessageBox.Show("-Kayıt Başarılı-");
                this.Close();
            }



        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.ToUpper();
            textBox2.SelectionStart = textBox2.Text.Length;
        }
    }
}

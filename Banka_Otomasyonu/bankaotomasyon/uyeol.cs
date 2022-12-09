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
            textBox1.SelectionStart = textBox1.Text.Length;
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE6J6UN\\SQLEXPRESS;Initial Catalog=Banka;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==string.Empty || maskedTextBox1.Text == string.Empty || maskedTextBox2.Text == string.Empty || maskedTextBox3.Text == string.Empty) 
            {
                MessageBox.Show("Lütfen Formu Eksiksiz Doldurunuz!!!");
            }
            else
            {

            MessageBox.Show("-Kayıt Başarılı-");
            this.Close();
            }

            baglanti.Open();
            SqlCommand kayit_ekle = new SqlCommand("insert into Kullanici (Ad_Soyad,Tel_no,TC_Kimlik_No,Sifre) values (@p1,@p2,@p3,@p4)", baglanti);

            kayit_ekle.Parameters.AddWithValue("@p1", textBox1.Text);
            kayit_ekle.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            kayit_ekle.Parameters.AddWithValue("@p3", maskedTextBox2.Text);
            kayit_ekle.Parameters.AddWithValue("@p4", maskedTextBox3.Text);

            kayit_ekle.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}

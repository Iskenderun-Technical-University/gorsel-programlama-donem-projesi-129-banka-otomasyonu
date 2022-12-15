using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bankaotomasyon
{
    public partial class uyegiris : Form
    {
        public uyegiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from bankauyeler where tc = @p1 and sifre = @p2",bgl.baglanti());    //Şifre ve Tc yi gerekli yerlerden alma
            komut.Parameters.AddWithValue("@p1", maskedTextBoxtc.Text);   
            komut.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())          
            {
                hesapdetay frm = new hesapdetay();
                frm.tc = maskedTextBoxtc.Text;
                frm.Show();                                     //Şifre Ve Tc veri tabanıyla karşılaştırıldı 
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre!!!");          //Şifre ve Tc yanlışsa
            }
            bgl.baglanti().Close();
        }

        private void buttonsifreunuttum_Click(object sender, EventArgs e)
        {
            sifremiunuttum frm = new sifremiunuttum();   //Şifremi unuttum formuna yönlendirme
            frm.Show();
        }

        private void uyegiris_Load(object sender, EventArgs e)
        {

        }
    }
}

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
            SqlCommand komut = new SqlCommand("select * from bankauyeler where tc = @p1 and sifre = @p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBoxtc.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                hesapdetay frm = new hesapdetay();
                frm.tc = maskedTextBoxtc.Text;
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre!!!");
            }
            bgl.baglanti().Close();
        }

        private void buttonsifreunuttum_Click(object sender, EventArgs e)
        {
            sifremiunuttum frm = new sifremiunuttum();
            frm.Show();
        }

        private void uyegiris_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl=new sqlbaglanti();
        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("UPDATE bankauyeler SET sifre=@p1 WHERE tc=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Şifre Değiştirildi");
            this.Close();
        }
    }
}

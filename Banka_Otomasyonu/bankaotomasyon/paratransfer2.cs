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
    public partial class paratransfer2 : Form
    {
        public paratransfer2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void button5_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0 && numericUpDown1.Value <= Convert.ToInt32(label5.Text))
            {


                SqlCommand komut = new SqlCommand("UPDATE bankauyeler SET bakiye=@p1 WHERE tc=@p2", bgl.baglanti());
                SqlCommand komut2 = new SqlCommand("UPDATE bankauyeler SET bakiye=@p3 WHERE tc=@p4", bgl.baglanti());

                komut.Parameters.AddWithValue("@p2", label8.Text);
                komut2.Parameters.AddWithValue("@p4", label10.Text);
                komut.Parameters.AddWithValue("@p1", numericUpDown1.Value + Convert.ToInt32(label9.Text));
                komut2.Parameters.AddWithValue("@p3", Convert.ToInt32(label5.Text) - numericUpDown1.Value);


                komut.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("İşlem Başarılı !!!\nGönderilen Tutar: " + numericUpDown1.Value + " TL");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Lütfen girdiğiniz tutarı kontrol ediniz!!!");
            }
        }

        public string tc;
        public string alıcı;
        public string tc2;

        private void paratransfer2_Load(object sender, EventArgs e)
        {
            label5.Text = tc;
            label8.Text = alıcı;
            label10.Text = tc2;

            SqlCommand komut = new SqlCommand("select ad, soyad, bakiye from bankauyeler where tc = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", label8.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label7.Text = dr[0] + " " + dr[1];
                label9.Text = dr[2] + "";
            }
            bgl.baglanti().Close();
        }
    }
    }


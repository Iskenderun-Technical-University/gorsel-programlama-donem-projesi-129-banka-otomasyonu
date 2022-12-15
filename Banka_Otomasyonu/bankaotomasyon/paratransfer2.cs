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

       

        sqlbaglanti bgl = new sqlbaglanti();

        private void button5_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0 && numericUpDown1.Value <= Convert.ToInt32(label5.Text)) //Girilen değerin bakiyeden ve sıfırdan büyük olmasının kontrolü 
            {


                SqlCommand komut = new SqlCommand("UPDATE bankauyeler SET bakiye=@p1 WHERE tc=@p2", bgl.baglanti());    //Veri tabanında girilen bilgilere göre güncelleme yapılması
                SqlCommand komut2 = new SqlCommand("UPDATE bankauyeler SET bakiye=@p3 WHERE tc=@p4", bgl.baglanti());

                komut.Parameters.AddWithValue("@p2", label8.Text);
                komut2.Parameters.AddWithValue("@p4", label10.Text);
                komut.Parameters.AddWithValue("@p1", numericUpDown1.Value + Convert.ToInt32(label9.Text));     //Para gönderilen kişinin bakiyesinin arttırılması
                komut2.Parameters.AddWithValue("@p3", Convert.ToInt32(label5.Text) - numericUpDown1.Value);    //Para gönderen kişinin bakiyesini azaltılması


                komut.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("İşlem Başarılı !!!\nGönderilen Tutar: " + numericUpDown1.Value + " TL");    //Gönderilen tutarın bilgilendirmesi
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
            label5.Text = tc;    //gerekli bilgilerin sonraki forma çekilmesi
            label8.Text = alıcı;
            label10.Text = tc2;

            SqlCommand komut = new SqlCommand("select ad, soyad, bakiye from bankauyeler where tc = @p1", bgl.baglanti()); //Veri tabanından gerekli bilgilerin getirilmesi
            komut.Parameters.AddWithValue("@p1", label8.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label7.Text = dr[0] + " " + dr[1];      //Veri tabanından alınan bilgilerin yazdırılması
                label9.Text = dr[2] + "";
            }
            bgl.baglanti().Close();
        }
    }
    }


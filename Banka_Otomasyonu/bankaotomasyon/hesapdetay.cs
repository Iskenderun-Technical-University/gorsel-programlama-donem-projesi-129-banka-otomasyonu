using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace bankaotomasyon
{
   
    public partial class hesapdetay : Form
    {
        public hesapdetay()
        {
            InitializeComponent();
        }
          
        private void button1_Click(object sender, EventArgs e)
        {
            paracek frm=new paracek();
            frm.tc = label5.Text;
            frm.tc2 = labeltc.Text;
            frm.Show();
            
        }
        public string bakiye;
        
        private void button2_Click(object sender, EventArgs e)
        {
            parayatır frm = new parayatır();
            frm.tc=label5.Text;
            frm.tc2=labeltc.Text;

            
           
            
            frm.Show();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        public string tc;
        private void hesapdetay_Load(object sender, EventArgs e)
        {
            labeltc.Text = tc;

            SqlCommand komut = new SqlCommand("select ad, soyad, bakiye from bankauyeler where tc = @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",labeltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr[0] + " " + dr[1];
                label5.Text = dr[2] + "";
            }
            bgl.baglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paratransfer frm=new paratransfer(); 
            frm.tc = label5.Text;
            frm.tc2=labeltc.Text;
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dovizkur frm=new dovizkur();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labeltc.Text = tc;

            SqlCommand komut = new SqlCommand("select ad, soyad, bakiye from bankauyeler where tc = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", labeltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr[0] + " " + dr[1];
                label5.Text = dr[2] + "";
            }
            bgl.baglanti().Close();
        }
    }
}

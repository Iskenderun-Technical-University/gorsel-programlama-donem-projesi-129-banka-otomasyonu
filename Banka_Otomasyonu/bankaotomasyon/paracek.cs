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

namespace bankaotomasyon
{
    public partial class paracek : Form
    {
        public paracek()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 50;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 200;
        }
          sqlbaglanti bgl= new sqlbaglanti();
        private void button5_Click(object sender, EventArgs e)
        {

            if(numericUpDown1.Value > 0)
            {
                SqlCommand komut = new SqlCommand("UPDATE bankauyeler SET bakiye=@p1 WHERE tc=@p2", bgl.baglanti());

                komut.Parameters.AddWithValue("@p2", label6.Text);
                komut.Parameters.AddWithValue("@p1", Convert.ToInt32(label5.Text) - numericUpDown1.Value );

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("İşlem Başarılı !!!\nÇekilen Tutar: " + numericUpDown1.Value+" TL");
           
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen 0'dan büyük değer giriniz!!!");
            }
        }
        public string tc;
        public string tc2;
        private void paracek_Load(object sender, EventArgs e)
        {
            label5.Text = tc;
            label6.Text = tc2;
            numericUpDown1.Focus();
        }
         

        
    }
}

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

        private void button5_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value > 0)
            {

           
            MessageBox.Show("İşlem Başarılı !!!\nÇekilen Tutar: " + numericUpDown1.Value+" TL");
            this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen 0'dan büyük değer giriniz!!!");
            }
        }

        private void paracek_Load(object sender, EventArgs e)
        {
            numericUpDown1.Focus();
        }
    }
}

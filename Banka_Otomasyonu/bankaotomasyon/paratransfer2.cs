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

        private void button5_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {


                MessageBox.Show("İşlem Başarılı !!!\nGönderilen Tutar: " + numericUpDown1.Value + " TL");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Lütfen 0'dan büyük değer giriniz!!!");
            }
        }
    }
    }


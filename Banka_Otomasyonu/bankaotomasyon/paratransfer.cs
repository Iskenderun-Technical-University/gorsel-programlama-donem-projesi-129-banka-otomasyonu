using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankaotomasyon
{
    public partial class paratransfer : Form
    {
        public paratransfer()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text == string.Empty)    //Boş değer girilmesini önlemek
            {
                MessageBox.Show("Lütfen Formu Eksiksiz Doldurunuz!!!");
            }
            else
            {
                paratransfer2 fr = new paratransfer2();  
                fr.tc = label5.Text;                             //gerekli bilgilerin sonraki forma taşınması
                fr.tc2 = label7.Text; 
                fr.alıcı = maskedTextBox1.Text;


                fr.Show();
                Close();
            }
            
            
        }

        public string tc;
        public string tc2;

        private void paratransfer_Load(object sender, EventArgs e)
        {
            label5.Text = tc;               //Gerekli bilgilerin başka formdan alınması
            label7.Text = tc2;
            
        }
    }
}

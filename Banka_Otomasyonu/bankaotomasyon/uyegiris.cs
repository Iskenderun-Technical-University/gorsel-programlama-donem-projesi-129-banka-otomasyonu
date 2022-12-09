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
    public partial class uyegiris : Form
    {
        public uyegiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hesapdetay frm = new hesapdetay();
            frm.Show();
            this.Close();
        }

        private void buttonsifreunuttum_Click(object sender, EventArgs e)
        {
            sifremiunuttum frm = new sifremiunuttum();
            frm.Show();
        }
    }
}

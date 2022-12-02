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
    public partial class hesapdetay : Form
    {
        public hesapdetay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paracek frm=new paracek();
            frm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parayatır frm = new parayatır();
            frm.Show();
        }

        private void hesapdetay_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            paratransfer frm=new paratransfer();    
            frm.Show();
        }
    }
}

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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            uyegiris frm = new uyegiris();    //Uye giriş formuna yönlendirme
            frm.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)  
        {
            uyeol frm=new uyeol();            //Uye ol formuna yönlendirme
            frm.Show();
            
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}

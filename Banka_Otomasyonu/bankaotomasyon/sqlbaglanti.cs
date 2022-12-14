using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaotomasyon
{
    internal class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-FMJQ9I6Q\\SQLEXPRESS;Initial Catalog=banka_proje;Integrated Security=True");

            baglan.Open();
            return baglan;
        }
        
    }
}

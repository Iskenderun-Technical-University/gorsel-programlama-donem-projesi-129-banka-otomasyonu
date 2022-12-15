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
        public SqlConnection baglanti()  //sql bağlantısı bağlandı
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-QE6J6UN\\SQLEXPRESS;Initial Catalog=Banka;Integrated Security=True");

            baglan.Open();
            return baglan;
        }
        
    }
}

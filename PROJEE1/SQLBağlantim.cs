using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;

namespace PROJEE1
{
    public class SQLBağlantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-5KQACGN\SQLEXPRESS;Initial Catalog=arackiralama;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
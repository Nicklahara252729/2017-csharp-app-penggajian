using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenggajian
{
    class koneksi2
    {
        public static string connstring = string.Format("User ID=dbpenggajian; Password=123; Data Source='XE'");
        public static OracleConnection koneksiget()
        {
            return new OracleConnection(connstring);
        }
    }
}

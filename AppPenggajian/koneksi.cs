using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenggajian
{
    class koneksi
    {
        public static string connstring = string.Format("Data Source=XE; User ID=dbpenggajian; Password=123");
        public static OracleConnection koneksidata()
        {
            return new OracleConnection(connstring);
        }
    }
}

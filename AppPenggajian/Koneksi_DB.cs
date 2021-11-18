using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenggajian
{
    class Koneksi_DB
    {
        public static string ConnString = string.Format
            ("Data Source=XE; User Id=dbpenggajian; Password=dbp;");
        public static OracleConnection GetOracleConnection()
        {
            return new OracleConnection(ConnString);
        }
    }
}

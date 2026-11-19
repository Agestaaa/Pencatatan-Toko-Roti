using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Windforms_Toko_Roti.Database
{
    public class NYAMBUNG
    {
        // Sesuaikan nama database, username, dan password PostgreSQL di laptopmu
        private static readonly string connString =
            "Host=localhost;Port=5432;Database=cloud_bakery;Username=postgres;Password=root";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}

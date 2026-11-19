using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Windforms_Toko_Roti
{
    internal class DatabaseConnection
    {
        private static string connectionString=
            "Host=localhost;" +
            "port=5432;" +
            "Database=cloudBakery;" +
            "Username=postgres;" +
            "Password=entah";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

        public static bool TestConnection(out string message)
        {
            try
            {
                using (NpgsqlConnection conn = GetConnection())
                {
                    conn.Open();
                    message = "Berhasil terhubung ke database cloudBakery!";
                    return true;
                }
            } 
            catch(Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
    }
}

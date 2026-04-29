// Libreria per usare MySql
using MySql.Data.MySqlClient;
using MySql.Data;
using System;

namespace MySql_DataGrid
{
    internal class GestioneMySql
    {

        // Stringhe di connessione al DB nel server DB db4free.net e al server di Uniserver Z in locale
        public static string connStrInfinity = "server=db4free.net; user=maquilanti; database=db_multe; port=3306; password=qwertyuiop";
        public static string connStrUniZ = "server=127.0.0.1;user=root;database=multe;port=3306;password=marco";
        public static MySqlConnection Connessione = new MySqlConnection(connStrUniZ);

        public static bool ApriConnessione()
        {
            
            try
            {
                if (Connessione.State != System.Data.ConnectionState.Open)
                {
                    Connessione.ConnectionString = GestioneMySql.connStrUniZ;
                    Connessione.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ChiudiConnessione()
        {
            try
            {
                if (Connessione.State != System.Data.ConnectionState.Closed)
                {
                    Connessione.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
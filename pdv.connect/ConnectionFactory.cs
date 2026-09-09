using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SQLite;

namespace DonPdv.pdv.connect
{
    class ConnectionFactory
    {

        private static SQLiteConnection vcon;

        public static SQLiteConnection GetConnection()
        {
            //string vcon = ConfigurationManager.ConnectionStrings["donpdv"].ConnectionString;
             vcon = new SQLiteConnection("Data Source =" + Program.caminhoBanco + Program.nomeBanco);
            return new SQLiteConnection(vcon);
            /* vcon = new SQLiteConnection(@"Data Source = C: \Users\klebe\OneDrive\Desktop\Apps\DonPdv\banco\db_loja.db");
            vcon.Open();
            return vcon;
            */
        }
        /*
        public MySqlConnection GetConnection()
        {
            string vcon = ConfigurationManager.ConnectionStrings["donpdv"].ConnectionString;
            return new MySqlConnection(vcon);
        }
        */
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;                     
using System.Threading.Tasks;
using Kependudukan.config;
using System.Data.SqlClient;

namespace Kependudukan.config
{
    class KoneksiDB_cls : Service_cls
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataAdapter adp;

        static string[] data = Configuration.readConfig("config.txt");

        string alamatKoneksi = "server="+ data[0] + ";port=" + data[1] + ";database=" + data[2] + ";uid=" + data[3] + ";pwd=" + data[4];

        //string alamatKoneksi = "server=localhost;port=3306;database=kependudukan;uid=root;pwd=";
        public KoneksiDB_cls() // Constructor
        {
            con = new MySqlConnection(alamatKoneksi);
            com = new MySqlCommand();
            adp = new MySqlDataAdapter();
        }

        void bukaKoneksi()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
            }
            catch (Exception ex) { }
        }

        void tutupKoneksi()
        {
            con.Close();
        }

        public override int ekskusiBukanQuery(string query)
        {
            int result = -1;
            try
            {
                bukaKoneksi();

                com.Connection = con;
                com.CommandText = query;
                result = com.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                tutupKoneksi();
            }

            return result;
        }

        public override DataTable ekskusiQuery(string query)
        {
            DataTable result = new DataTable();
            try
            {
                bukaKoneksi();

                com.Connection = con;
                com.CommandText = query;
                adp.SelectCommand = com;
                adp.Fill(result);
            }
            catch (Exception ex) { }
            finally
            {
                tutupKoneksi();
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HALKEY
{
    internal static class DbConn
    {
        public static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\MOUNTAIN\Documents\Halkey_Db.mdf;Integrated Security = True; Connect Timeout = 30";

        public static void fillTable(string query, DataGridView DV, SqlConnection conn)
        {
            try
            {

                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                dataAdapter.Fill(dataTable);
                DV.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
            }
        }

        
    }

}

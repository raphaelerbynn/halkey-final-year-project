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

        /*public static  string connectionString()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Halkey_Db.mdf;Integrated Security = True; Connect Timeout = 30";

        }*/

        public static string location = System.IO.Path.GetFullPath("Halkey00.mdf");
        
        public static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+location+@";Integrated Security=True;Connect Timeout=30";
        //public static string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Halkey;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
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

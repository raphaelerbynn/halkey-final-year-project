using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HALKEY.Pages
{
    public partial class RoomModule : Form
    {
        public RoomModule()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DbConn.connString);
            try
            {
                conn.Open();

                //System.Diagnostics.Debug.WriteLine(Encoding.Default.GetString(imgByte));
                string room_id = blockTb.Text + '-'+room_num;
                string query = "INSERT INTO Room (room_id, number, capacity, block) VALUES('"+room_id+"', '"+room_num+"', '"+capacityTb.Text+"', '"+blockTb.Text+"')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFeild();

                conn.Close();
            }
            catch (SqlException ex)
            {


                if (ex.Message.Contains("Violation of PRIMARY KEY"))
                {
                    MessageBox.Show("ID of room already exist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void clearFeild()
        {

        }
    }
}

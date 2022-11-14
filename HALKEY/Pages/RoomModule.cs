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
        SqlConnection conn = new SqlConnection(DbConn.connString);
        private string id;
        byte[] img;
        List<byte[]> roomMemberPics = new List<byte[]>();
        List<string> roomMembers = new List<string>();

        public RoomModule()
        {
            InitializeComponent();
            string query = "SELECT room_id, number, block, capacity FROM Room";
            DbConn.fillTable(query, roomDV, conn);
            columnOrder();
        }

        private void columnOrder()
        {
            roomDV.AutoGenerateColumns = false;
            roomDV.Columns["room_id"].DisplayIndex = 0;
            roomDV.Columns["block"].DisplayIndex = 1;
            roomDV.Columns["room_num"].DisplayIndex = 2;
            roomDV.Columns["capacity"].DisplayIndex = 3;
            roomDV.Columns["members"].DisplayIndex = 4;
            roomDV.Columns["update"].DisplayIndex = 5;
            roomDV.Columns["delete"].DisplayIndex = 6;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            
            try
            {
                string room_id = blockTb.Text + '-' + roomNumBar.Value.ToString();
                conn.Open();

                //System.Diagnostics.Debug.WriteLine(Encoding.Default.GetString(imgByte));
                if (room_id == null)
                {
                    string query = "INSERT INTO Room (room_id, number, capacity, block) VALUES('" + room_id + "', '" + roomNumBar.Value + "', '" + capacityTb.Text + "', '" + blockTb.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query = "UPDATE Room SET room_id='" + room_id + "', number='" + roomNumBar.Value + "', capacity='" + capacityTb.Text + "', block='" + blockTb.Text + "' WHERE room_id='" + id + "'";
                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                clearFeild();

                string query1 = "SELECT room_id, number, block, capacity FROM Room";
                DbConn.fillTable(query1, roomDV, conn);

                conn.Close();
            }
            catch (SqlException ex)
            {

                conn.Close();
                if (!ex.Message.Contains("Violation of PRIMARY KEY"))
                {

                    //MessageBox.Show("ID of room already exist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void clearFeild()
        {
            roomNumBar.Value = 0;
            blockTb.Text = null;
            capacityTb.SelectedIndex = -1;

            saveBtn.Enabled = true;
            updateBtn.Enabled = false;
        }

        private void roomDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = roomDV.Rows[e.RowIndex];
            id = row.Cells["room_id"].Value.ToString();

            if (roomDV.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0)
            {
                string message = "Do you want to delete room " + id + "?";
                MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "", deleteAction);
                if (result == DialogResult.Yes)
                {

                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Room WHERE room_id='" + id + "'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    roomDV.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Room deleted from system");

                }
            }

            if (roomDV.Columns[e.ColumnIndex].Name == "update" && e.RowIndex >= 0)
            {
                updateBtn.Enabled = true;
                saveBtn.Enabled = false;

                roomNumBar.Value = int.Parse(row.Cells["room_num"].Value.ToString());
                blockTb.Text = (String.IsNullOrWhiteSpace(row.Cells["block"].Value.ToString()) ? "" : row.Cells["block"].Value.ToString()).Trim();
                capacityTb.SelectedItem = row.Cells["capacity"].Value.ToString();
            }

            if (roomDV.Columns[e.ColumnIndex].Name == "members" && e.RowIndex >= 0)
            {
                string query = "SELECT passport_pic, fname + ' ' + mname + ' ' + lname AS name FROM Student WHERE room_id='"+id+"'";
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        roomMemberPics.Add((byte[])reader["passport_pic"]);
                        roomMembers.Add(reader["name"].ToString());
                    }
                    reader.Close();

                    conn.Close();
                }
                catch { }
            }
        }

        /* 
         if (!DBNull.Value.Equals(reader["passport_pic"]))
                    {
                        byte[] imgByte = (byte[])reader["passport_pic"];
                        MemoryStream ms = new MemoryStream(imgByte);
                        passportPic.Image = new Bitmap(ms);
                    }
         */
    }
}

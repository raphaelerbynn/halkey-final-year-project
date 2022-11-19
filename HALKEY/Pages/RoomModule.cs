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
        private string query;
        byte[] img;
        List<byte[]> roomMemberPics = new List<byte[]>();
        List<string> roomMembers = new List<string>();

        public RoomModule()
        {
            InitializeComponent();
            query = "SELECT room_id, number, block, capacity FROM Room";
            DbConn.fillTable(query, roomDV, conn);
            columnOrder();
            roomLbl.Text = "---";
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
                if (saveBtn.Enabled)
                {
                    query = "INSERT INTO Room (room_id, number, capacity, block) VALUES('" + room_id + "', '" + roomNumBar.Value + "', '" + capacityTb.Text + "', '" + blockTb.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    query = "UPDATE Student SET room_id=NULL WHERE room_id='" + id + "'";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    query = "UPDATE Room SET room_id='" + room_id + "', number='" + roomNumBar.Value + "', capacity='" + capacityTb.Text + "', block='" + blockTb.Text + "' WHERE room_id='" + id + "'";
                    
                    cmd = new SqlCommand(query, conn);
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
                else
                {
                    MessageBox.Show("ID of room already exist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
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
                    roomMembers.Clear();
                    roomMemberPics.Clear();

                    roomLbl.Text = "---";
                    roomLbl.Text = id;
                    int capacity = int.Parse(row.Cells["capacity"].Value.ToString());
                    string query = "SELECT passport_pic, fname + ' ' + mname + ' ' + lname AS name FROM Student WHERE room_id='" + id + "'";
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

                    /*int t = 1;
                    foreach (Control lbl in viewPanel.Controls)
                    {
                        int i = 0;
                        if (lbl is Label)
                        {
                            lbl.Text = "---";
                            if (lbl.Tag != null)
                            {
                                if (int.Parse(lbl.Tag?.ToString()) == t)
                                {
                                    lbl.Text = roomMembers[i];
                                    i++;
                                }
                                t++;
                            }
                        }

                    }*/

                    for (int i = 1; i <= capacity * 2; i++)
                    {
                        int a = 0;
                        foreach (Control c in viewPanel.Controls)
                        {
                            try
                            {
                                if (c.Tag != null)
                                {
                                    if (int.Parse(c.Tag?.ToString()) == i)
                                    {

                                        if (c is Label)
                                        {
                                            if (i <= roomMembers.Count)
                                            {
                                                ((Label)c).Text = roomMembers[i - 1].ToString();
                                                a++;
                                            }
                                            else
                                            {
                                                ((Label)c).Text = "---";
                                            }
                                        }

                                        if (c is PictureBox)
                                        {
                                            if (i <= roomMembers.Count)
                                            {
                                                MemoryStream ms = new MemoryStream(roomMemberPics[i - 1]);
                                                ((PictureBox)c).Image = new Bitmap(ms);
                                                a++;
                                            }
                                            else
                                            {
                                                ((PictureBox)c).Image = global::HALKEY.Properties.Resources.assign;
                                            }
                                        }

                                        Console.WriteLine(i.ToString());
                                        if (a == 2)
                                        {
                                            a = 0;
                                            continue;
                                        }

                                        /*if (i > roomMembers.Count)
                                        {
                                            break;
                                        }*/
                                    }
                                    System.Diagnostics.Debug.WriteLine("Printing the i=" + i);

                                }
                            }
                            catch { }

                        }
                    }
                }
            }
            catch { }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                (roomDV.DataSource as DataTable).DefaultView.RowFilter = string.Format("room_id LIKE '%{0}%'", searchTb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Again");
                MessageBox.Show(ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFeild();
        }
    }
}

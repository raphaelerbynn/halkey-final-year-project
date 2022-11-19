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
    public partial class UpdateStudent : Form
    {
        SqlConnection conn = new SqlConnection(DbConn.connString);
        SqlCommand cmd;
        string query;
        string room;
        string id = StudentModule.id;
        byte[] imgByte;

        public UpdateStudent()
        {
            InitializeComponent();
            
            comboFill();
            fillData();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void fillData()
        {
            try
            {
                query = "SELECT * FROM Student WHERE student_id = '"+id+"'";
                conn.Open();

                cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    idTb.Text = reader["student_id"].ToString();
                    fnameTb.Text = reader["fname"].ToString();
                    mnameTb.Text = reader["mname"].ToString();
                    snameTb.Text = reader["lname"].ToString();
                    contactTb.Text = reader["contact"].ToString();
                    emergencyTb.Text = reader["emergency_contact"].ToString();
                    programTb.Text = reader["programme"].ToString();

                    levelCb.SelectedItem = reader["level"].ToString();
                    genderCb.SelectedItem = reader["gender"].ToString();
                    categoryCb.SelectedItem = reader["category"].ToString();
                    roomCb.SelectedItem = reader["room_id"].ToString();
                    room = reader["room_id"].ToString();

                    if (!DBNull.Value.Equals(reader["passport_pic"]))
                    {
                        byte[] imgByte = (byte[])reader["passport_pic"];
                        MemoryStream ms = new MemoryStream(imgByte);
                        passportPic.Image = new Bitmap(ms);
                    }
                }
                reader.Close();
                    


               conn.Close();

               idTb.Enabled = false;
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private string[] getRoomCapacity()
        {
            string[] count = new string[2];
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE room_id='" + roomCb.Text + "'", conn);
                count[0] = cmd.ExecuteScalar().ToString();

                cmd = new SqlCommand("SELECT capacity FROM ROOM WHERE room_id='" + roomCb.Text + "'", conn);
                count[1] = cmd.ExecuteScalar().ToString();

                conn.Close();
            }
            catch { conn.Close(); }

            return count;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(getRoomCapacity()[0]) < int.Parse(getRoomCapacity()[1]) || room.Equals(roomCb.Text))
            {
                string message = "Do you want to update this student data?";
                MessageBoxButtons deleteAction = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "", deleteAction);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (imgByte == null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                passportPic.Image.Save(ms, passportPic.Image.RawFormat);
                                imgByte = ms.ToArray();
                            }
                        }

                        string query0 = "UPDATE Student SET " +
                            "fname = '" + fnameTb.Text + "'," +
                            "mname = '" + mnameTb.Text + "'," +
                            "lname = '" + snameTb.Text + "'," +
                            "contact = '" + contactTb.Text + "'," +
                            "emergency_contact = '" + emergencyTb.Text + "'," +
                            "programme = '" + programTb.Text + "'," +

                            "level = '" + levelCb.Text + "'," +
                            "gender = '" + genderCb.Text + "'," +
                            "category = '" + categoryCb.Text + "'," +
                            "room_id = '" + roomCb.Text + "' " +
                            " WHERE student_id = '" + idTb.Text + "' ";

                        string query1 = "UPDATE Student SET passport_pic=@img WHERE student_id = '" + idTb.Text + "'";

                        conn.Open();
                        cmd = new SqlCommand(query0, conn);
                        cmd.Parameters.AddWithValue("@img", imgByte);
                        cmd.ExecuteNonQuery();



                        cmd = new SqlCommand(query1, conn);
                        cmd.Parameters.AddWithValue("@img", imgByte);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Updates successfully!!!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("The selected Room is full", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.jpeg; *.jpg; *.png) | *.jpeg; *.jpg; *.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                passportPic.Image = new Bitmap(openFile.FileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    passportPic.Image.Save(ms, passportPic.Image.RawFormat);
                    imgByte = ms.ToArray();
                }

            }
        }

        private void comboFill()
        {
            try
            {
                
                conn.Open();
                query = "SELECT room_id FROM Room WHERE current_members<capacity ORDER BY room_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomCb.Items.Add(reader[0].ToString());
                }
                reader.Close();
                conn.Close();
            }
            catch { }
        }
    }
}

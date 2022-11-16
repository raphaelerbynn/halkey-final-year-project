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
    public partial class AddStudent : Form
    {
        private byte[] imgByte = null;
        SqlConnection conn = new SqlConnection(DbConn.connString);

        public AddStudent()
        {
            InitializeComponent();

            genderCb.SelectedIndex = 0;
            categoryCb.SelectedIndex = 0;

            comboFill();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
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

        private void clearFeild()
        {
            idTb.Text = null;
            fnameTb.Text = null;
            mnameTb.Text = null;
            snameTb.Text = null;
            contactTb.Text = null;
            emergencyTb.Text = null;
            programTb.Text = null;

            genderCb.SelectedIndex = 0;
            categoryCb.SelectedIndex = 0;
            levelCb.SelectedIndex = -1;
            roomCb.SelectedIndex = -1;

            if(levelCb.Enabled == false)
            {
                levelCb.Enabled = true;
            }

            passportPic.Image = global::HALKEY.Properties.Resources.assign;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(idTb.Text) |
                String.IsNullOrWhiteSpace(fnameTb.Text) |
                String.IsNullOrWhiteSpace(snameTb.Text) |
                String.IsNullOrWhiteSpace(contactTb.Text) |
                String.IsNullOrWhiteSpace(emergencyTb.Text) |
                String.IsNullOrWhiteSpace(programTb.Text)))
            {
                
                
                try
                {
                    string middle_name = "";
                    string room = "";
                    if (!String.IsNullOrEmpty(roomCb.Text))
                    {
                        room = roomCb.Text;
                    }

                    if (!String.IsNullOrWhiteSpace(mnameTb.Text))
                    {
                        middle_name = mnameTb.Text;
                    }

                    if (imgByte == null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            passportPic.Image.Save(ms, passportPic.Image.RawFormat);
                            imgByte = ms.ToArray();
                        }
                    }
                    //System.Diagnostics.Debug.WriteLine(Encoding.Default.GetString(imgByte));
                    conn.Open();
                    string query = "INSERT INTO Student VALUES(@student_id, @fname, @mname, @lname, @gender, " +
                        "@emergency_contact, @programme, @category, @level, @level, @passport_pic, @date_registered," +
                        " @room_id)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@student_id", idTb.Text);
                    cmd.Parameters.AddWithValue("@fname", fnameTb.Text);
                    cmd.Parameters.AddWithValue("@mname", middle_name);
                    cmd.Parameters.AddWithValue("@lname", snameTb.Text);
                    cmd.Parameters.AddWithValue("@gender", genderCb.Text);
                    cmd.Parameters.AddWithValue("@contact", contactTb.Text);
                    cmd.Parameters.AddWithValue("@emergency_contact", emergencyTb.Text);
                    cmd.Parameters.AddWithValue("@programme", programTb.Text);
                    cmd.Parameters.AddWithValue("@category", categoryCb.Text);
                    cmd.Parameters.AddWithValue("@level", levelCb.Text);
                    cmd.Parameters.AddWithValue("@passport_pic", imgByte);
                    cmd.Parameters.AddWithValue("@date_registered", DateTime.Now);
                    cmd.Parameters.AddWithValue("@room_id", room);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data saved successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFeild();
                    
                    conn.Close();
                }
                catch (SqlException ex)
                {

                    conn.Close();
                    if(ex.Message.Contains("Violation of PRIMARY KEY"))
                    {
                        MessageBox.Show("ID of student already exist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Feilds with * must be filled", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to clear fields", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                clearFeild();
            }
        }

        private void categoryCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoryCb.SelectedIndex == 0)
            {
                levelCb.SelectedIndex = 0;
                levelCb.Enabled = true;
            }
            else
            {
                levelCb.SelectedIndex = -1;
                levelCb.Enabled = false;
            }
        }

        private void comboFill()
        {
            conn.Open();

            string query = "SELECT room_id FROM Room WHERE current_members<capacity ORDER BY room_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                roomCb.Items.Add(reader[0].ToString());
            }
            reader.Close();

            conn.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void levelCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void genderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void emergencyTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void programTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void snameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void fnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void idTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void passportPic_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

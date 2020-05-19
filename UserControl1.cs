using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class UserControl1 : UserControl
    {
        string[] room_status = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        public UserControl1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            if (Program.select_room == "")
            {
                MessageBox.Show("กดเลือกห้องก่อน ");
            }
            else
            {
                result = MessageBox.Show("คุณยืนยันหรือไม่ที่จะเลือกห้องนี้  ถ้าคุณยืนยันเเล้วจะไม่สามารถยกเลิกห้องได้", "การเเจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result== DialogResult.Yes)
                {
                    MySqlConnection con = new MySqlConnection("host=localhost;user=test;password=123456;database=sunnee");
                    try

                    {
                        con.Open();
                        string sql = "UPDATE room SET status_room ='" + Program.usernameofDB + "' WHERE name_room = '" + Program.select_room + "';";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.ExecuteReader();
                        con.Close();
                        MessageBox.Show("บันทึกเรียบร้อยเเล้ว");
                        groupBox1.Enabled = false;
                        okaybutton.Enabled = false;
                        Program.use_select_room = true; //ไม่สามารถจองได้อีก
                       
                        
                      
                    }
                    catch
                    {
                        MessageBox.Show("เกิดข้อผิดพลาดในการ update ข้อมูล");
                    }

                }
                else
                {

                }
              
            }
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("host=localhost;user=test;password=123456;database=sunnee");
            try
            {
                con.Open();
                string sql = "SELECT * FROM room";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                groupBox1.Enabled = true;
                while (reader.Read())
                {
                    room_status[i] = reader.GetString("status_room");
                    i = i + 1;//ใช้อาเรเก็บห้องเเต่ละห้องมันจะมี อินเด็ก i มันจะเริ่มนับจาก 0ไปถึง 23
                 
                }
                con.Close();
                if (room_status[0] == "")
                {
                    room1101.BackColor= System.Drawing.Color.Green;
                    room1101.Enabled = true;
                }
                else
                {
                    room1101.Enabled = false;
                }


                if (room_status[1] == "")
                {
                    room1102.BackColor = System.Drawing.Color.Green;
                    room1102.Enabled = true;
                }
                else
                {
                    room1102.Enabled = false;
                }


                if (room_status[2] == "")
                {
                    room1103.BackColor = System.Drawing.Color.Green;
                    room1103.Enabled = true;
                }
                else
                {
                    room1103.Enabled = false;
                }

                if (room_status[3] == "")
                {
                    room1104.BackColor = System.Drawing.Color.Green;
                    room1104.Enabled = true;
                }
                else
                {
                    room1104.Enabled = false;
                }

                if (room_status[4] == "")
                {
                    room1105.BackColor = System.Drawing.Color.Green;
                    room1105.Enabled = true;
                }
                else
                {
                    room1105.Enabled = false;
                }

                if (room_status[5] == "")
                {
                    room1106.BackColor = System.Drawing.Color.Green;
                    room1106.Enabled = true;
                }
                else
                {
                    room1106.Enabled = false;
                }

                if (room_status[6] == "")
                {
                    room1107.BackColor = System.Drawing.Color.Green;
                    room1107.Enabled = true;
                }
                else
                {
                    room1107.Enabled = false;
                }

                if (room_status[7] == "")
                {
                    room1108.BackColor = System.Drawing.Color.Green;
                    room1108.Enabled = true;
                }
                else
                {
                    room1108.Enabled = false;
                }

                if (room_status[8] == "")
                {
                    room1109.BackColor = System.Drawing.Color.Green;
                    room1109.Enabled = true;
                }
                else
                {
                    room1109.Enabled = false;
                }

                if (room_status[9] == "")
                {
                    room1110.BackColor = System.Drawing.Color.Green;
                    room1110.Enabled = true;
                }
                else
                {
                    room1110.Enabled = false;
                }

                if (room_status[10] == "")
                {
                    room1111.BackColor = System.Drawing.Color.Green;
                    room1111.Enabled = true;
                }
                else
                {
                    room1111.Enabled = false;
                }

                if (room_status[11] == "")
                {
                    room1112.BackColor = System.Drawing.Color.Green;
                    room1112.Enabled = true;
                }
                else
                {
                    room1112.Enabled = false;
                }

                if (room_status[12] == "")
                {
                    room2101.BackColor = System.Drawing.Color.Green;
                    room2101.Enabled = true;
                }
                else
                {
                    room2101.Enabled = false;
                }

                if (room_status[13] == "")
                {
                    room2102.BackColor = System.Drawing.Color.Green;
                    room2102.Enabled = true;
                }
                else
                {
                    room2102.Enabled = false;
                }

                if (room_status[14] == "")
                {
                    room2103.BackColor = System.Drawing.Color.Green;
                    room2103.Enabled = true;
                }
                else
                {
                    room2103.Enabled = false;
                }

                if (room_status[15] == "")
                {
                    room2104.BackColor = System.Drawing.Color.Green;
                    room2104.Enabled = true;
                }
                else
                {
                    room2104.Enabled = false;
                }

                if (room_status[16] == "")
                {
                    room2105.BackColor = System.Drawing.Color.Green;
                    room2105.Enabled = true;
                }
                else
                {
                    room2105.Enabled = false;
                }

                if (room_status[17] == "")
                {
                    room2106.BackColor = System.Drawing.Color.Green;
                    room2106.Enabled = true;
                }
                else
                {
                    room2106.Enabled = false;
                }

                if (room_status[18] == "")
                {
                    room2107.BackColor = System.Drawing.Color.Green;
                    room2107.Enabled = true;
                }
                else
                {
                    room2107.Enabled = false;
                }

                if (room_status[19] == "")
                {
                    room2108.BackColor = System.Drawing.Color.Green;
                    room2108.Enabled = true;
                }
                else
                {
                    room2108.Enabled = false;
                }

                if (room_status[20] == "")
                {
                    room2109.BackColor = System.Drawing.Color.Green;
                    room2109.Enabled = true;
                }
                else
                {
                    room2109.Enabled = false;
                }

                if (room_status[21] == "")
                {
                    room2110.BackColor = System.Drawing.Color.Green;
                    room2110.Enabled = true;
                }
                else
                {
                    room2110.Enabled = false;
                }

                if (room_status[22] == "")
                {
                    room2111.BackColor = System.Drawing.Color.Green;
                    room2111.Enabled = true;
                }
                else
                {
                    room2111.Enabled = false;
                }

                if (room_status[23] == "")
                {
                    room2112.BackColor = System.Drawing.Color.Green;
                    room2112.Enabled = true;
                }
                else
                {
                    room2112.Enabled = false;
                }

            }
            catch
            {

            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void room21111_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "2111";
        }

        private void room1103_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "1103";
        }

        private void room1104_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "1104";
        }

        private void room1105_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "1105";
        }

        private void room1106_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "1106";
        }

        private void room1112_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "1112";
        }

        private void room1111_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "1111";
        }

        private void room1110_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "1110";
        }

        private void room1109_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "1109";
        }

        private void room1108_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "1108";
        }

        private void room1107_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "1107";
        }

        private void room2101_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "2101";
        }

        private void room2102_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "2102";
        }

        private void room2103_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "2103";
        }

        private void room2104_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "2104";
        }

        private void room2105_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "2105";
        }

        private void room2106_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "2106";
        }

        private void room2112_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "2112";
        }

        private void room1102_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "1102";
        }

        private void room2110_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "2110";
        }

        private void room2109_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "2109";
        }

        private void room2108_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "2108";
        }

        private void room2107_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "2107";
        }

        private void room1101_CheckedChanged(object sender, EventArgs e)
        {
            Program.select_room = "1101";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

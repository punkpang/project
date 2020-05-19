using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class aof : Form
    {
        public aof()
        {
            InitializeComponent();
            llpanel.Height = home.Height;
            llpanel.Top = home.Top;
            home_Control1.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            llpanel.Height = home.Height;
            llpanel.Top = home.Top;
            home_Control1.BringToFront();
        }

        private void room_Click(object sender, EventArgs e)
        {
            llpanel.Height = room.Height;
            llpanel.Top = room.Top;
            room_Control1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputusername.Text == "" || inputpassword.Text == "")
            {
                MessageBox.Show("กรุณากรอก user หรือ password ให้ครบถ้วน");

            }
            else
            {
                MySqlConnection con = new MySqlConnection("host=localhost;user=test;password=123456;database=sunnee");
                try
                {
                    con.Open();
                    string sql = "SELECT * FROM login WHERE Username='" + inputusername.Text + "' AND Password='" + inputpassword.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(sql, con); //ให้เเสดงข้อมูลมาว่ามันตรงกับดาต้าเบสไหมถ้าไม่มีมันจะไม่ทำใน loop 
                    MySqlDataReader reader = cmd.ExecuteReader(); 
                    bool check = false; //ถ้ามี
                    while (reader.Read())
                    {
                        Program.fullnameofDB = reader.GetString("Fullname");
                        Program.usernameofDB = reader.GetString("Username"); //เก็บไว้ใส่ห้องเเต่ละห้อง ไม่ว่างเพราะใครจอง
                        check = true;
                    }
                    con.Close();
                    if (check == false) //ไม่ถูกให้เเจ้งเตือน
                    {
                        MessageBox.Show("รหัสไม่ถูกต้อง");
                    }
                    else
                    {
                        MessageBox.Show("คุณได้เข้าสู่ระบบเเล้ว");
                        showusername.Text = string.Format(Program.fullnameofDB);
                        Program.use_login = true;
                    }
                }
                catch 
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการเข้าสู่ระบบ");
                }
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm L = new loginForm(); //ปุ่มสมัครสมาชิก ให้มันเด้งสมัครสมาชิกขึ้นมา
            L.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); // เป็นปุ่มออก
        }

        private void home_Control1_Load(object sender, EventArgs e)
        {

        }

        private void reserve_Click(object sender, EventArgs e)
        {
            if (Program.use_login == false)
            {
                MessageBox.Show("กรุณาเข้าสู่ระบบก่อน");
            }
            else if (Program.use_login == true)
            {
                if (Program.use_select_room == false)
                {
                    llpanel.Height = reserve.Height;
                    llpanel.Top = reserve.Top;
                    userControl11.BringToFront();
                }
                else if (Program.use_select_room == true)
                {
                    MessageBox.Show("คุณเลือกห้องเเล้วไม่สามารถเลือกห้องได้อีก");
                }
            }
        }

        private void payment_Click(object sender, EventArgs e)
        {
            if(Program.use_select_room == true)
            {
                llpanel.Height = payment.Height;
                llpanel.Top = payment.Top;
                billControl21.BringToFront();
            }
            else
            {
                MessageBox.Show("กรุณาเลือกห้องก่อน");
            }
        }

        private void showusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

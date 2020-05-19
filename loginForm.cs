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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("host=localhost;user=test;password=123456;database=sunnee");
            if(fullnametextbox.Text=="" || usernametextbox.Text == "" || passwordtextbox.Text == "" || Teltextbox.Text == "" || emailtextbox.Text == "" || addresstextbox.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "การเเจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);//ถ้าว่างกรอกให้ครบ
            }
            else
            {
                con.Open();
                string sql1 = "SELECT * FROM login WHERE Username='" + usernametextbox.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(sql1, con);
                MySqlDataReader reader = cmd1.ExecuteReader();
                bool check = false; //เอาไว้เป็นตัวเชค ทรูเเสดงว่าข้อมูลซ้ำ f ข้อมูลไม่ซ้ำ
                while (reader.Read())
                {
                    check = true;
                }
                con.Close();
                if (check == true) //เมื่อข้อมูลซ้ำกับดาต้าเบส
                {
                    MessageBox.Show("username ของคุณซ้ำกับคนอื่นกรุณาเปลี่ยนเป็นอันอื่น", "การเเจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);//ถ้าว่างกรอกให้ครบ
                    usernametextbox.Focus();
                }
                else if (check == false)
                {
                    try
                    {
                        con.Open();
                        string sql = "INSERT INTO login(Fullname,Username,Password,Tel,Email,Address) VALUES('" + fullnametextbox.Text + "','" + usernametextbox.Text + "','" + passwordtextbox.Text + "','" + Teltextbox.Text + "','" + emailtextbox.Text + "','" + addresstextbox.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.ExecuteReader();
                        con.Close();
                        okbutton.Enabled = false; //กดข้อมูลเเล้วย้ำokกรอกไม่ได้อีก
                        MessageBox.Show("สมัครเรียบร้อยเเล้ว", "การเเจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch
                    {
                        MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อต่อฐานข้อมูล");
                    }
                }
                    
            }
            
        }

        private void usernametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Teltextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close(); //ออก
        }
    }
}

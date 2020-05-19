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
    public partial class BillControl2 : UserControl
    {
        float monney;
        float yod;
        float ton;
        string userformDB;
        string roomnumberformDB;
        string priceformDB;
        string dateformDB;
         
        public BillControl2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkair.Checked == true)
            {
                allpay.Text = "5300";
                yodtextBox.Text = "5300";
            }
            else
            {
                allpay.Text = "4800";
                yodtextBox.Text = "4800";
            }
        }

        private void BillControl2_Load(object sender, EventArgs e)
        {
            showselectroom.Text = Program.select_room;
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            showselectroom.Text = Program.select_room;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            monney = float.Parse(moneymatextBox.Text);
            yod = float.Parse(yodtextBox.Text);
            if (monney >= yod)
            {
                ton = monney - yod;
                tontextBox.Text = ton.ToString();
                button1.Enabled = false; //ปิดปุ่มคิดเงิน
                moneymatextBox.ReadOnly = true;  
                button2.Enabled = false; //ปุ่มรวมเงิน
                try
                {
                    MySqlConnection con = new MySqlConnection("host=localhost;user=test;password=123456;database=sunnee");
                    con.Open();
                    string sql = "INSERT INTO bill(user,roomnumber,price,date) VALUES('" + Program.usernameofDB + "','" + Program.select_room + "','" + yod.ToString() + "','" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                    //MessageBox.Show(sql);
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("ทำรายการสำเร็จ"); //saveลงใบเสร็จลงเลย 

                    MySqlConnection con1 = new MySqlConnection("host=localhost;user=test;password=123456;database=sunnee");
                    try
                    {
                        con1.Open(); //ดึงข้อมูลขึ้นมาจากdatabase
                        string sql1 = "SELECT * FROM bill WHERE user= '" + Program.usernameofDB + "'";
                        MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
                        MySqlDataReader reader1 = cmd1.ExecuteReader();
                        while (reader1.Read())
                        {
                            userformDB = reader1.GetString("user");
                            roomnumberformDB = reader1.GetString("roomnumber");
                            priceformDB = reader1.GetString("price");
                            dateformDB = reader1.GetString("date");


                        }
                        con1.Close();
                       
                    }
                    catch
                    {
                        MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อข้อมูล"+ex);
                }
            }
            else
            {
                MessageBox.Show("กรุณาจ่ายเงินเพิ่ม");
            }
        }

        private void printbill_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ใบเสร็จรับเงิน", new Font("Microsoft Sans Serif", 24, FontStyle.Bold), Brushes.Black, new PointF(100, 150));  //จากขอบซ้าย 100บน 150
            e.Graphics.DrawString("SunneeDorm", new Font("Microsoft Sans Serif", 24, FontStyle.Bold), Brushes.Black, new PointF(100, 180));  //จากขอบซ้าย 100บน 150
            e.Graphics.DrawString("ชื่อผู้จ่าย " +userformDB, new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 220));
            e.Graphics.DrawString("วันที่จ่าย " +dateformDB, new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 250));
            e.Graphics.DrawString("---------------------------------------------", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 280));  //จากขอบซ้าย 100บน 150
            e.Graphics.DrawString("หมายเลขห้อง  "+roomnumberformDB, new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 310));  //จากขอบซ้าย 100บน 150
            e.Graphics.DrawString("ราคา  "+ priceformDB, new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 340));  //จากขอบซ้าย 100บน 150
            e.Graphics.DrawString("---------------------------------------------", new Font("Microsoft Sans Serif", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 370));  //จากขอบซ้าย 100บน 150
           
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}

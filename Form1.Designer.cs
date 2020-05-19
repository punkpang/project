namespace WindowsFormsApp2
{
    partial class aof
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aof));
            this.panel1 = new System.Windows.Forms.Panel();
            this.showusername = new System.Windows.Forms.TextBox();
            this.llpanel = new System.Windows.Forms.Panel();
            this.payment = new System.Windows.Forms.Button();
            this.reserve = new System.Windows.Forms.Button();
            this.room = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.inputpassword = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.inputusername = new System.Windows.Forms.TextBox();
            this.home_Control1 = new WindowsFormsApp2.Home_Control();
            this.room_Control1 = new WindowsFormsApp2.Room_Control();
            this.userControl11 = new WindowsFormsApp2.UserControl1();
            this.billControl21 = new WindowsFormsApp2.BillControl2();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.showusername);
            this.panel1.Controls.Add(this.llpanel);
            this.panel1.Controls.Add(this.payment);
            this.panel1.Controls.Add(this.reserve);
            this.panel1.Controls.Add(this.room);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 451);
            this.panel1.TabIndex = 0;
            // 
            // showusername
            // 
            this.showusername.Location = new System.Drawing.Point(13, 130);
            this.showusername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showusername.Name = "showusername";
            this.showusername.ReadOnly = true;
            this.showusername.Size = new System.Drawing.Size(116, 20);
            this.showusername.TabIndex = 5;
            this.showusername.Text = "ยังไม่เข้าสู่ระบบ";
            this.showusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.showusername.TextChanged += new System.EventHandler(this.showusername_TextChanged);
            // 
            // llpanel
            // 
            this.llpanel.BackColor = System.Drawing.Color.DarkRed;
            this.llpanel.Location = new System.Drawing.Point(3, 152);
            this.llpanel.Name = "llpanel";
            this.llpanel.Size = new System.Drawing.Size(10, 54);
            this.llpanel.TabIndex = 7;
            // 
            // payment
            // 
            this.payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.payment.ForeColor = System.Drawing.Color.Maroon;
            this.payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payment.Location = new System.Drawing.Point(13, 314);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(127, 54);
            this.payment.TabIndex = 6;
            this.payment.Text = "Payment";
            this.payment.UseVisualStyleBackColor = true;
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // reserve
            // 
            this.reserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.reserve.ForeColor = System.Drawing.Color.Maroon;
            this.reserve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reserve.Location = new System.Drawing.Point(13, 260);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(127, 54);
            this.reserve.TabIndex = 5;
            this.reserve.Text = "reserve a room";
            this.reserve.UseVisualStyleBackColor = true;
            this.reserve.Click += new System.EventHandler(this.reserve_Click);
            // 
            // room
            // 
            this.room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.room.ForeColor = System.Drawing.Color.Maroon;
            this.room.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.room.Location = new System.Drawing.Point(13, 206);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(127, 54);
            this.room.TabIndex = 4;
            this.room.Text = "In room";
            this.room.UseVisualStyleBackColor = true;
            this.room.Click += new System.EventHandler(this.room_Click);
            // 
            // home
            // 
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.home.ForeColor = System.Drawing.Color.Maroon;
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(13, 152);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(127, 54);
            this.home.TabIndex = 3;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(13, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 124);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(23, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "หอพักซันนี่";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "SUNNEE DORM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Pink;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.inputpassword);
            this.panel2.Controls.Add(this.loginbutton);
            this.panel2.Controls.Add(this.inputusername);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 64);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.Location = new System.Drawing.Point(759, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(369, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 20);
            this.button2.TabIndex = 4;
            this.button2.Text = "สมัครสมาชิก";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // inputpassword
            // 
            this.inputpassword.Location = new System.Drawing.Point(219, 42);
            this.inputpassword.Name = "inputpassword";
            this.inputpassword.Size = new System.Drawing.Size(134, 20);
            this.inputpassword.TabIndex = 2;
            this.inputpassword.UseSystemPasswordChar = true;
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.loginbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginbutton.Location = new System.Drawing.Point(369, 8);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(87, 20);
            this.loginbutton.TabIndex = 1;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputusername
            // 
            this.inputusername.Location = new System.Drawing.Point(219, 9);
            this.inputusername.Name = "inputusername";
            this.inputusername.Size = new System.Drawing.Size(134, 20);
            this.inputusername.TabIndex = 0;
            // 
            // home_Control1
            // 
            this.home_Control1.BackColor = System.Drawing.Color.LavenderBlush;
            this.home_Control1.Location = new System.Drawing.Point(138, 61);
            this.home_Control1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.home_Control1.Name = "home_Control1";
            this.home_Control1.Size = new System.Drawing.Size(662, 389);
            this.home_Control1.TabIndex = 3;
            this.home_Control1.Load += new System.EventHandler(this.home_Control1_Load);
            // 
            // room_Control1
            // 
            this.room_Control1.Location = new System.Drawing.Point(157, 69);
            this.room_Control1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.room_Control1.Name = "room_Control1";
            this.room_Control1.Size = new System.Drawing.Size(622, 353);
            this.room_Control1.TabIndex = 4;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(138, 62);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(662, 387);
            this.userControl11.TabIndex = 5;
            // 
            // billControl21
            // 
            this.billControl21.BackColor = System.Drawing.Color.LavenderBlush;
            this.billControl21.Location = new System.Drawing.Point(138, 62);
            this.billControl21.Name = "billControl21";
            this.billControl21.Size = new System.Drawing.Size(662, 387);
            this.billControl21.TabIndex = 6;
            // 
            // aof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.home_Control1);
            this.Controls.Add(this.room_Control1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.billControl21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "aof";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox inputusername;
        private Home_Control home_Control1;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button payment;
        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.Button room;
        private System.Windows.Forms.Panel llpanel;
        private Room_Control room_Control1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox showusername;
        private UserControl1 userControl11;
        private BillControl2 billControl21;
    }
}


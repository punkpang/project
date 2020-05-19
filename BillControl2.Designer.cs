namespace WindowsFormsApp2
{
    partial class BillControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillControl2));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.showselectroom = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkair = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.allpay = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.printbill = new System.Windows.Forms.Button();
            this.tontextBox = new System.Windows.Forms.TextBox();
            this.yodtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.moneymatextBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ห้อง";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.refreshbutton);
            this.panel1.Controls.Add(this.showselectroom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 55);
            this.panel1.TabIndex = 3;
            // 
            // refreshbutton
            // 
            this.refreshbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbutton.Location = new System.Drawing.Point(244, 24);
            this.refreshbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(59, 21);
            this.refreshbutton.TabIndex = 51;
            this.refreshbutton.Text = "รีเฟรชข้อมูล";
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // showselectroom
            // 
            this.showselectroom.Location = new System.Drawing.Point(70, 24);
            this.showselectroom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showselectroom.Name = "showselectroom";
            this.showselectroom.ReadOnly = true;
            this.showselectroom.Size = new System.Drawing.Size(170, 20);
            this.showselectroom.TabIndex = 3;
            this.showselectroom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.checkair);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.allpay);
            this.panel2.Location = new System.Drawing.Point(17, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 228);
            this.panel2.TabIndex = 4;
            // 
            // checkair
            // 
            this.checkair.AutoSize = true;
            this.checkair.Location = new System.Drawing.Point(21, 60);
            this.checkair.Name = "checkair";
            this.checkair.Size = new System.Drawing.Size(66, 17);
            this.checkair.TabIndex = 6;
            this.checkair.Text = "ห้องเเอร์";
            this.checkair.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(49, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "ค่าใช้จ่ายประจำเดือน";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "รวม";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // allpay
            // 
            this.allpay.Location = new System.Drawing.Point(53, 93);
            this.allpay.Name = "allpay";
            this.allpay.ReadOnly = true;
            this.allpay.Size = new System.Drawing.Size(100, 20);
            this.allpay.TabIndex = 3;
            this.allpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Linen;
            this.panel3.Controls.Add(this.printbill);
            this.panel3.Controls.Add(this.tontextBox);
            this.panel3.Controls.Add(this.yodtextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.moneymatextBox);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(261, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 279);
            this.panel3.TabIndex = 5;
            // 
            // printbill
            // 
            this.printbill.Location = new System.Drawing.Point(117, 230);
            this.printbill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.printbill.Name = "printbill";
            this.printbill.Size = new System.Drawing.Size(73, 23);
            this.printbill.TabIndex = 18;
            this.printbill.Text = "ใบเสร็จ";
            this.printbill.UseVisualStyleBackColor = true;
            this.printbill.Click += new System.EventHandler(this.printbill_Click);
            // 
            // tontextBox
            // 
            this.tontextBox.Location = new System.Drawing.Point(117, 194);
            this.tontextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tontextBox.Name = "tontextBox";
            this.tontextBox.ReadOnly = true;
            this.tontextBox.Size = new System.Drawing.Size(127, 20);
            this.tontextBox.TabIndex = 17;
            // 
            // yodtextBox
            // 
            this.yodtextBox.Location = new System.Drawing.Point(117, 144);
            this.yodtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yodtextBox.Name = "yodtextBox";
            this.yodtextBox.ReadOnly = true;
            this.yodtextBox.Size = new System.Drawing.Size(127, 20);
            this.yodtextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "เงินทอน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ยอดชำระ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "จำนวนเงินที่รับมา";
            // 
            // moneymatextBox
            // 
            this.moneymatextBox.Location = new System.Drawing.Point(117, 85);
            this.moneymatextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moneymatextBox.Name = "moneymatextBox";
            this.moneymatextBox.Size = new System.Drawing.Size(127, 20);
            this.moneymatextBox.TabIndex = 12;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 49);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "จ่ายเงินสด";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "เลือกช่องทางการชำระเงิน";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // BillControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BillControl2";
            this.Size = new System.Drawing.Size(653, 367);
            this.Load += new System.EventHandler(this.BillControl2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox allpay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox showselectroom;
        private System.Windows.Forms.CheckBox checkair;
        private System.Windows.Forms.TextBox tontextBox;
        private System.Windows.Forms.TextBox yodtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox moneymatextBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button refreshbutton;
        private System.Windows.Forms.Button printbill;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

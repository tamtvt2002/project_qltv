namespace GUI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Reader_manage = new System.Windows.Forms.Label();
            this.btn_BookManage = new System.Windows.Forms.Label();
            this.btnBorrowBook = new System.Windows.Forms.Label();
            this.btn_Statistic = new System.Windows.Forms.Label();
            this.lbl_NameUser = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Reader_manage
            // 
            this.btn_Reader_manage.AutoSize = true;
            this.btn_Reader_manage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(63)))), ((int)(((byte)(111)))));
            this.btn_Reader_manage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reader_manage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Reader_manage.ForeColor = System.Drawing.Color.White;
            this.btn_Reader_manage.Location = new System.Drawing.Point(31, 123);
            this.btn_Reader_manage.Name = "btn_Reader_manage";
            this.btn_Reader_manage.Size = new System.Drawing.Size(135, 23);
            this.btn_Reader_manage.TabIndex = 1;
            this.btn_Reader_manage.Text = "Quản lý độc giả";
            this.btn_Reader_manage.Click += new System.EventHandler(this.btn_Reader_manage_Click);
            this.btn_Reader_manage.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.btn_Reader_manage.MouseLeave += new System.EventHandler(this.btn_Reader_manage_MouseLeave);
            // 
            // btn_BookManage
            // 
            this.btn_BookManage.AutoSize = true;
            this.btn_BookManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(63)))), ((int)(((byte)(111)))));
            this.btn_BookManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BookManage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BookManage.ForeColor = System.Drawing.Color.White;
            this.btn_BookManage.Location = new System.Drawing.Point(260, 123);
            this.btn_BookManage.Name = "btn_BookManage";
            this.btn_BookManage.Size = new System.Drawing.Size(110, 23);
            this.btn_BookManage.TabIndex = 2;
            this.btn_BookManage.Text = "Quản lý sách";
            this.btn_BookManage.Click += new System.EventHandler(this.btn_BookManage_Click);
            this.btn_BookManage.MouseEnter += new System.EventHandler(this.btn_BookManage_MouseEnter);
            this.btn_BookManage.MouseLeave += new System.EventHandler(this.btn_BookManage_MouseLeave);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.AutoSize = true;
            this.btnBorrowBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(63)))), ((int)(((byte)(111)))));
            this.btnBorrowBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrowBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrowBook.ForeColor = System.Drawing.Color.White;
            this.btnBorrowBook.Location = new System.Drawing.Point(489, 123);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(125, 23);
            this.btnBorrowBook.TabIndex = 3;
            this.btnBorrowBook.Text = "Mượn trả sách";
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            this.btnBorrowBook.MouseEnter += new System.EventHandler(this.btnBorrowBook_MouseEnter);
            this.btnBorrowBook.MouseLeave += new System.EventHandler(this.btnBorrowBook_MouseLeave);
            // 
            // btn_Statistic
            // 
            this.btn_Statistic.AutoSize = true;
            this.btn_Statistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(63)))), ((int)(((byte)(111)))));
            this.btn_Statistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Statistic.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Statistic.ForeColor = System.Drawing.Color.White;
            this.btn_Statistic.Location = new System.Drawing.Point(718, 123);
            this.btn_Statistic.Name = "btn_Statistic";
            this.btn_Statistic.Size = new System.Drawing.Size(149, 23);
            this.btn_Statistic.TabIndex = 4;
            this.btn_Statistic.Text = "Báo cáo thống kê";
            this.btn_Statistic.Click += new System.EventHandler(this.btn_Statistic_Click);
            this.btn_Statistic.MouseEnter += new System.EventHandler(this.btn_Statistic_MouseEnter);
            this.btn_Statistic.MouseLeave += new System.EventHandler(this.btn_Statistic_MouseLeave);
            // 
            // lbl_NameUser
            // 
            this.lbl_NameUser.AutoSize = true;
            this.lbl_NameUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(63)))), ((int)(((byte)(111)))));
            this.lbl_NameUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_NameUser.ForeColor = System.Drawing.Color.White;
            this.lbl_NameUser.Location = new System.Drawing.Point(728, 26);
            this.lbl_NameUser.Name = "lbl_NameUser";
            this.lbl_NameUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_NameUser.Size = new System.Drawing.Size(43, 23);
            this.lbl_NameUser.TabIndex = 5;
            this.lbl_NameUser.Text = "user";
            this.lbl_NameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_NameUser.Click += new System.EventHandler(this.lbl_NameUser_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(743, 69);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 518);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl_NameUser);
            this.Controls.Add(this.btn_Statistic);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.btn_BookManage);
            this.Controls.Add(this.btn_Reader_manage);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label btn_Reader_manage;
        private Label btn_BookManage;
        private Label btnBorrowBook;
        private Label btn_Statistic;
        private Label lbl_NameUser;
        private Label btnExit;
    }
}
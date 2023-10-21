namespace GUI
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_signUp = new System.Windows.Forms.Label();
            this.lbl_facebook = new System.Windows.Forms.Label();
            this.lbl_Google = new System.Windows.Forms.Label();
            this.txt_nameAccount = new System.Windows.Forms.TextBox();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.txt_fullName = new System.Windows.Forms.TextBox();
            this.txt_repeatAccount = new System.Windows.Forms.TextBox();
            this.txt_passAccount = new System.Windows.Forms.TextBox();
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
            // lbl_signUp
            // 
            this.lbl_signUp.AutoSize = true;
            this.lbl_signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(147)))), ((int)(((byte)(205)))));
            this.lbl_signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_signUp.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_signUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_signUp.Location = new System.Drawing.Point(564, 324);
            this.lbl_signUp.Name = "lbl_signUp";
            this.lbl_signUp.Size = new System.Drawing.Size(200, 31);
            this.lbl_signUp.TabIndex = 8;
            this.lbl_signUp.Text = "Hoàn tất đăng ký";
            this.lbl_signUp.Click += new System.EventHandler(this.lbl_signUp_Click);
            this.lbl_signUp.MouseEnter += new System.EventHandler(this.lbl_signUp_MouseEnter);
            this.lbl_signUp.MouseLeave += new System.EventHandler(this.lbl_signUp_MouseLeave);
            // 
            // lbl_facebook
            // 
            this.lbl_facebook.AutoSize = true;
            this.lbl_facebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(87)))), ((int)(((byte)(176)))));
            this.lbl_facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_facebook.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_facebook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_facebook.Location = new System.Drawing.Point(531, 409);
            this.lbl_facebook.Name = "lbl_facebook";
            this.lbl_facebook.Size = new System.Drawing.Size(85, 23);
            this.lbl_facebook.TabIndex = 9;
            this.lbl_facebook.Text = "Facebook";
            this.lbl_facebook.MouseEnter += new System.EventHandler(this.lbl_facebook_MouseEnter);
            this.lbl_facebook.MouseLeave += new System.EventHandler(this.lbl_facebook_MouseLeave);
            // 
            // lbl_Google
            // 
            this.lbl_Google.AutoSize = true;
            this.lbl_Google.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lbl_Google.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Google.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Google.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Google.Location = new System.Drawing.Point(751, 409);
            this.lbl_Google.Name = "lbl_Google";
            this.lbl_Google.Size = new System.Drawing.Size(67, 23);
            this.lbl_Google.TabIndex = 10;
            this.lbl_Google.Text = "Google";
            this.lbl_Google.MouseEnter += new System.EventHandler(this.lbl_Google_MouseEnter);
            this.lbl_Google.MouseLeave += new System.EventHandler(this.lbl_Google_MouseLeave);
            // 
            // txt_nameAccount
            // 
            this.txt_nameAccount.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nameAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nameAccount.ForeColor = System.Drawing.Color.Gray;
            this.txt_nameAccount.Location = new System.Drawing.Point(513, 82);
            this.txt_nameAccount.Name = "txt_nameAccount";
            this.txt_nameAccount.Size = new System.Drawing.Size(305, 30);
            this.txt_nameAccount.TabIndex = 12;
            this.txt_nameAccount.Text = "Tên tài khoản";
            this.txt_nameAccount.Click += new System.EventHandler(this.txt_nameAccount_Click);
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.txt_phoneNumber.Location = new System.Drawing.Point(513, 262);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(305, 30);
            this.txt_phoneNumber.TabIndex = 13;
            this.txt_phoneNumber.Text = "Số điện thoại";
            this.txt_phoneNumber.Click += new System.EventHandler(this.txt_phoneNumber_Click);
            // 
            // txt_class
            // 
            this.txt_class.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_class.ForeColor = System.Drawing.Color.Gray;
            this.txt_class.Location = new System.Drawing.Point(513, 226);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(305, 30);
            this.txt_class.TabIndex = 14;
            this.txt_class.Text = "Lớp hoặc chức vụ";
            this.txt_class.Click += new System.EventHandler(this.txt_class_Click);
            // 
            // txt_fullName
            // 
            this.txt_fullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fullName.ForeColor = System.Drawing.Color.Gray;
            this.txt_fullName.Location = new System.Drawing.Point(513, 190);
            this.txt_fullName.Name = "txt_fullName";
            this.txt_fullName.Size = new System.Drawing.Size(305, 30);
            this.txt_fullName.TabIndex = 15;
            this.txt_fullName.Text = "Họ và tên";
            this.txt_fullName.Click += new System.EventHandler(this.txt_fullName_Click);
            // 
            // txt_repeatAccount
            // 
            this.txt_repeatAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_repeatAccount.ForeColor = System.Drawing.Color.Gray;
            this.txt_repeatAccount.Location = new System.Drawing.Point(513, 154);
            this.txt_repeatAccount.Name = "txt_repeatAccount";
            this.txt_repeatAccount.Size = new System.Drawing.Size(305, 30);
            this.txt_repeatAccount.TabIndex = 16;
            this.txt_repeatAccount.Text = "Nhập lại mật khẩu";
            this.txt_repeatAccount.Click += new System.EventHandler(this.txt_repeatAccount_Click);
            // 
            // txt_passAccount
            // 
            this.txt_passAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_passAccount.ForeColor = System.Drawing.Color.Gray;
            this.txt_passAccount.Location = new System.Drawing.Point(513, 118);
            this.txt_passAccount.Name = "txt_passAccount";
            this.txt_passAccount.Size = new System.Drawing.Size(305, 30);
            this.txt_passAccount.TabIndex = 17;
            this.txt_passAccount.Text = "Mật khẩu";
            this.txt_passAccount.Click += new System.EventHandler(this.txt_passAccount_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 518);
            this.Controls.Add(this.txt_passAccount);
            this.Controls.Add(this.txt_repeatAccount);
            this.Controls.Add(this.txt_fullName);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.txt_nameAccount);
            this.Controls.Add(this.lbl_Google);
            this.Controls.Add(this.lbl_facebook);
            this.Controls.Add(this.lbl_signUp);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUp_FormClosing);
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_signUp;
        private Label lbl_facebook;
        private Label lbl_Google;
        private TextBox txt_nameAccount;
        private TextBox txt_phoneNumber;
        private TextBox txt_class;
        private TextBox txt_fullName;
        private TextBox txt_repeatAccount;
        private TextBox txt_passAccount;
    }
}
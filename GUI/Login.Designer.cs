namespace GUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            txt_name = new TextBox();
            txt_pass = new TextBox();
            checkBoxPass = new CheckBox();
            lb_Login = new Label();
            lbl_facebook = new Label();
            lbl_Google = new Label();
            lbl_signUp = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(900, 518);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txt_name
            // 
            txt_name.BorderStyle = BorderStyle.FixedSingle;
            txt_name.ForeColor = Color.Gray;
            txt_name.Location = new Point(71, 21);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(263, 25);
            txt_name.TabIndex = 1;
            txt_name.Text = "Tài khoản";
            txt_name.Click += txt_name_Click;
            // 
            // txt_pass
            // 
            txt_pass.BorderStyle = BorderStyle.FixedSingle;
            txt_pass.ForeColor = Color.Gray;
            txt_pass.Location = new Point(71, 70);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(263, 25);
            txt_pass.TabIndex = 2;
            txt_pass.Text = "Mật khẩu";
            txt_pass.Click += txt_pass_Click;
            txt_pass.TextChanged += txt_pass_TextChanged;
            // 
            // checkBoxPass
            // 
            checkBoxPass.AutoSize = true;
            checkBoxPass.Cursor = Cursors.Hand;
            checkBoxPass.Location = new Point(71, 133);
            checkBoxPass.Name = "checkBoxPass";
            checkBoxPass.Size = new Size(15, 14);
            checkBoxPass.TabIndex = 3;
            checkBoxPass.UseVisualStyleBackColor = true;
            checkBoxPass.CheckedChanged += checkBoxPass_CheckedChanged;
            // 
            // lb_Login
            // 
            lb_Login.AutoSize = true;
            lb_Login.BackColor = Color.FromArgb(55, 147, 205);
            lb_Login.Cursor = Cursors.Hand;
            lb_Login.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Login.ForeColor = SystemColors.ButtonFace;
            lb_Login.Location = new Point(118, 200);
            lb_Login.Name = "lb_Login";
            lb_Login.Size = new Size(110, 25);
            lb_Login.TabIndex = 4;
            lb_Login.Text = "Đăng nhập";
            lb_Login.Click += lb_Login_Click;
            lb_Login.MouseEnter += lb_Login_MouseEnter;
            lb_Login.MouseLeave += lb_Login_MouseLeave;
            // 
            // lbl_facebook
            // 
            lbl_facebook.AutoSize = true;
            lbl_facebook.BackColor = Color.FromArgb(27, 87, 176);
            lbl_facebook.Cursor = Cursors.Hand;
            lbl_facebook.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_facebook.ForeColor = SystemColors.ButtonHighlight;
            lbl_facebook.Location = new Point(564, 387);
            lbl_facebook.Name = "lbl_facebook";
            lbl_facebook.Size = new Size(74, 19);
            lbl_facebook.TabIndex = 5;
            lbl_facebook.Text = "Facebook";
            lbl_facebook.MouseEnter += lbl_facebook_MouseEnter;
            lbl_facebook.MouseLeave += lbl_facebook_MouseLeave;
            // 
            // lbl_Google
            // 
            lbl_Google.AutoSize = true;
            lbl_Google.BackColor = Color.FromArgb(255, 49, 49);
            lbl_Google.Cursor = Cursors.Hand;
            lbl_Google.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Google.ForeColor = SystemColors.ButtonHighlight;
            lbl_Google.Location = new Point(775, 387);
            lbl_Google.Name = "lbl_Google";
            lbl_Google.Size = new Size(58, 19);
            lbl_Google.TabIndex = 6;
            lbl_Google.Text = "Google";
            lbl_Google.MouseEnter += lbl_Google_MouseEnter;
            lbl_Google.MouseLeave += lbl_Google_MouseLeave;
            // 
            // lbl_signUp
            // 
            lbl_signUp.AutoSize = true;
            lbl_signUp.BackColor = Color.FromArgb(55, 147, 205);
            lbl_signUp.Cursor = Cursors.Hand;
            lbl_signUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_signUp.ForeColor = SystemColors.ButtonFace;
            lbl_signUp.Location = new Point(131, 282);
            lbl_signUp.Name = "lbl_signUp";
            lbl_signUp.Size = new Size(86, 25);
            lbl_signUp.TabIndex = 7;
            lbl_signUp.Text = "Đăng ký";
            lbl_signUp.Click += lbl_signUp_Click;
            lbl_signUp.MouseEnter += lbl_signUp_MouseEnter;
            lbl_signUp.MouseLeave += lbl_signUp_MouseLeave;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbl_signUp);
            panel1.Controls.Add(lb_Login);
            panel1.Controls.Add(checkBoxPass);
            panel1.Controls.Add(txt_pass);
            panel1.Controls.Add(txt_name);
            panel1.Location = new Point(502, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 394);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 239);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 8;
            label2.Text = "Hoặc";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 128);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 8;
            label1.Text = "Hiện Mật Khẩu";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(panel1);
            Controls.Add(lbl_Google);
            Controls.Add(lbl_facebook);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_name;
        private TextBox txt_pass;
        private CheckBox checkBoxPass;
        private Label lb_Login;
        private Label lbl_facebook;
        private Label lbl_Google;
        private Label lbl_signUp;
        private Panel panel1;
        private Label label2;
        private Label label1;
    }
}
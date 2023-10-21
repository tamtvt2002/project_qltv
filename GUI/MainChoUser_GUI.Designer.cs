namespace GUI
{
    partial class MainChoUser_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainChoUser_GUI));
            this.btn_user = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Label();
            this.lbl_NameUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_user
            // 
            this.btn_user.AutoSize = true;
            this.btn_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(63)))), ((int)(((byte)(111)))));
            this.btn_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_user.ForeColor = System.Drawing.Color.White;
            this.btn_user.Location = new System.Drawing.Point(370, 123);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(109, 23);
            this.btn_user.TabIndex = 15;
            this.btn_user.Text = "Sách hiện có";
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
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
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.lbl_NameUser.TabIndex = 13;
            this.lbl_NameUser.Text = "user";
            this.lbl_NameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MainChoUser_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 518);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl_NameUser);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MainChoUser_GUI";
            this.Text = "MainChoUser_GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainChoUser_GUI_FormClosing);
            this.Load += new System.EventHandler(this.MainChoUser_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label btn_user;
        private Label btnExit;
        private Label lbl_NameUser;
        private PictureBox pictureBox1;
    }
}
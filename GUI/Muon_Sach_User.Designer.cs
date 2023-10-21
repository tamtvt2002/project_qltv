namespace GUI
{
    partial class Muon_Sach_User
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.txt_NameBook = new System.Windows.Forms.TextBox();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.txt_DateBorrow = new System.Windows.Forms.TextBox();
            this.txt_DateReturn = new System.Windows.Forms.TextBox();
            this.txt_IdBook = new System.Windows.Forms.TextBox();
            this.txt_Class = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_NameReader = new System.Windows.Forms.TextBox();
            this.txt_IdReader = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_IdBorrowCard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Exit);
            this.groupBox1.Controls.Add(this.btn_Confirm);
            this.groupBox1.Controls.Add(this.txt_NameBook);
            this.groupBox1.Controls.Add(this.txt_Category);
            this.groupBox1.Controls.Add(this.txt_DateBorrow);
            this.groupBox1.Controls.Add(this.txt_DateReturn);
            this.groupBox1.Controls.Add(this.txt_IdBook);
            this.groupBox1.Controls.Add(this.txt_Class);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.txt_NameReader);
            this.groupBox1.Controls.Add(this.txt_IdReader);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 420);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(505, 280);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(146, 44);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(227, 280);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(146, 44);
            this.btn_Confirm.TabIndex = 10;
            this.btn_Confirm.Text = "Xác nhận";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // txt_NameBook
            // 
            this.txt_NameBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NameBook.Location = new System.Drawing.Point(525, 47);
            this.txt_NameBook.Name = "txt_NameBook";
            this.txt_NameBook.PlaceholderText = "Tên sách";
            this.txt_NameBook.ReadOnly = true;
            this.txt_NameBook.Size = new System.Drawing.Size(262, 30);
            this.txt_NameBook.TabIndex = 9;
            // 
            // txt_Category
            // 
            this.txt_Category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Category.Location = new System.Drawing.Point(525, 99);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.PlaceholderText = "Thể loại";
            this.txt_Category.ReadOnly = true;
            this.txt_Category.Size = new System.Drawing.Size(262, 30);
            this.txt_Category.TabIndex = 8;
            // 
            // txt_DateBorrow
            // 
            this.txt_DateBorrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DateBorrow.Location = new System.Drawing.Point(525, 151);
            this.txt_DateBorrow.Name = "txt_DateBorrow";
            this.txt_DateBorrow.PlaceholderText = "Ngày mượn";
            this.txt_DateBorrow.Size = new System.Drawing.Size(262, 30);
            this.txt_DateBorrow.TabIndex = 7;
            // 
            // txt_DateReturn
            // 
            this.txt_DateReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DateReturn.Location = new System.Drawing.Point(525, 203);
            this.txt_DateReturn.Name = "txt_DateReturn";
            this.txt_DateReturn.PlaceholderText = "Ngày trả";
            this.txt_DateReturn.Size = new System.Drawing.Size(262, 30);
            this.txt_DateReturn.TabIndex = 6;
            // 
            // txt_IdBook
            // 
            this.txt_IdBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdBook.Location = new System.Drawing.Point(104, 203);
            this.txt_IdBook.Name = "txt_IdBook";
            this.txt_IdBook.PlaceholderText = "Mã Sách";
            this.txt_IdBook.ReadOnly = true;
            this.txt_IdBook.Size = new System.Drawing.Size(269, 30);
            this.txt_IdBook.TabIndex = 4;
            this.txt_IdBook.TextChanged += new System.EventHandler(this.txt_IdBook_TextChanged);
            // 
            // txt_Class
            // 
            this.txt_Class.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Class.Location = new System.Drawing.Point(104, 151);
            this.txt_Class.Name = "txt_Class";
            this.txt_Class.PlaceholderText = "Lớp";
            this.txt_Class.ReadOnly = true;
            this.txt_Class.Size = new System.Drawing.Size(128, 30);
            this.txt_Class.TabIndex = 3;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Location = new System.Drawing.Point(238, 151);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PlaceholderText = "Số điện thoại";
            this.txt_SDT.ReadOnly = true;
            this.txt_SDT.Size = new System.Drawing.Size(135, 30);
            this.txt_SDT.TabIndex = 2;
            // 
            // txt_NameReader
            // 
            this.txt_NameReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NameReader.Location = new System.Drawing.Point(104, 99);
            this.txt_NameReader.Name = "txt_NameReader";
            this.txt_NameReader.PlaceholderText = "Họ tên";
            this.txt_NameReader.ReadOnly = true;
            this.txt_NameReader.Size = new System.Drawing.Size(269, 30);
            this.txt_NameReader.TabIndex = 1;
            // 
            // txt_IdReader
            // 
            this.txt_IdReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_IdReader.Location = new System.Drawing.Point(104, 47);
            this.txt_IdReader.Name = "txt_IdReader";
            this.txt_IdReader.PlaceholderText = "Mã đọc giả";
            this.txt_IdReader.ReadOnly = true;
            this.txt_IdReader.Size = new System.Drawing.Size(269, 30);
            this.txt_IdReader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_IdBorrowCard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 97);
            this.panel1.TabIndex = 2;
            // 
            // lbl_IdBorrowCard
            // 
            this.lbl_IdBorrowCard.AutoSize = true;
            this.lbl_IdBorrowCard.Location = new System.Drawing.Point(674, 58);
            this.lbl_IdBorrowCard.Name = "lbl_IdBorrowCard";
            this.lbl_IdBorrowCard.Size = new System.Drawing.Size(82, 23);
            this.lbl_IdBorrowCard.TabIndex = 1;
            this.lbl_IdBorrowCard.Text = "Mã phiếu";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Mượn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Muon_Sach_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "Muon_Sach_User";
            this.Text = "Muon_Sach_User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Muon_Sach_User_FormClosing);
            this.Load += new System.EventHandler(this.Muon_Sach_User_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_Exit;
        private Button btn_Confirm;
        private TextBox txt_NameBook;
        private TextBox txt_Category;
        private TextBox txt_DateBorrow;
        private TextBox txt_DateReturn;
        private TextBox txt_IdBook;
        private TextBox txt_Class;
        private TextBox txt_SDT;
        private TextBox txt_NameReader;
        private TextBox txt_IdReader;
        private Panel panel1;
        private Label lbl_IdBorrowCard;
        private Label label1;
    }
}
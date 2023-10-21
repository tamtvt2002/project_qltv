namespace GUI
{
    partial class Main_user
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btn_Exit = new Button();
            btn_Borrow = new Button();
            btn_Search = new Button();
            txt_Search = new TextBox();
            splitter1 = new Splitter();
            groupBox2 = new GroupBox();
            lv_ListBook = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ImeMode = ImeMode.Off;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(908, 77);
            label1.TabIndex = 0;
            label1.Text = "Danh sách sách trong thư viện";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Exit);
            groupBox1.Controls.Add(btn_Borrow);
            groupBox1.Controls.Add(btn_Search);
            groupBox1.Controls.Add(txt_Search);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(908, 106);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(708, 47);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 4;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Borrow
            // 
            btn_Borrow.Location = new Point(590, 47);
            btn_Borrow.Name = "btn_Borrow";
            btn_Borrow.Size = new Size(94, 29);
            btn_Borrow.TabIndex = 3;
            btn_Borrow.Text = "Mượn";
            btn_Borrow.UseVisualStyleBackColor = true;
            btn_Borrow.Click += btn_Borrow_Click;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(472, 47);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(94, 29);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "Tìm kiếm";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_Search
            // 
            txt_Search.BorderStyle = BorderStyle.FixedSingle;
            txt_Search.Location = new Point(33, 46);
            txt_Search.Name = "txt_Search";
            txt_Search.PlaceholderText = "Nhập thông tin ( Tên sách hoặc Mã sách )";
            txt_Search.Size = new Size(415, 30);
            txt_Search.TabIndex = 1;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 183);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(908, 10);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lv_ListBook);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(908, 325);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // lv_ListBook
            // 
            lv_ListBook.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lv_ListBook.Dock = DockStyle.Top;
            lv_ListBook.FullRowSelect = true;
            lv_ListBook.GridLines = true;
            lv_ListBook.Location = new Point(3, 26);
            lv_ListBook.Name = "lv_ListBook";
            lv_ListBook.Size = new Size(902, 300);
            lv_ListBook.TabIndex = 0;
            lv_ListBook.UseCompatibleStateImageBehavior = false;
            lv_ListBook.View = View.Details;
            lv_ListBook.SelectedIndexChanged += lv_ListBook_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã sách";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên sách";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên tác giả";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tên NXB";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Năm XB";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Thể loại";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Số lượng còn";
            columnHeader7.Width = 120;
            // 
            // Main_user
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(groupBox2);
            Controls.Add(splitter1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.On;
            MaximizeBox = false;
            Name = "Main_user";
            Text = "Main_user";
            FormClosing += Main_user_FormClosing;
            Load += Main_user_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btn_Borrow;
        private Button btn_Search;
        private TextBox txt_Search;
        private Splitter splitter1;
        private GroupBox groupBox2;
        private ListView lv_ListBook;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button btn_Exit;
    }
}
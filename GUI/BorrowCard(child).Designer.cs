namespace GUI
{
    partial class BorrowCard_child_
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
            lsv_Book = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            txt_search = new TextBox();
            btn_Search = new Button();
            txt_amount = new TextBox();
            label1 = new Label();
            ptb_Back = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_Back).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lsv_Book
            // 
            lsv_Book.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lsv_Book.Dock = DockStyle.Fill;
            lsv_Book.FullRowSelect = true;
            lsv_Book.GridLines = true;
            lsv_Book.Location = new Point(3, 21);
            lsv_Book.Name = "lsv_Book";
            lsv_Book.Size = new Size(674, 294);
            lsv_Book.TabIndex = 0;
            lsv_Book.UseCompatibleStateImageBehavior = false;
            lsv_Book.View = View.Details;
            lsv_Book.SelectedIndexChanged += lsv_Book_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã sách";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên sách";
            columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Tên NXB";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Năm XB";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tác giả";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Thể loại";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tồn kho";
            columnHeader7.Width = 80;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsv_Book);
            groupBox1.Location = new Point(103, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 318);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(697, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 44);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Xác Nhận";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txt_search
            // 
            txt_search.BorderStyle = BorderStyle.FixedSingle;
            txt_search.Location = new Point(26, 36);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(235, 25);
            txt_search.TabIndex = 4;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(277, 36);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(105, 25);
            btn_Search.TabIndex = 5;
            btn_Search.Text = "Tìm kiếm";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_amount
            // 
            txt_amount.BorderStyle = BorderStyle.FixedSingle;
            txt_amount.Location = new Point(557, 36);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(80, 25);
            txt_amount.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(436, 40);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 7;
            label1.Text = "Nhập số lượng";
            // 
            // ptb_Back
            // 
            ptb_Back.Image = Properties.Resources.ic_back;
            ptb_Back.Location = new Point(854, 0);
            ptb_Back.Name = "ptb_Back";
            ptb_Back.Size = new Size(38, 36);
            ptb_Back.SizeMode = PictureBoxSizeMode.StretchImage;
            ptb_Back.TabIndex = 8;
            ptb_Back.TabStop = false;
            ptb_Back.Click += ptb_Back_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkTurquoise;
            panel1.Controls.Add(txt_search);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(ptb_Back);
            panel1.Controls.Add(btn_Search);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_amount);
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 100);
            panel1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 0, 192);
            label2.Location = new Point(341, 130);
            label2.Name = "label2";
            label2.Size = new Size(215, 23);
            label2.TabIndex = 10;
            label2.Text = "Chọn sách muốn mượn";
            // 
            // BorrowCard_child_
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 523);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorrowCard_child_";
            Text = "BorrowCard_child_";
            Load += BorrowCard_child__Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptb_Back).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsv_Book;
        private GroupBox groupBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnAdd;
        private ColumnHeader columnHeader7;
        private TextBox txt_search;
        private Button btn_Search;
        private TextBox txt_amount;
        private Label label1;
        private PictureBox ptb_Back;
        private Panel panel1;
        private Label label2;
    }
}
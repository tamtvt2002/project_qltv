namespace GUI
{
    partial class Report
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
            btn_ToExcel = new Button();
            btn_Exit = new Button();
            cb_BookReturn = new RadioButton();
            cb_Reader = new RadioButton();
            cb_BookLate = new RadioButton();
            cb_BorrowBook = new RadioButton();
            btn_Report = new Button();
            splitter1 = new Splitter();
            lv_Report = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            lbl_SumNumber = new Label();
            lv_Acc = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            txtBookName = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 105);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(900, 105);
            label1.TabIndex = 0;
            label1.Text = "Báo cáo thống kê";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_ToExcel);
            groupBox1.Controls.Add(btn_Exit);
            groupBox1.Controls.Add(cb_BookReturn);
            groupBox1.Controls.Add(cb_Reader);
            groupBox1.Controls.Add(cb_BookLate);
            groupBox1.Controls.Add(cb_BorrowBook);
            groupBox1.Controls.Add(btn_Report);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 172);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tùy chọn thống kê";
            // 
            // btn_ToExcel
            // 
            btn_ToExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ToExcel.Location = new Point(537, 29);
            btn_ToExcel.Name = "btn_ToExcel";
            btn_ToExcel.Size = new Size(169, 51);
            btn_ToExcel.TabIndex = 10;
            btn_ToExcel.Text = "Xuất file Excel";
            btn_ToExcel.UseVisualStyleBackColor = true;
            btn_ToExcel.Click += btn_ToExcel_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exit.Location = new Point(692, 104);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(117, 51);
            btn_Exit.TabIndex = 9;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // cb_BookReturn
            // 
            cb_BookReturn.AutoSize = true;
            cb_BookReturn.Location = new Point(169, 128);
            cb_BookReturn.Name = "cb_BookReturn";
            cb_BookReturn.Size = new Size(117, 27);
            cb_BookReturn.TabIndex = 8;
            cb_BookReturn.TabStop = true;
            cb_BookReturn.Text = "Sách đã trả";
            cb_BookReturn.UseVisualStyleBackColor = true;
            // 
            // cb_Reader
            // 
            cb_Reader.AutoSize = true;
            cb_Reader.Location = new Point(169, 95);
            cb_Reader.Name = "cb_Reader";
            cb_Reader.Size = new Size(103, 27);
            cb_Reader.TabIndex = 7;
            cb_Reader.TabStop = true;
            cb_Reader.Text = "Tài khoản";
            cb_Reader.UseVisualStyleBackColor = true;
            // 
            // cb_BookLate
            // 
            cb_BookLate.AutoSize = true;
            cb_BookLate.Location = new Point(169, 62);
            cb_BookLate.Name = "cb_BookLate";
            cb_BookLate.Size = new Size(127, 27);
            cb_BookLate.TabIndex = 6;
            cb_BookLate.TabStop = true;
            cb_BookLate.Text = "Sách trễ hạn";
            cb_BookLate.UseVisualStyleBackColor = true;
            // 
            // cb_BorrowBook
            // 
            cb_BorrowBook.AutoSize = true;
            cb_BorrowBook.Location = new Point(169, 29);
            cb_BorrowBook.Name = "cb_BorrowBook";
            cb_BorrowBook.Size = new Size(194, 27);
            cb_BorrowBook.TabIndex = 5;
            cb_BorrowBook.TabStop = true;
            cb_BorrowBook.Text = "Sách đang cho mượn";
            cb_BorrowBook.UseVisualStyleBackColor = true;
            // 
            // btn_Report
            // 
            btn_Report.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Report.Location = new Point(537, 104);
            btn_Report.Name = "btn_Report";
            btn_Report.Size = new Size(117, 51);
            btn_Report.TabIndex = 4;
            btn_Report.Text = "Thống kê";
            btn_Report.UseVisualStyleBackColor = true;
            btn_Report.Click += btn_Report_Click;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 277);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(900, 4);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // lv_Report
            // 
            lv_Report.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lv_Report.Dock = DockStyle.Bottom;
            lv_Report.FullRowSelect = true;
            lv_Report.GridLines = true;
            lv_Report.Location = new Point(0, 308);
            lv_Report.Name = "lv_Report";
            lv_Report.Size = new Size(900, 210);
            lv_Report.TabIndex = 3;
            lv_Report.UseCompatibleStateImageBehavior = false;
            lv_Report.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã phiếu";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên sách";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mã sách";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thể loại";
            columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ngày mượn";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ngày trả";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tình trạng";
            columnHeader7.Width = 120;
            // 
            // lbl_SumNumber
            // 
            lbl_SumNumber.AutoSize = true;
            lbl_SumNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SumNumber.Location = new Point(692, 284);
            lbl_SumNumber.Name = "lbl_SumNumber";
            lbl_SumNumber.Size = new Size(59, 23);
            lbl_SumNumber.TabIndex = 4;
            lbl_SumNumber.Text = "label2";
            // 
            // lv_Acc
            // 
            lv_Acc.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9 });
            lv_Acc.FullRowSelect = true;
            lv_Acc.GridLines = true;
            lv_Acc.Location = new Point(0, 310);
            lv_Acc.Name = "lv_Acc";
            lv_Acc.Size = new Size(900, 208);
            lv_Acc.TabIndex = 5;
            lv_Acc.UseCompatibleStateImageBehavior = false;
            lv_Acc.View = View.Details;
            lv_Acc.Visible = false;
            lv_Acc.SelectedIndexChanged += lv_Acc_SelectedIndexChanged;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tên tài khoản";
            columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Mật khẩu";
            columnHeader9.Width = 200;
            // 
            // txtBookName
            // 
            txtBookName.BorderStyle = BorderStyle.FixedSingle;
            txtBookName.Location = new Point(73, 281);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(316, 30);
            txtBookName.TabIndex = 6;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(txtBookName);
            Controls.Add(lv_Acc);
            Controls.Add(lbl_SumNumber);
            Controls.Add(lv_Report);
            Controls.Add(splitter1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Report";
            Text = "Report";
            Load += Report_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btn_Report;
        private Splitter splitter1;
        private ListView lv_Report;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label lbl_SumNumber;
        private RadioButton cb_BorrowBook;
        private RadioButton cb_BookReturn;
        private RadioButton cb_Reader;
        private RadioButton cb_BookLate;
        private Button btn_Exit;
        private ListView lv_Acc;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Button btn_ToExcel;
        private TextBox txtBookName;
    }
}
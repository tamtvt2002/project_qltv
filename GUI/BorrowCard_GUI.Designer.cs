namespace GUI
{
    partial class BorrowCard_GUI
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
            lbl_idcart3 = new Label();
            lbl_idcart2 = new Label();
            lbl_IDCard = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            pbx_Back = new PictureBox();
            lbl_Back = new Label();
            btnUpdateBorrow = new Button();
            btn_detail = new Button();
            btnAddBook = new Button();
            label3 = new Label();
            label2 = new Label();
            ccb_IDStaff = new ComboBox();
            ccb_IDReader = new ComboBox();
            cb_Return = new CheckBox();
            btnDelete = new Button();
            btnAdd = new Button();
            txt_BookStatus = new TextBox();
            txt_DateReturn = new TextBox();
            txt_DateBorrow = new TextBox();
            splitter1 = new Splitter();
            lv_BorrowCard = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_Back).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_idcart3);
            panel1.Controls.Add(lbl_idcart2);
            panel1.Controls.Add(lbl_IDCard);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 62);
            panel1.TabIndex = 0;
            // 
            // lbl_idcart3
            // 
            lbl_idcart3.AutoSize = true;
            lbl_idcart3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_idcart3.Location = new Point(795, 25);
            lbl_idcart3.Name = "lbl_idcart3";
            lbl_idcart3.Size = new Size(71, 19);
            lbl_idcart3.TabIndex = 4;
            lbl_idcart3.Text = "Mã phiếu";
            // 
            // lbl_idcart2
            // 
            lbl_idcart2.AutoSize = true;
            lbl_idcart2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_idcart2.Location = new Point(704, 25);
            lbl_idcart2.Name = "lbl_idcart2";
            lbl_idcart2.Size = new Size(71, 19);
            lbl_idcart2.TabIndex = 3;
            lbl_idcart2.Text = "Mã phiếu";
            lbl_idcart2.Click += lbl_idcart2_Click;
            // 
            // lbl_IDCard
            // 
            lbl_IDCard.AutoSize = true;
            lbl_IDCard.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_IDCard.Location = new Point(704, 25);
            lbl_IDCard.Name = "lbl_IDCard";
            lbl_IDCard.Size = new Size(71, 19);
            lbl_IDCard.TabIndex = 1;
            lbl_IDCard.Text = "Mã phiếu";
            lbl_IDCard.Click += lbl_IDCard_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkTurquoise;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(900, 62);
            label1.TabIndex = 0;
            label1.Text = "Phiếu mượn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbx_Back);
            groupBox1.Controls.Add(lbl_Back);
            groupBox1.Controls.Add(btnUpdateBorrow);
            groupBox1.Controls.Add(btn_detail);
            groupBox1.Controls.Add(btnAddBook);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ccb_IDStaff);
            groupBox1.Controls.Add(ccb_IDReader);
            groupBox1.Controls.Add(cb_Return);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txt_BookStatus);
            groupBox1.Controls.Add(txt_DateReturn);
            groupBox1.Controls.Add(txt_DateBorrow);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 274);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // pbx_Back
            // 
            pbx_Back.Image = Properties.Resources.ic_back;
            pbx_Back.Location = new Point(777, 198);
            pbx_Back.Name = "pbx_Back";
            pbx_Back.Size = new Size(50, 48);
            pbx_Back.SizeMode = PictureBoxSizeMode.StretchImage;
            pbx_Back.TabIndex = 24;
            pbx_Back.TabStop = false;
            pbx_Back.Click += pbx_Back_Click;
            // 
            // lbl_Back
            // 
            lbl_Back.AutoSize = true;
            lbl_Back.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Back.Location = new Point(740, 249);
            lbl_Back.Name = "lbl_Back";
            lbl_Back.Size = new Size(135, 19);
            lbl_Back.TabIndex = 3;
            lbl_Back.Text = "Quay về Trang Chủ";
            lbl_Back.Click += lbl_idcart2_Click;
            // 
            // btnUpdateBorrow
            // 
            btnUpdateBorrow.BackColor = Color.MediumOrchid;
            btnUpdateBorrow.Location = new Point(187, 135);
            btnUpdateBorrow.Name = "btnUpdateBorrow";
            btnUpdateBorrow.Size = new Size(166, 40);
            btnUpdateBorrow.TabIndex = 23;
            btnUpdateBorrow.Text = "Cập Nhật Trả Sách";
            btnUpdateBorrow.UseVisualStyleBackColor = false;
            btnUpdateBorrow.Click += button1_Click;
            // 
            // btn_detail
            // 
            btn_detail.BackColor = Color.Cyan;
            btn_detail.Location = new Point(477, 211);
            btn_detail.Name = "btn_detail";
            btn_detail.Size = new Size(189, 48);
            btn_detail.TabIndex = 22;
            btn_detail.Text = "Chi tiết phiếu mượn";
            btn_detail.UseVisualStyleBackColor = false;
            btn_detail.Click += btn_detail_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(500, 140);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(336, 35);
            btnAddBook.TabIndex = 21;
            btnAddBook.Text = "Chọn sách muốn mượn";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 75);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 19;
            label3.Text = "Mã Thủ Thư";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 39);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 18;
            label2.Text = "Mã Sinh Viên";
            // 
            // ccb_IDStaff
            // 
            ccb_IDStaff.FormattingEnabled = true;
            ccb_IDStaff.Location = new Point(187, 72);
            ccb_IDStaff.Name = "ccb_IDStaff";
            ccb_IDStaff.Size = new Size(234, 25);
            ccb_IDStaff.TabIndex = 16;
            // 
            // ccb_IDReader
            // 
            ccb_IDReader.FormattingEnabled = true;
            ccb_IDReader.Location = new Point(187, 35);
            ccb_IDReader.Name = "ccb_IDReader";
            ccb_IDReader.Size = new Size(235, 25);
            ccb_IDReader.TabIndex = 15;
            // 
            // cb_Return
            // 
            cb_Return.AutoSize = true;
            cb_Return.Location = new Point(77, 147);
            cb_Return.Name = "cb_Return";
            cb_Return.Size = new Size(66, 23);
            cb_Return.TabIndex = 14;
            cb_Return.Text = "Đã trả";
            cb_Return.UseVisualStyleBackColor = true;
            cb_Return.CheckedChanged += cb_Return_CheckedChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(293, 211);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(128, 48);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Xóa phiếu";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LawnGreen;
            btnAdd.Location = new Point(60, 211);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(147, 48);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Tạo phiếu mượn";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txt_BookStatus
            // 
            txt_BookStatus.BorderStyle = BorderStyle.FixedSingle;
            txt_BookStatus.Location = new Point(500, 109);
            txt_BookStatus.Name = "txt_BookStatus";
            txt_BookStatus.PlaceholderText = "Tình trạng sách";
            txt_BookStatus.Size = new Size(336, 25);
            txt_BookStatus.TabIndex = 9;
            // 
            // txt_DateReturn
            // 
            txt_DateReturn.BorderStyle = BorderStyle.FixedSingle;
            txt_DateReturn.Location = new Point(500, 72);
            txt_DateReturn.Name = "txt_DateReturn";
            txt_DateReturn.PlaceholderText = "Ngày trả";
            txt_DateReturn.Size = new Size(336, 25);
            txt_DateReturn.TabIndex = 8;
            // 
            // txt_DateBorrow
            // 
            txt_DateBorrow.BorderStyle = BorderStyle.FixedSingle;
            txt_DateBorrow.Location = new Point(500, 35);
            txt_DateBorrow.Name = "txt_DateBorrow";
            txt_DateBorrow.PlaceholderText = "Ngày mượn";
            txt_DateBorrow.Size = new Size(336, 25);
            txt_DateBorrow.TabIndex = 7;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 336);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(900, 4);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // lv_BorrowCard
            // 
            lv_BorrowCard.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader6, columnHeader8 });
            lv_BorrowCard.Dock = DockStyle.Top;
            lv_BorrowCard.FullRowSelect = true;
            lv_BorrowCard.GridLines = true;
            lv_BorrowCard.Location = new Point(0, 340);
            lv_BorrowCard.Name = "lv_BorrowCard";
            lv_BorrowCard.Size = new Size(900, 328);
            lv_BorrowCard.TabIndex = 3;
            lv_BorrowCard.UseCompatibleStateImageBehavior = false;
            lv_BorrowCard.View = View.Details;
            lv_BorrowCard.SelectedIndexChanged += lv_BorrowCard_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã phiếu";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Họ tên người mượn";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Lớp";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Số điện thoại";
            columnHeader4.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tên người lập";
            columnHeader6.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Số lượng sách mượn";
            columnHeader8.Width = 180;
            // 
            // BorrowCard_GUI
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(lv_BorrowCard);
            Controls.Add(splitter1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BorrowCard_GUI";
            Text = "Phieu_Muon_Tra";
            FormClosing += BorrowCard_GUI_FormClosing;
            Load += BorrowCard_GUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_Back).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbl_IDCard;
        private Label label1;
        private GroupBox groupBox1;
        private Splitter splitter1;
        private ListView lv_BorrowCard;
        private TextBox txt_BookStatus;
        private TextBox txt_DateReturn;
        private TextBox txt_DateBorrow;
        private Button btnDelete;
        private Button btnAdd;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private CheckBox cb_Return;
        private ComboBox ccb_IDStaff;
        private ComboBox ccb_IDReader;
        private Label label3;
        private Label label2;
        private Label lbl_idcart3;
        private Label lbl_idcart2;
        private Button btnAddBook;
        private ColumnHeader columnHeader8;
        private Button btn_detail;
        private Button btnUpdateBorrow;
        private PictureBox pbx_Back;
        private Label lbl_Back;
    }
}
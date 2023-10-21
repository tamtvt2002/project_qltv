namespace GUI
{
    partial class DetailBorrmow
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
            groupBox1 = new GroupBox();
            lst_detailBr = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            label1 = new Label();
            lbl_txt = new Label();
            lbl_cardID = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_nameUser = new Label();
            lbl_phoneNumber = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lst_detailBr);
            groupBox1.Location = new Point(46, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(804, 247);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // lst_detailBr
            // 
            lst_detailBr.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lst_detailBr.Dock = DockStyle.Fill;
            lst_detailBr.FullRowSelect = true;
            lst_detailBr.GridLines = true;
            lst_detailBr.Location = new Point(3, 21);
            lst_detailBr.Name = "lst_detailBr";
            lst_detailBr.Size = new Size(798, 223);
            lst_detailBr.TabIndex = 0;
            lst_detailBr.UseCompatibleStateImageBehavior = false;
            lst_detailBr.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã sách";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên sách";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Thể loại";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tác giả";
            columnHeader4.Width = 100;
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
            columnHeader7.Text = "Số lượng";
            columnHeader7.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(329, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 1;
            label1.Text = "Chi tiết mượn trả";
            // 
            // lbl_txt
            // 
            lbl_txt.AutoSize = true;
            lbl_txt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_txt.Location = new Point(643, 50);
            lbl_txt.Name = "lbl_txt";
            lbl_txt.Size = new Size(86, 21);
            lbl_txt.TabIndex = 2;
            lbl_txt.Text = "Mã phiếu:";
            // 
            // lbl_cardID
            // 
            lbl_cardID.AutoSize = true;
            lbl_cardID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cardID.Location = new Point(755, 50);
            lbl_cardID.Name = "lbl_cardID";
            lbl_cardID.Size = new Size(27, 21);
            lbl_cardID.TabIndex = 3;
            lbl_cardID.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 108);
            label2.Name = "label2";
            label2.Size = new Size(137, 19);
            label2.TabIndex = 4;
            label2.Text = "Họ tên người mượn: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 166);
            label3.Name = "label3";
            label3.Size = new Size(92, 19);
            label3.TabIndex = 5;
            label3.Text = "Số điện thoại:";
            // 
            // lbl_nameUser
            // 
            lbl_nameUser.AutoSize = true;
            lbl_nameUser.Location = new Point(225, 108);
            lbl_nameUser.Name = "lbl_nameUser";
            lbl_nameUser.Size = new Size(71, 19);
            lbl_nameUser.TabIndex = 6;
            lbl_nameUser.Text = "nameUser";
            // 
            // lbl_phoneNumber
            // 
            lbl_phoneNumber.AutoSize = true;
            lbl_phoneNumber.Location = new Point(170, 166);
            lbl_phoneNumber.Name = "lbl_phoneNumber";
            lbl_phoneNumber.Size = new Size(98, 19);
            lbl_phoneNumber.TabIndex = 7;
            lbl_phoneNumber.Text = "phoneNumber";
            // 
            // DetailBorrmow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(lbl_phoneNumber);
            Controls.Add(lbl_nameUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_cardID);
            Controls.Add(lbl_txt);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "DetailBorrmow";
            Text = "DetailBorrmow";
            Load += DetailBorrmow_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lst_detailBr;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label1;
        private Label lbl_txt;
        private Label lbl_cardID;
        private Label label2;
        private Label label3;
        private Label lbl_nameUser;
        private Label lbl_phoneNumber;
    }
}
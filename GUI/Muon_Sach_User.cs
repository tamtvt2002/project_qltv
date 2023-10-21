using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using BLL;

namespace GUI
{
    public partial class Muon_Sach_User : Form
    {
        public Muon_Sach_User()
        {
            InitializeComponent();
        }

        private void Muon_Sach_User_Load(object sender, EventArgs e)
        {
            Muon_Sach_User_BLL msuBLL = new Muon_Sach_User_BLL();
            // Load mã phiếu tự động
            lbl_IdBorrowCard.Text = msuBLL.GetIDCard().ToString();
            // Tự động điền thông tin khách hàng
            string tendangnhap = Login.tendangnhap;           
            Reader reader = msuBLL.ShowInfoReader(tendangnhap);
            txt_IdReader.Text = reader.ID.ToString();
            txt_NameReader.Text = reader.name.ToString();
            txt_Class.Text = reader.classMate.ToString();
            txt_SDT.Text = reader.phoneNumber.ToString();
            // tự động điền thông tin sách
            string idbook = Main_user.idbook;
            Book b = msuBLL.ShowInfoBook(idbook);
            txt_IdBook.Text = Main_user.idbook.ToString();
            txt_NameBook.Text = b.namebook.ToString();
            txt_Category.Text = b.category.ToString();
        }

        private void txt_IdBook_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Main_user mu = new Main_user();
            mu.Show();
            this.Hide();
        }

        private void Muon_Sach_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Xác nhận thoát ?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // Ngăn chặn đóng form
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            BorrowCard bc = new BorrowCard();
            bc.idReader = txt_IdReader.Text.Trim();
            bc.idbook = txt_IdBook.Text.Trim();
            bc.dateborrow = txt_DateBorrow.Text;
            bc.dateReturn = txt_DateReturn.Text;

            Muon_Sach_User_BLL msuBLL = new Muon_Sach_User_BLL();
            bool kt = msuBLL.AddBorrowCard(bc);
            msuBLL.updateAmountBLL(txt_IdBook.Text.Trim());
            if (kt)
            {
                DialogResult result = MessageBox.Show("Lập phiếu mượn thành công!\nBạn có muốn quay lại không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Main_user m = new Main_user();
                    m.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Lập thất bại!");
            }
        }
    }
}

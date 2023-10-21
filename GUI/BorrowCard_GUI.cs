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
    public partial class BorrowCard_GUI : Form
    {
        public BorrowCard_GUI()
        {
            InitializeComponent();
        }

        private void ShowBorrowCard()
        {
            BorrowCard_BLL bcBLL = new BorrowCard_BLL();
            List<BorrowCard> lbc = bcBLL.ShowBorrowCard();
            lv_BorrowCard.Items.Clear();
            foreach (BorrowCard bc in lbc)
            {
                ListViewItem item = new ListViewItem(bc.idcart);
                item.SubItems.Add(bc.nameReader);
                item.SubItems.Add(bc.classMate);
                item.SubItems.Add(bc.numberPhone);
                item.SubItems.Add(bc.nameStaff);
                item.SubItems.Add(bc.amount.ToString());
                lv_BorrowCard.Items.Add(item);
            }
        }

        private void BorrowCard_GUI_Load(object sender, EventArgs e)
        {
            ShowBorrowCard();
            LoadIdReader();
            LoadIdStaff();
            LoadIdBook();
            lbl_idcart3.Visible = false;
            lbl_idcart2.Visible = false;
            BorrowCard_BLL bcBLL = new BorrowCard_BLL();
            lbl_IDCard.Text = bcBLL.GetIDCard();
        }

        private void LoadIdReader()
        {
            BorrowCard_BLL bcBLL = new BorrowCard_BLL();
            List<Reader> customers = bcBLL.AddIDReader();
            ccb_IDReader.DataSource = customers;
            ccb_IDReader.DisplayMember = "Ma_DG"; // Hiển thị tên khách hàng lên ComboBox
            ccb_IDReader.ValueMember = "ID"; // Lấy ID khách hàng khi chọn từ ComboBox
        }

        private void LoadIdStaff()
        {
            BorrowCard_BLL bcBLL = new BorrowCard_BLL();
            List<Reader> customers = bcBLL.AddIDStaff();
            ccb_IDStaff.DataSource = customers;
            ccb_IDStaff.DisplayMember = "Ma_NV"; // Hiển thị tên khách hàng lên ComboBox
            ccb_IDStaff.ValueMember = "ID"; // Lấy ID khách hàng khi chọn từ ComboBox
        }

        private void LoadIdBook()
        {
            BorrowCard_BLL bcBLL = new BorrowCard_BLL();
            List<Reader> customers = bcBLL.AddIDBook();
            //ccb_IDBook.DataSource = customers;
            //ccb_IDBook.DisplayMember = "MaSach"; // Hiển thị tên khách hàng lên ComboBox
            //ccb_IDBook.ValueMember = "ID"; // Lấy ID khách hàng khi chọn từ ComboBox
        }

        //private bool checkAmount()
        //{
        //    BorrowCard_BLL bk = new BorrowCard_BLL();
        //    return bk.amountCa();

        //}
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // lấy list mã sách mượn từ form con
            List<BorrowCard> listBorrow = new List<BorrowCard>();
            listBorrow = BorrowCard_child_.listBookBorrow;

            if (listBorrow.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đầu sách");
            }

            else
            {
                string[] idcard = lbl_IDCard.Text.Split(':');

                // Cập nhật mã phiếu vào đối tượng card
                foreach (BorrowCard card in listBorrow)
                {
                    card.idcart = idcard[1].Trim();
                }

                BorrowCard bc = new BorrowCard();
                bc.idReader = ccb_IDReader.Text;
                bc.idStaff = ccb_IDStaff.Text;
                //bc.idbook = ccb_IDBook.Text;
                bc.dateborrow = txt_DateBorrow.Text;
                bc.dateReturn = txt_DateReturn.Text;
                bc.bookstatus = txt_BookStatus.Text;



                if (cb_Return.Checked)
                {
                    bc.returned = "Đã trả";
                }
                else
                {
                    bc.returned = "Chưa trả";
                }

                BorrowCard_BLL bcBLL = new BorrowCard_BLL();
                bcBLL.detailPayBLL(listBorrow, idcard[1].Trim(), bc);
                bool kt = bcBLL.AddBorrowCard(bc, idcard[1].Trim());
                if (kt)
                {
                    MessageBox.Show("Lập phiếu mượn thành công!");
                    ShowBorrowCard();
                }
                else
                {
                    MessageBox.Show("Lập thất bại!");
                }
            }

        }

        private void BorrowCard_GUI_FormClosing(object sender, FormClosingEventArgs e)
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



        //private void btnFix_Click(object sender, EventArgs e)
        //{
        //    BorrowCard_BLL bcBLL = new BorrowCard_BLL();
        //    BorrowCard bc = new BorrowCard();
        //    bc.idcart = lbl_IDCard.Text;
        //    bc.idReader = ccb_IDReader.SelectedItem.ToString();
        //    bc.idStaff = ccb_IDReader.SelectedItem.ToString();
        //    bc.idbook = ccb_IDReader.SelectedItem.ToString();
        //    bc.dateborrow = txt_DateBorrow.Text.Trim();
        //    bc.dateReturn = txt_DateReturn.Text.Trim();
        //    bc.bookstatus = txt_BookStatus.Text.Trim();
        //    if (cb_Return.Checked)
        //    {
        //        bc.returned = "Đã trả";
        //    }
        //    else bc.returned = "Chưa trả";
        //    bool kq = bcBLL.UpdateBorrowcard(bc);
        //    if (kq)
        //    {
        //        MessageBox.Show("Sửa thành công!");
        //        ShowBorrowCard();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Sửa thất bại");
        //    }

        //}
        public static string cardID = "";
        public static string nameUser = "";
        public static string phoneNumber = "";
        private void lv_BorrowCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_BorrowCard.SelectedItems.Count > 0)
            {
                lbl_IDCard.Visible = false;
                lbl_idcart2.Visible = true;
                lbl_idcart2.Text = "Mã phiếu: ";
                lbl_idcart3.Visible = true;
                ListViewItem lsv = lv_BorrowCard.SelectedItems[0];
                lbl_idcart3.Text = lsv.SubItems[0].Text;
                cardID = lbl_idcart3.Text;
                nameUser = lsv.SubItems[1].Text;
                phoneNumber = lsv.SubItems[3].Text;


            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BorrowCard bc = new BorrowCard();
            BorrowCard_BLL bcBLL = new BorrowCard_BLL();
            bc.idcart = lbl_idcart3.Text;
            List<Book> listbook = bcBLL.updateAmountBookBLL(bc.idcart);

            bool kq = bcBLL.DeLeteBorrowCard(bc);
            if (kq)
            {
                MessageBox.Show("Xóa thành công!");
                ShowBorrowCard();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void lbl_IDCard_Click(object sender, EventArgs e)
        {

        }

        private void lbl_idcart2_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }


        private void btnAddBook_Click(object sender, EventArgs e)
        {
            //BorrowCard_child_BLL br = new BorrowCard_child_BLL();
            //br.createIDBLL();
            BorrowCard_child_ formBrCar = new BorrowCard_child_();
            this.Hide();
            formBrCar.Show();

        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            if (cardID == "")
            {
                MessageBox.Show("Vui lòng chọn mã phiếu");
            }
            else
            {
                DetailBorrmow frm = new DetailBorrmow();
                frm.Show();
            }

        }

        private void cb_Return_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pbx_Back_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }
    }
}

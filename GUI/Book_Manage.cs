using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Book_Manage : Form
    {
        public Book_Manage()
        {
            InitializeComponent();
        }

        private void Book_Manage_Load(object sender, EventArgs e)
        {
            //updateAmount();
            showListBook();
            int countSum = lsv_books.Items.Count;
            lbl_SumNumber.Text = "Tổng số sách: " + countSum;
        }

        private bool updateAmount()
        {
            BookBLL bk = new BookBLL();
            return bk.amountCa();
        }

        private void showListBook()
        {
            BookBLL bk = new BookBLL();
            List<Book> listBook = bk.showBook();
            lsv_books.Items.Clear();
            foreach (Book itemp in listBook)
            {
                //string time = DateTime.Parse(itemp.nbxYear).ToString("dd/MM/yyyy");

                ListViewItem lsv = new ListViewItem(itemp.idbook);
                lsv.SubItems.Add(itemp.namebook);
                lsv.SubItems.Add(itemp.nxbName);
                lsv.SubItems.Add(itemp.nbxYear);
                lsv.SubItems.Add(itemp.authorName);
                lsv.SubItems.Add(itemp.category);
                lsv.SubItems.Add(itemp.amount);
                lsv.SubItems.Add(itemp.da_muon);
                lsv.SubItems.Add(itemp.ton_kho);              
                lsv_books.Items.Add(lsv);

            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Book b = new Book();

            b.nxbName = txt_namePublish.Text;
            b.authorName = txt_nameAuthor.Text;
            b.category = txt_type.Text;
            b.namebook = txt_bookName.Text;
            b.nbxYear = txt_yearPublish.Text;
            b.amount = txt_amount.Text;
            BookBLL book = new BookBLL();
            bool kq = book.add(b);
            if(kq)
            {
                MessageBox.Show("Thêm thành công!");
                showListBook();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            int countSum = lsv_books.Items.Count;
            lbl_SumNumber.Text = "Tổng số sách: " + countSum;
        }

        private void lsv_books_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_books.SelectedItems.Count > 0)
            {
                ListViewItem lsv = lsv_books.SelectedItems[0];
                txt_nameAuthor.Text = lsv.SubItems[4].Text;
                txt_type.Text = lsv.SubItems[5].Text;
                txt_namePublish.Text = lsv.SubItems[2].Text;
                txt_bookName.Text = lsv.SubItems[1].Text;
                txt_yearPublish.Text = lsv.SubItems[3].Text;
                txt_amount.Text = lsv.SubItems[6].Text;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            ListViewItem lsv = lsv_books.SelectedItems[0];
            b.idbook = lsv.SubItems[0].Text;
            b.nxbName = txt_namePublish.Text;
            b.authorName = txt_nameAuthor.Text;
            b.category = txt_type.Text;
            b.namebook = txt_bookName.Text;
            b.nbxYear = txt_yearPublish.Text;
            b.status = "";
            b.amount = txt_amount.Text;
            BookBLL book = new BookBLL();
            book.update(b);
            showListBook();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            ListViewItem lsv = lsv_books.SelectedItems[0];
            b.idbook = lsv.SubItems[0].Text; // Lấy id của độc giả tại sự kiện click vào listview đang chọn
            BookBLL bBLL = new BookBLL();
            bool kq = bBLL.delete(b);
            if (kq)
            {
                MessageBox.Show("Xóa thành công!");
                showListBook();
            }
            else
            {
                MessageBox.Show("Xóa thất bại do sách đang được mượn");
            }
            int countSum = lsv_books.Items.Count;
            lbl_SumNumber.Text = "Tổng số sách: " + countSum;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            BookBLL bBLL = new BookBLL();
            string tmp = txt_search.Text.Trim();
            List<Book> listBook = bBLL.searchBook(tmp);
            lsv_books.Items.Clear();
            foreach (Book itemp in listBook)
            {
                //string time = DateTime.Parse(itemp.nbxYear).ToString("dd/MM/yyyy");

                ListViewItem lsv = new ListViewItem(itemp.idbook);
                lsv.SubItems.Add(itemp.namebook);
                lsv.SubItems.Add(itemp.nxbName);
                lsv.SubItems.Add(itemp.nbxYear);
                lsv.SubItems.Add(itemp.authorName);
                lsv.SubItems.Add(itemp.category);
                lsv.SubItems.Add(itemp.amount);
                lsv.SubItems.Add(itemp.da_muon);
                lsv.SubItems.Add(itemp.ton_kho);
                lsv_books.Items.Add(lsv);

            }
            int countSum = lsv_books.Items.Count;
            lbl_SumNumber.Text = "Tổng số sách: " + countSum;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void Book_Manage_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}

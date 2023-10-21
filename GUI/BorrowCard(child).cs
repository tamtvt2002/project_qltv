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
using BLL;
namespace GUI
{
    public partial class BorrowCard_child_ : Form
    {
        public string idBook = "";
        public static string amoount = "";
        public static List<BorrowCard> listBookBorrow = new List<BorrowCard>();
        public BorrowCard_child_()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            amoount = txt_amount.Text;
            if (amoount == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng");
            }
            else if (idBook == "")
            {
                MessageBox.Show("Vui lòng chọn sách");
            }
            else
            {
                BorrowCard_child_BLL br = new BorrowCard_child_BLL();
                BorrowCard card = new BorrowCard();
                card.idbook = idBook;
                card.amount = int.Parse(amoount.Trim());

                listBookBorrow.Add(card);
                MessageBox.Show("Thêm đầu sách thành công");
            }


        }



        private void BorrowCard_child__Load(object sender, EventArgs e)
        {
            listBookBorrow.Clear();
            showListBook();
        }

        private void showListBook()
        {
            BorrowCard_child_BLL book = new BorrowCard_child_BLL();
            List<Book> listBook = book.show();
            lsv_Book.Items.Clear();
            foreach (Book item in listBook)
            {
                ListViewItem lsv = new ListViewItem(item.idbook);

                lsv.SubItems.Add(item.namebook);
                lsv.SubItems.Add(item.nxbName);
                lsv.SubItems.Add(item.nbxYear);
                lsv.SubItems.Add(item.authorName);
                lsv.SubItems.Add(item.category);
                lsv.SubItems.Add(item.ton_kho);

                lsv_Book.Items.Add(lsv);
            }

        }

        private void lsv_Book_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_Book.SelectedItems.Count > 0)
            {
                ListViewItem lsv = lsv_Book.SelectedItems[0];
                idBook = lsv.SubItems[0].Text.Trim();

            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            BorrowCard_child_BLL bccBLL = new BorrowCard_child_BLL();
            string tmp = txt_search.Text.Trim();
            List<Book> listBook = bccBLL.searchCu(tmp);
            lsv_Book.Items.Clear();
            foreach (Book itemp in listBook)
            {
                //string time = DateTime.Parse(itemp.nbxYear).ToString("dd/MM/yyyy");

                ListViewItem lsv = new ListViewItem(itemp.idbook);
                lsv.SubItems.Add(itemp.namebook);
                lsv.SubItems.Add(itemp.nxbName);
                lsv.SubItems.Add(itemp.nbxYear);
                lsv.SubItems.Add(itemp.authorName);
                lsv.SubItems.Add(itemp.category);
                lsv.SubItems.Add(itemp.ton_kho);
                lsv_Book.Items.Add(lsv);

            }
        }

        private void ptb_Back_Click(object sender, EventArgs e)
        {

            BorrowCard_GUI brc = new BorrowCard_GUI();
            DialogResult result = MessageBox.Show("Xác nhận thoát ?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                brc.Show();
                this.Close();


            }
        }
    }
}

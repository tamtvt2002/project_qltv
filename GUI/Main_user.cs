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
    public partial class Main_user : Form
    {
        public Main_user()
        {
            InitializeComponent();
        }

        private void Main_user_Load(object sender, EventArgs e)
        {
            ShowListBook();
        }
        private void ShowListBook()
        {
            Main_user_BLL muBLL = new Main_user_BLL();
            List<Book> lb = muBLL.ShowListBook();
            lv_ListBook.Items.Clear();
            foreach (Book b in lb)
            {
                ListViewItem item = new ListViewItem(b.idbook);
                item.SubItems.Add(b.namebook);
                item.SubItems.Add(b.authorName);
                item.SubItems.Add(b.nxbName);
                item.SubItems.Add(b.nbxYear);
                item.SubItems.Add(b.category);
                item.SubItems.Add(b.ton_kho);
                lv_ListBook.Items.Add(item);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            Main_user_BLL mBLL = new Main_user_BLL();
            string search = txt_Search.Text.Trim();
            mBLL.Search(search, b);
            lv_ListBook.Items.Clear();
            ListViewItem lvi = new ListViewItem(b.idbook);
            lvi.SubItems.Add(b.namebook);
            lvi.SubItems.Add(b.authorName);
            lvi.SubItems.Add(b.nxbName);
            lvi.SubItems.Add(b.nbxYear);
            lvi.SubItems.Add(b.category);
            lvi.SubItems.Add(b.ton_kho);
            lv_ListBook.Items.Add(lvi);
        }

        private void Main_user_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MainChoUser_GUI mcu = new MainChoUser_GUI();
            mcu.Show();
            this.Hide();
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            Muon_Sach_User msu = new Muon_Sach_User();
            msu.Show();
            this.Hide();
        }
        public static string idbook;
        private void lv_ListBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_ListBook.SelectedItems.Count > 0)
            {
                ListViewItem lsv = lv_ListBook.SelectedItems[0];
                idbook = lsv.SubItems[0].Text;
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {
                ShowListBook();
            }
        }
    }
}

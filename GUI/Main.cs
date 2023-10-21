using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            btn_Reader_manage.ForeColor = Color.FromArgb(251, 209, 96);
        }

        private void btn_Reader_manage_MouseLeave(object sender, EventArgs e)
        {
            btn_Reader_manage.ForeColor = Color.White;
        }

        private void btn_BookManage_MouseEnter(object sender, EventArgs e)
        {
            btn_BookManage.ForeColor = Color.FromArgb(251, 209, 96);
        }

        private void btn_BookManage_MouseLeave(object sender, EventArgs e)
        {
            btn_BookManage.ForeColor = Color.White;
        }

        private void btnBorrowBook_MouseEnter(object sender, EventArgs e)
        {
            btnBorrowBook.ForeColor = Color.FromArgb(251, 209, 96);
        }

        private void btnBorrowBook_MouseLeave(object sender, EventArgs e)
        {
            btnBorrowBook.ForeColor = Color.White;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbl_NameUser.Text = Login.fullname.ToString();
        }

        private void btn_Statistic_MouseLeave(object sender, EventArgs e)
        {
            btn_Statistic.ForeColor = Color.White;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.FromArgb(251, 209, 96);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.White;
        }

        private void btn_Statistic_MouseEnter(object sender, EventArgs e)
        {
            btn_Statistic.ForeColor = Color.FromArgb(251, 209, 96);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
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

        private void lbl_NameUser_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reader_manage_Click(object sender, EventArgs e)
        {
            Readers_Manage rm = new Readers_Manage();
            rm.Show();
            this.Hide();
        }

        private void btn_Statistic_Click(object sender, EventArgs e)
        {
            Report rp = new Report();
            rp.Show();
            this.Hide();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            BorrowCard_GUI bcGUI = new BorrowCard_GUI();
            bcGUI.Show();
            this.Hide();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            Main_user mu = new Main_user();
            mu.Show();
            this.Hide();
        }

        private void btn_user_MouseEnter(object sender, EventArgs e)
        {
            btn_Statistic.ForeColor = Color.FromArgb(251, 209, 96);
        }

        private void btn_user_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.White;
        }

        private void btn_BookManage_Click(object sender, EventArgs e)
        {
            Book_Manage bm = new Book_Manage();
            bm.Show();
            this.Hide();
        }
    }
}

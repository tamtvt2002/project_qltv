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
    public partial class SignUp : Form
    {
        
        public SignUp()
        {
            InitializeComponent();
        }

        // textbox
        public void formatTextBoxWhenClick(TextBox x)
        {
            x.Text = "";
            x.ForeColor = Color.Black;
        }
        private void txt_nameAccount_Click(object sender, EventArgs e)
        {
            formatTextBoxWhenClick(txt_nameAccount);
        }

        private void txt_passAccount_Click(object sender, EventArgs e)
        {
            formatTextBoxWhenClick(txt_passAccount);
        }

        private void txt_repeatAccount_Click(object sender, EventArgs e)
        {
            formatTextBoxWhenClick(txt_repeatAccount);
        }

        private void txt_fullName_Click(object sender, EventArgs e)
        {
            formatTextBoxWhenClick(txt_fullName);
        }

        private void txt_class_Click(object sender, EventArgs e)
        {
            formatTextBoxWhenClick(txt_class);
        }

        private void txt_phoneNumber_Click(object sender, EventArgs e)
        {
            formatTextBoxWhenClick(txt_phoneNumber);
        }
        // label



        private void lbl_signUp_Click(object sender, EventArgs e)
        {
            AccountBLL account = new AccountBLL();
            Accounts acc = new Accounts();
            acc.nameUser = txt_nameAccount.Text.Trim();
            acc.password = txt_passAccount.Text.Trim();
            acc.fullName = txt_fullName.Text.Trim();
            acc.Class = txt_class.Text.Trim();
            acc.NumberPhone = txt_phoneNumber.Text.Trim();
            
            if(txt_nameAccount.Text == "" || txt_passAccount.Text == "" || txt_repeatAccount.Text == "" ||txt_fullName.Text == "" || txt_class.Text == "" || txt_phoneNumber.Text == "")
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else if(txt_nameAccount.Text == "")
            {
                MessageBox.Show("Vui lòng điền tên đăng nhập!");
            }
            else if(txt_passAccount.Text != txt_repeatAccount.Text)
            {
                MessageBox.Show("Vui lòng nhập 2 mật khẩu giống nhau!");
            }
            else if(txt_fullName.Text == "")
            {
                MessageBox.Show("Vui lòng điền họ và tên!");
            }
            else if(txt_class.Text == "")
            {
                MessageBox.Show("Vui lòng điền lớp hoặc chức vụ");
            }
            else if(txt_phoneNumber.Text == "")
            {
                MessageBox.Show("Vui lòng điền số điện thoại!");
            }
            else
            {
                if (account.accountCreate(acc))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại !");
                }
                else
                {
                    if(account.CheckUserAcc(acc))
                    {
                        MessageBox.Show("Số điện thoại đã được đăng ký !");
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký tài khoản thành công");
                        Login loginForm = new Login();
                        loginForm.Show();
                        this.Hide();
                    }
                }
            }
            
        }

        private void lbl_signUp_MouseEnter(object sender, EventArgs e)
        {
            lbl_signUp.ForeColor = Color.FromArgb(251, 209, 96);
        }

        private void lbl_signUp_MouseLeave(object sender, EventArgs e)
        {
            lbl_signUp.ForeColor = Color.White;
        }

        private void lbl_facebook_MouseEnter(object sender, EventArgs e)
        {
            lbl_facebook.ForeColor = Color.FromArgb(251, 209, 96);
        }
        private void lbl_facebook_MouseLeave(object sender, EventArgs e)
        {
            lbl_facebook.ForeColor = Color.White;
        }

        private void lbl_Google_MouseEnter(object sender, EventArgs e)
        {
            lbl_Google.ForeColor = Color.FromArgb(251, 209, 96);
        }

        private void lbl_Google_MouseLeave(object sender, EventArgs e)
        {
            lbl_Google.ForeColor = Color.White;
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Xác nhận hủy đăng ký ?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // Ngăn chặn đóng form
                }
                else
                {               
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}

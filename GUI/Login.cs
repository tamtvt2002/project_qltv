using DTO;
using BLL;
using DAL;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {

            InitializeComponent();

        }
        // textbox
        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = '*';
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }

        private void txt_name_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_name.ForeColor = Color.Black;
        }

        private void txt_pass_Click(object sender, EventArgs e)
        {
            txt_pass.Text = "";
            txt_pass.ForeColor = Color.Black;
        }


        // label
        private void lb_Login_MouseEnter(object sender, EventArgs e)
        {
            lb_Login.ForeColor = Color.FromArgb(251, 209, 96);
        }

        private void lb_Login_MouseLeave(object sender, EventArgs e)
        {
            lb_Login.ForeColor = Color.White;
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
        private void lbl_signUp_Click(object sender, EventArgs e)
        {
            SignUp signupFrom = new SignUp();
            signupFrom.Show();
            this.Hide();
        }



        private void Login_FormClosing(object sender, FormClosingEventArgs e)
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
        // process
        public static string tendangnhap;
        public static string fullname;
        private void lb_Login_Click(object sender, EventArgs e)
        {
            AccountBLL account = new AccountBLL();
            Accounts acc = new Accounts();

            acc.nameUser = txt_name.Text.Trim();
            acc.password = txt_pass.Text.Trim();

            if (account.checkAccount(acc))
            {

                acc.nameUser = txt_name.Text;
                if (account.CheckPermision(acc) > 1)
                {
                    Main main = new Main();
                    fullname = account.getUserName(acc).ToString();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MainChoUser_GUI mcu = new MainChoUser_GUI();
                    fullname = account.getUserName(acc);
                    tendangnhap = txt_name.Text;
                    mcu.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
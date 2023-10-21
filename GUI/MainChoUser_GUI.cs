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
    public partial class MainChoUser_GUI : Form
    {
        public MainChoUser_GUI()
        {
            InitializeComponent();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            Main_user mu = new Main_user();
            mu.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void MainChoUser_GUI_Load(object sender, EventArgs e)
        {
            lbl_NameUser.Text = Login.fullname.ToString();
        }

        private void MainChoUser_GUI_FormClosing(object sender, FormClosingEventArgs e)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace GUI
{
    public partial class Form_Load : Form
    {
        private Timer timer;
        private int timeLeft = 5;
        public Form_Load()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load);
            //Login l = new Login();
            //l.Show();
            //this.FormClosing += new FormClosingEventHandler(CloseForm_Load);
            //this.Hide();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Tạo Timer với khoảng thời gian là 1 giây
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer_Tick);

            // Bắt đầu đếm ngược thời gian
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Giảm thời gian đếm ngược
            timeLeft--;

            // Nếu đã hết thời gian đếm ngược
            if (timeLeft == 0)
            {
                // Dừng Timer
                timer.Stop();

                // Tắt form hiện tại
                this.Hide();

                // Mở form khác (LoginForm)
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        private void CloseForm_Load(object? sender, FormClosingEventArgs e)
        {
        //Login l = new Login();
        //l.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            this.Visible = true;
        }
    }
}

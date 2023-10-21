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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static GUI.Login;
using System.Security.Principal;

namespace GUI
{
    public partial class Readers_Manage : Form
    {
        public Readers_Manage()
        {
            InitializeComponent();
        }
        private void ShowListReader()
        {
            Readers_BLL rdBLL = new Readers_BLL();
            List<Reader> ds = rdBLL.Show();
            lv_ListReaders.Items.Clear();
            foreach(Reader item in ds)
            {
                ListViewItem lvi = new ListViewItem(item.ID);
                lvi.SubItems.Add(item.name);
                lvi.SubItems.Add(item.classMate);
                lvi.SubItems.Add(item.phoneNumber);
                lvi.SubItems.Add(item.nameAcc);
                lv_ListReaders.Items.Add(lvi);
            }
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Readers_Manage_Load(object sender, EventArgs e)
        {
            ShowListReader();
            int countSum = lv_ListReaders.Items.Count;
            lbl_SumNumber.Text = "Tổng số: " + countSum ;
            Readers_BLL rdBLL = new Readers_BLL();
            txt_IdReader.Text = rdBLL.GetIdReader();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reader rd = new Reader();
            rd.name = txt_nameReader.Text.Trim();
            rd.classMate = txt_Class.Text.Trim();
            rd.phoneNumber = txt_PhoneNumber.Text.Trim();
            Readers_BLL rdBLL = new Readers_BLL();
            bool kt = rdBLL.AddReader(rd);
            if(kt)
            {
                MessageBox.Show("Thêm độc giả thành công!");
                ShowListReader();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {
            int countSum = lv_ListReaders.Items.Count;
            lbl_SumNumber.Text = "Tổng số: " + countSum;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Reader rd = new Reader();
            Readers_BLL rdBLL = new Readers_BLL();
            rd.ID = txt_IdReader.Text.Trim();
            bool kq = rdBLL.DeleteReader(rd);
            if(kq)
            {
                MessageBox.Show("Xóa thất bại!");
            }
            else
            {
                MessageBox.Show("Xóa thành công!");
                ShowListReader();
            }
        }


        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void lv_ListReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_ListReaders.SelectedItems.Count > 0)
            {
                ListViewItem lsv = lv_ListReaders.SelectedItems[0];
                txt_IdReader.Text = lsv.SubItems[0].Text;
                txt_nameReader.Text = lsv.SubItems[1].Text;
                txt_Class.Text = lsv.SubItems[2].Text;
                txt_PhoneNumber.Text = lsv.SubItems[3].Text;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Readers_BLL rdBLL = new Readers_BLL();
            Reader rd = new Reader();
            rd.ID = txt_IdReader.Text.Trim();
            rd.name = txt_nameReader.Text.Trim();
            rd.classMate = txt_Class.Text.Trim();
            rd.phoneNumber = txt_PhoneNumber.Text.Trim();
            bool kt = rdBLL.UpdateReader(rd);
            if (kt)
            {
                MessageBox.Show("Sửa thành công!");
                ShowListReader();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void Readers_Manage_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnDelete_MouseClick(object sender, MouseEventArgs e)
        {
            int countSum = lv_ListReaders.Items.Count;
            lbl_SumNumber.Text = "Tổng số: " + countSum;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Reader rd = new Reader();
            Readers_BLL rdBLL = new Readers_BLL();
            string tmp = txt_Search.Text.Trim();
            List<Reader> listReader = rdBLL.SearchReader(tmp);
            lv_ListReaders.Items.Clear();
            foreach (Reader item in listReader)
            {
                ListViewItem lvi = new ListViewItem(item.ID);
                lvi.SubItems.Add(item.name);
                lvi.SubItems.Add(item.classMate);
                lvi.SubItems.Add(item.phoneNumber);
                lvi.SubItems.Add(item.nameAcc);
                lv_ListReaders.Items.Add(lvi);
            }
            lbl_SumNumber.Text = lv_ListReaders.Items.Count.ToString();
        }

        private void txt_Search_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using DAL;
using BLL;
using DTO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            if (cb_BorrowBook.Checked)
            {
                lv_Report.Visible = true;
                lv_Acc.Visible = false;
                Report_BLL rpBLL = new Report_BLL();
                List<BorrowCard> lbc = rpBLL.ShowBorrowCard();
                lv_Report.Items.Clear();
                foreach (BorrowCard bc in lbc)
                {
                    ListViewItem item = new ListViewItem(bc.idcart);
                    item.SubItems.Add(bc.namebook);
                    item.SubItems.Add(bc.idbook);
                    item.SubItems.Add(bc.category);
                    item.SubItems.Add(bc.dateborrow);
                    item.SubItems.Add(bc.dateReturn);
                    item.SubItems.Add(bc.bookstatus);
                    lv_Report.Items.Add(item);
                }
                int countSum = lv_Report.Items.Count;
                lbl_SumNumber.Text = "Tổng số: " + countSum;
            }
            else if (cb_BookLate.Checked)
            {
                lv_Report.Visible = true;
                lv_Acc.Visible = false;
                Report_BLL rpBLL = new Report_BLL();
                List<BorrowCard> lbc = rpBLL.ShowBookLate();
                lv_Report.Items.Clear();
                foreach (BorrowCard bc in lbc)
                {
                    ListViewItem item = new ListViewItem(bc.idcart);
                    item.SubItems.Add(bc.namebook);
                    item.SubItems.Add(bc.idbook);
                    item.SubItems.Add(bc.category);
                    item.SubItems.Add(bc.dateborrow);
                    item.SubItems.Add(bc.dateReturn);
                    item.SubItems.Add(bc.bookstatus);
                    lv_Report.Items.Add(item);
                }
                int countSum = lv_Report.Items.Count;
                lbl_SumNumber.Text = "Tổng số: " + countSum;
            }
            else if (cb_Reader.Checked)
            {
                lv_Report.Visible = false;
                lv_Acc.Visible = true;
                Report_BLL rpBLL = new Report_BLL();
                List<Accounts> lsAcc = rpBLL.showInforAccount();
                lv_Acc.Items.Clear();
                foreach (Accounts acc in lsAcc)
                {
                    ListViewItem lsvAcc = new ListViewItem(acc.Ten_TK);
                    lsvAcc.SubItems.Add(acc.password);
                    lv_Acc.Items.Add(lsvAcc);
                }


                int countSum = lv_Acc.Items.Count;
                lbl_SumNumber.Text = "Tổng số: " + countSum;
            }
            else if (cb_BookReturn.Checked)
            {
                Report_BLL rpBLL = new Report_BLL();
                List<BorrowCard> lbc = rpBLL.ShowBookReturned();
                lv_Report.Items.Clear();
                foreach (BorrowCard bc in lbc)
                {
                    ListViewItem item = new ListViewItem(bc.idcart);
                    item.SubItems.Add(bc.namebook);
                    item.SubItems.Add(bc.idbook);
                    item.SubItems.Add(bc.category);
                    item.SubItems.Add(bc.dateborrow);
                    item.SubItems.Add(bc.dateReturn);
                    item.SubItems.Add(bc.bookstatus);
                    lv_Report.Items.Add(item);
                }
                int countSum = lv_Report.Items.Count;
                lbl_SumNumber.Text = "Tổng số: " + countSum;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void lv_Acc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_ToExcel_Click(object sender, EventArgs e)
        {
            if(txtBookName.Text.Length > 0)
            {
                ExportExcel();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên file excel!");
            }
        }
        private void ExportExcel()
        {
            try
            {
                if (cb_BorrowBook.Checked  || cb_BookReturn.Checked  || cb_BookLate.Checked )
                {
                    //lvPDF is nothing but the listview control name
                    string[] st = new string[lv_Report.Columns.Count];
                    DirectoryInfo di = new DirectoryInfo(@"E:\Lập trình .NET\Bài tập lớn .Net\");
                    if (di.Exists == false)
                        di.Create();
                    StreamWriter sw = new StreamWriter(@"E:\Lập trình .NET\Bài tập lớn .Net\" + txtBookName.Text.Trim() + ".xls", false);
                    sw.AutoFlush = true;
                    for (int col = 0; col < lv_Report.Columns.Count; col++)
                    {
                        sw.Write("\t" + lv_Report.Columns[col].Text.ToString());
                    }

                    int rowIndex = 1;
                    int row = 0;
                    string st1 = "";
                    for (row = 0; row < lv_Report.Items.Count; row++)
                    {
                        if (rowIndex <= lv_Report.Items.Count)
                            rowIndex++;
                        st1 = "\n";
                        for (int col = 0; col < lv_Report.Columns.Count; col++)
                        {
                            st1 = st1 + "\t" + "'" + lv_Report.Items[row].SubItems[col].Text.ToString();
                        }
                        sw.WriteLine(st1);
                    }
                    sw.Close();
                    FileInfo fil = new FileInfo(@"E:\Lập trình .NET\Bài tập lớn .Net\" + txtBookName.Text.Trim() + ".xls");
                    if (fil.Exists == true)
                        MessageBox.Show("Xuất file thành công!\nĐường dẫn file: E:\\Lập trình .NET\\Bài tập lớn .Net\\" + txtBookName.Text.Trim() + ".xls ", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cb_Reader.Checked )
                {
                    //lvPDF is nothing but the listview control name
                    string[] st = new string[lv_Acc.Columns.Count];
                    DirectoryInfo di = new DirectoryInfo(@"E:\Lập trình .NET\Bài tập lớn .Net\");
                    if (di.Exists == false)
                        di.Create();
                    StreamWriter sw = new StreamWriter(@"E:\Lập trình .NET\Bài tập lớn .Net\" + txtBookName.Text.Trim() + ".xls", false);
                    sw.AutoFlush = true;
                    for (int col = 0; col < lv_Acc.Columns.Count; col++)
                    {
                        sw.Write("\t" + lv_Acc.Columns[col].Text.ToString());
                    }

                    int rowIndex = 1;
                    int row = 0;
                    string st1 = "";
                    for (row = 0; row < lv_Acc.Items.Count; row++)
                    {
                        if (rowIndex <= lv_Acc.Items.Count)
                            rowIndex++;
                        st1 = "\n";
                        for (int col = 0; col < lv_Acc.Columns.Count; col++)
                        {
                            st1 = st1 + "\t" + "'" + lv_Acc.Items[row].SubItems[col].Text.ToString();
                        }
                        sw.WriteLine(st1);
                    }
                    sw.Close();
                    FileInfo fil = new FileInfo(@"E:\Lập trình .NET\Bài tập lớn .Net\" + txtBookName.Text.Trim() + ".xls");
                    if (fil.Exists == true)
                        MessageBox.Show("Xuất file thành công!\nĐường dẫn file: E:\\Lập trình .NET\\Bài tập lớn .Net\\" + txtBookName.Text.Trim() + ".xls ", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

    }
}

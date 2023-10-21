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
    public partial class DetailBorrmow : Form
    {
        public DetailBorrmow()
        {
            InitializeComponent();
        }
        string cardID = BorrowCard_GUI.cardID;
        string nameUser = BorrowCard_GUI.nameUser;
        string phoneNumber = BorrowCard_GUI.phoneNumber;
        private void DetailBorrmow_Load(object sender, EventArgs e)
        {
            BorrowCard_child_BLL cardBLL = new BorrowCard_child_BLL();
            List<Book> listBook = cardBLL.showDetailBLL(cardID);
            lbl_cardID.Text = cardID;
            lbl_nameUser.Text = nameUser;
            lbl_phoneNumber.Text = phoneNumber;

            foreach (Book item in listBook)
            {
                ListViewItem lsv = new ListViewItem(item.idbook);
                lsv.SubItems.Add(item.namebook);
                lsv.SubItems.Add(item.category);
                lsv.SubItems.Add(item.authorName);
                lsv.SubItems.Add(item.dateBorrow);
                lsv.SubItems.Add(item.dateReturn);
                lsv.SubItems.Add(item.amount);

                lst_detailBr.Items.Add(lsv);
            }
        }
    }
}

using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Muon_Sach_User_BLL
    {
        Muon_Sach_User_DALL msuDAL = new Muon_Sach_User_DALL();
        public Reader ShowInfoReader(string tentk)
        {
            return msuDAL.GetInfoReader(tentk);
        }
        public Book ShowInfoBook(string idbook)
        {
            return msuDAL.GetInfoBook(idbook);
        }
        // Lấy mã phiếu
        public string GetIDCard()
        {
            return msuDAL.IdCard();
        }
        //
        public bool AddBorrowCard(BorrowCard bc)
        {
            return msuDAL.AddBorrowCard(bc);
        }

        public bool updateAmountBLL(string idBook)
        {
            return msuDAL.updateAmount(idBook);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Report_BLL
    {
        Report_DAL rpDAL = new Report_DAL();
        public List<BorrowCard> ShowBorrowCard()
        {
            return rpDAL.ShowBorrowCard();
        }

        public List<BorrowCard> ShowBookLate()
        {
            return rpDAL.ShowBookLate();
        }
        public List<BorrowCard> ShowBookReturned()
        {
            return rpDAL.ShowBookReturned();
        }

        public List<Accounts> showInforAccount()
        {

            return rpDAL.GetInfoAcc();
        }
    }
}

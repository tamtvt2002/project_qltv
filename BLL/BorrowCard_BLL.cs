using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class BorrowCard_BLL
    {
        BorrowCard_DAL bcDAL = new BorrowCard_DAL();
        public List<BorrowCard> ShowBorrowCard()
        {
            return bcDAL.ShowBorrowCard();
        }
        public bool AddBorrowCard(BorrowCard bc, string idCard)
        {
            return bcDAL.AddBorrowCard(bc, idCard);
        }

        // Lấy mã khách hàng vào ccb
        public List<Reader> AddIDReader()
        {
            return bcDAL.AddIdReader();
        }

        // Lấy mã nhân viên vào ccb
        public List<Reader> AddIDStaff()
        {
            return bcDAL.AddIdStaff();
        }

        // Lấy mã sách vào ccb
        public List<Reader> AddIDBook()
        {
            return bcDAL.AddIdBook();
        }

        // Lấy mã phiếu
        public string GetIDCard()
        {
            return bcDAL.IdCard();
        }

        // Sửa phiếu mượn trả
        //public bool UpdateBorrowcard(BorrowCard bc)
        //{
        //    return bcDAL.FixBorrowcard(bc);
        //}



        // Xóa 
        public bool DeLeteBorrowCard(BorrowCard bc)
        {
            return bcDAL.DeleteBorrowCard(bc);
        }
        
        public bool detailPayBLL(List<BorrowCard> book,string idCard, BorrowCard bc)
        {
            return bcDAL.detailPayDAL(book, idCard,bc);
        }

        public List<Book> updateAmountBookBLL(string idCard)
        {
            return bcDAL.updateAmountBook(idCard);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BorrowCard_child_BLL
    {
        BorrowCard_child_DAL cardChild = new BorrowCard_child_DAL();
        public List<Book> show()
        {
            return cardChild.showListBook();
        }

        public List<Book> showDetailBLL(string cardID)
        {
            return cardChild.showDetailBook(cardID);
        }

        public List<Book> searchCu(string search)
        {
            return cardChild.searchcu(search);
        }
        //public bool listBookBorrowBLL(List<BorrowCard> list, string idBook)
        //{
        //    return cardChild.addBorrowBook(list,idBook);
        //}

        //public bool AddBLL(string idBook)
        //{
        //    return cardChild.add(idBook);
        //}
        //public string createIDBLL()
        //{
        //    return cardChild.createID();
        //}
    }
}

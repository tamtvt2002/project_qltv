using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using DTO;
namespace BLL
{
    public class BookBLL
    {
        BooksDAL bk = new BooksDAL();


        public List<Book> showBook()
        {
            return bk.showListBook();
        }
        public bool add(Book b)
        {
            return bk.addBook(b);
        }
        public bool update(Book b)
        {
            return bk.updateBook(b);
        }
        public bool delete(Book b)
        {
            return bk.deleteBook(b);
        }

        public List<Book> searchBook(string search)
        {
            return bk.search(search);
        }

        public bool amountCa()
        {
            return bk.amountCacul();
        }
    }
}

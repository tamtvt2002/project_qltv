using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Main_user_BLL
    {
        Main_user_DAL mainDAL = new Main_user_DAL();
        public List<Book> ShowListBook()
        {
            return mainDAL.GetBooks();
        } public Book Search(string search, Book b)
        {
            return mainDAL.SearchBook(search, b);
        }
    }
}

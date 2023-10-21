using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BorrowCard:IBook
    {
        public string idcart { get; set; }
        public string idReader { get; set; }
        public string nameReader { get; set; }
        public string numberPhone { get; set; }
        public string classMate { get; set; }
        public string idStaff { get; set; }
        public string nameStaff { get; set; }
        public string idbook { get; set; }
        public string namebook { get; set; }
        public string category { get; set; }
        public string dateborrow { get; set; }
        public string dateReturn { get; set; }
        public string bookstatus { get; set; }
        public string returned { get; set; }
        public int amount { get; set; }
        public int DateLate { get; set; }
    }
}

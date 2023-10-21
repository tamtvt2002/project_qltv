using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Book:IBook
    {
        public string idbook { get; set; }
        public string namebook { get; set; }
        public string authorName { get; set; }
        public string category { get; set; }
        public string nxbName { get; set; }
        public string nbxYear { get; set; }
        public string status { get; set; }
        public string amount { get; set; }
        public string da_muon { get; set; }
        public string ton_kho { get; set; }
        public string dateBorrow { get; set; }
        public string dateReturn { get; set;}
    }
}

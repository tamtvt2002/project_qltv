using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Reader:IPerson
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string classMate { get; set; }
        public string phoneNumber { get; set; }
        public string nameAcc { get; set; }
       
    }
}

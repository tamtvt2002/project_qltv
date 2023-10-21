using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal interface IBook
    {
         string idbook { get; set; }
         string namebook { get; set; }
         string category { get; set; }
    }
}

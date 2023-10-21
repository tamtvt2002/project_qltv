using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class Readers_BLL
    {
        Reader_DAL rdDAL = new Reader_DAL();
        // Hiển thị danh sách đọc giả
        public List<Reader> Show()
        {
            return rdDAL.ShowListReader();
        }
        // Thêm đọc giả
        public bool AddReader(Reader reader)
        {
            return rdDAL.AddReader(reader);
        }
        // Sửa đọc giả
        public bool UpdateReader(Reader reader)
        {
            return rdDAL.FixReader(reader);
        }

        // Xóa đọc giả

        public bool DeleteReader(Reader reader)
        {
            return rdDAL.DeleteReader(reader);
        }

        // Tìm kiếm độc giả
        public List<Reader> SearchReader(string tmp)
        {
            return rdDAL.SearchReader(tmp);
        }
        // Lấy mã đọc giả
        public string GetIdReader()
        {
            return rdDAL.GetIdReader();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL 
{
    public class Reader_DAL : ConnectToSql
    {
        // Hiển thị danh sách đọc giả
        public List<Reader> ShowListReader()
        {
            
            List<Reader> ds = new List<Reader>();
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Select_DocGia";
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string ma = reader.GetString(0);
                string ten = reader.GetString(1);
                string lop = reader.GetString(2);
                string sdt = reader.GetString(3);
                string tentk;
                if (!reader.IsDBNull(4))
                {
                    tentk = reader.GetString(4);
                    // Thực hiện xử lý với giá trị tentk
                }
                else
                {
                    // Xử lý trường hợp cột thứ tư là null
                    tentk = "";
                }
                Reader rd = new Reader();
                rd.ID = ma;
                rd.name = ten;
                rd.classMate = lop;
                rd.phoneNumber = sdt;
                rd.nameAcc = tentk;
                ds.Add(rd);
            }
            reader.Close();
            return ds;

        }
        // Thêm độc giả trực tiếp
        public bool AddReader(Reader reader)
        {
            openConnection();
            // Tạo mã độc giả tự động
            SqlCommand cmd1 = new SqlCommand("GetMaxMaDG", sqlCon);
            cmd1.CommandType= CommandType.StoredProcedure;
            string lastestID = (string)cmd1.ExecuteScalar();

            // Tạo mã độc giả tiếp theo
            int nextID = int.Parse(lastestID.Substring(2)) + 1;
            string nextID1 = "KH" + nextID.ToString("000");

            // Kiểm tra xem mã độc giả tiếp theo đã được sử dụng chưa
            int count = 0;
            do
            {
                SqlCommand cmd2 = new SqlCommand("Check_DocGia_Exist", sqlCon);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@madg", nextID1);
                count = (int)cmd2.ExecuteScalar();

                // Nếu mã đã được sử dụng, tăng giá trị số thứ tự lên và tạo mã mới
                if (count > 0)
                {
                    nextID++;
                    nextID1 = "KH" + nextID.ToString("000");
                }
            }
            while (count > 0);

            

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_DocGia";
            cmd.Parameters.AddWithValue("@madg", nextID1);
            SqlParameter parName = new SqlParameter("@tendg", SqlDbType.NVarChar);
            parName.Value = reader.name;
            cmd.Parameters.Add(parName);
            SqlParameter parClass = new SqlParameter("@lop", SqlDbType.Char);
            parClass.Value = reader.classMate;
            cmd.Parameters.Add(parClass);
            SqlParameter parSDT = new SqlParameter("@sdt", SqlDbType.Char);
            parSDT.Value = reader.phoneNumber;
            cmd.Parameters.Add(parSDT);
            cmd.Connection = sqlCon;
            int kt = cmd.ExecuteNonQuery();
            if(kt>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        // Sửa độc giả
        public bool FixReader(Reader rd)
        {
            string id = rd.ID.Trim();
            string name = rd.name.Trim();
            string lop = rd.classMate.Trim();
            string sdt = rd.phoneNumber.Trim();
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Update_DocGia ";
            cmd.Parameters.AddWithValue("@ma", id);
            cmd.Parameters.AddWithValue("@ten", name);
            cmd.Parameters.AddWithValue("@lop", lop);
            cmd.Parameters.AddWithValue("@sdt", sdt);
            cmd.Connection = sqlCon;
            int k = cmd.ExecuteNonQuery();
            if(k>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Xóa đọc giả
        public bool DeleteReader(Reader rd)
        {
            string id = rd.ID.Trim();
            openConnection();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "Delete_TaiKhoan";
            cmd2.Parameters.AddWithValue("@ma", id);
            cmd2.Connection = sqlCon;
            int kq2 = cmd2.ExecuteNonQuery();
            SqlCommand cmd0 = new SqlCommand();
            cmd0.CommandType = CommandType.StoredProcedure;
            cmd0.CommandText = "Delete_ChiTietMuonTra_By_MaDG";
            cmd0.Parameters.AddWithValue("@ma", id);
            cmd0.Connection = sqlCon;
            int kq0 = cmd0.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "Delete_MuonTra_By_MaDG";
            cmd1.Parameters.AddWithValue("@ma", id);
            cmd1.Connection = sqlCon;
            int kq1 = cmd1.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Delete_DocGia ";
            cmd.Parameters.AddWithValue("@ma", id);
            cmd.Connection = sqlCon;
            int kq = cmd.ExecuteNonQuery();
            if(kq2 >0)
            {
                if (kq1 > 0)
                {
                    if(kq>0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Tìm kiếm đọc giả
        public List<Reader> SearchReader(string search)
        {
            List<Reader> listReader = new List<Reader>();
            Reader rd = new Reader();
            string tmp = search.Trim();
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Search_DOC_GIA";
            cmd.Parameters.AddWithValue("@ma", tmp);
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                rd.ID = reader.GetString(0);
                rd.name = reader.GetString(1);
                rd.classMate = reader.GetString(2);
                rd.phoneNumber = reader.GetString(3);
                listReader.Add(rd);
            }
            reader.Close();
            return listReader;
        }

        // Lấy mã đọc giả
        public string GetIdReader()
        {
            openConnection();
            // Tạo mã độc giả tự động
            SqlCommand cmd1 = new SqlCommand("getFirstMaDG", sqlCon);
            cmd1.CommandType = CommandType.StoredProcedure;
            string lastestID = (string)cmd1.ExecuteScalar();

            // Tạo mã độc giả tiếp theo
            int nextID = int.Parse(lastestID.Substring(2)) + 1;
            string nextID1 = "KH" + nextID.ToString("000");

            // Kiểm tra xem mã độc giả tiếp theo đã được sử dụng chưa
            int count = 0;
            do
            {
                SqlCommand cmd2 = new SqlCommand("count_DocGia", sqlCon);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@madg", nextID1);
                count = (int)cmd2.ExecuteScalar();

                // Nếu mã đã được sử dụng, tăng giá trị số thứ tự lên và tạo mã mới
                if (count > 0)
                {
                    nextID++;
                    nextID1 = "KH" + nextID.ToString("000");
                }
            }
            while (count > 0);
            return nextID1;
        }
    }
}

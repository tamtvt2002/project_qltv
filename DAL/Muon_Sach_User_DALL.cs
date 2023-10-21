using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class Muon_Sach_User_DALL : ConnectToSql
    {
        // Lấy thông tin đọc giả theo account
        public Reader GetInfoReader(string madocgia)
        {
            Reader rd = null;
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetDocGiaByTenTK";
            cmd.Parameters.AddWithValue("@tentk", madocgia);
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                rd = new Reader();
                rd.ID = reader.GetString(reader.GetOrdinal("Ma_DG"));
                rd.name = reader.GetString(reader.GetOrdinal("Ten_DG"));
                rd.classMate = reader.GetString(reader.GetOrdinal("Lop"));
                rd.phoneNumber = reader.GetString(reader.GetOrdinal("So_DT"));
            }
            reader.Close();
            return rd;
        }

        // Lấy thông tin sách theo id sách
        public Book GetInfoBook(string idbook)
        {
            Book b = null;
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetBookInfo";
            cmd.Parameters.AddWithValue("@masach", idbook);
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                b = new Book();
                b.namebook = reader.GetString(reader.GetOrdinal("TenSach"));
                b.category = reader.GetString(reader.GetOrdinal("Ten_TL"));
            }
            return b;
        }
        // Tự động điền phiếu
        public string IdCard()
        {
            openConnection();
            // Tạo mã phiếu mượn tiếp theo
            SqlCommand cmd1 = new SqlCommand("getLatestMaMT", sqlCon);
            cmd1.CommandType = CommandType.StoredProcedure;
            string lastestID = (string)cmd1.ExecuteScalar();
            int nextID = int.Parse(lastestID.Substring(2)) + 1;
            string nextID1 = "MT" + nextID.ToString("000");

            // Kiểm tra xem mã phiếu mượn tiếp theo đã được sử dụng chưa
            int count = 0;
            do
            {
                SqlCommand cmd2 = new SqlCommand("CountMuonTraByIdMT", sqlCon);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@idmt", nextID1);
                count = (int)cmd2.ExecuteScalar();

                // Nếu mã đã được sử dụng, tăng giá trị số thứ tự lên và tạo mã mới
                if (count > 0)
                {
                    nextID++;
                    nextID1 = "MT" + nextID.ToString("000");
                }
            }
            while (count > 0);
            return ("Mã phiếu: " + nextID1);
        }
        //
        public bool AddBorrowCard(BorrowCard bc)
        {
            openConnection();
            // Tạo mã phiếu mượn tiếp theo
            SqlCommand cmd1 = new SqlCommand("GetLastMaMT", sqlCon);
            string lastestID = (string)cmd1.ExecuteScalar();
            int nextID = int.Parse(lastestID.Substring(2)) + 1;
            string nextID1 = "MT" + nextID.ToString("000");

            // Kiểm tra xem mã phiếu mượn tiếp theo đã được sử dụng chưa
            int count = 0;
            do
            {
                SqlCommand cmd0 = new SqlCommand("CountMuonTraByIdMT", sqlCon);
                cmd0.CommandType = CommandType.StoredProcedure;
                cmd0.Parameters.AddWithValue("@idmt", nextID1);
                count = (int)cmd0.ExecuteScalar();

                // Nếu mã đã được sử dụng, tăng giá trị số thứ tự lên và tạo mã mới
                if (count > 0)
                {
                    nextID++;
                    nextID1 = "MT" + nextID.ToString("000");
                }
            }
            while (count > 0);
            // Lấy tên độc giả, lớp, sdt theo mã độc giả
            string madg = bc.idReader;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "GetDocGiaByID";
            cmd2.Parameters.AddWithValue("@madg", madg);
            cmd2.Connection = sqlCon;
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                bc.nameReader = reader.GetString(0);
                bc.classMate = reader.GetString(1);
                bc.numberPhone = reader.GetString(2);
            }
            reader.Close();

            // Lấy thông tin sách theo mã sách
            string idbook = bc.idbook;
            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.CommandText = "GetBookInfor";
            cmd3.Parameters.AddWithValue("@mas", idbook);
            cmd3.Connection = sqlCon;
            SqlDataReader readerInfoBook = cmd3.ExecuteReader();
            while (readerInfoBook.Read())
            {
                bc.namebook = readerInfoBook.GetString(0);
                bc.category = readerInfoBook.GetString(1);
                bc.bookstatus = readerInfoBook.GetString(2);
            }
            readerInfoBook.Close();
            string returned = bc.returned;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Insert_MuonTra";
            cmd.Parameters.AddWithValue("@idmt", nextID1);
            cmd.Parameters.AddWithValue("@madg", madg);
            cmd.Parameters.AddWithValue("@tendg", bc.nameReader);
            cmd.Parameters.AddWithValue("@lop", bc.classMate);
            cmd.Parameters.AddWithValue("@sdt", bc.numberPhone);
            cmd.Parameters.AddWithValue("@manv", "NV002");
            cmd.Parameters.AddWithValue("@tennv", "Online");
            cmd.Parameters.AddWithValue("@soluong", 1);
            cmd.Connection = sqlCon;
            int kq = cmd.ExecuteNonQuery();

            SqlCommand cmd4 = new SqlCommand();
            cmd4.CommandType = CommandType.StoredProcedure;
            cmd4.CommandText = "Insert_ChiTietMuonTra";
            cmd4.Parameters.AddWithValue("@ms", idbook);
            cmd4.Parameters.AddWithValue("@mmt", nextID1);
            cmd4.Parameters.AddWithValue("@ngaymuon", bc.dateborrow);
            cmd4.Parameters.AddWithValue("@ngaytra", bc.dateReturn);
            cmd4.Parameters.AddWithValue("@tts", bc.bookstatus);
            cmd4.Parameters.AddWithValue("@datra", "Chưa trả");
            cmd4.Parameters.AddWithValue("@sl", 1);
            cmd4.Connection = sqlCon;
            int kq1 = cmd4.ExecuteNonQuery();

            if (kq > 0)
            {
                if (kq1 > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool updateAmount(string idBook)
        {

            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "Update_DaMuon_Sach";
            cmd1.Parameters.AddWithValue("@MaSach", idBook);
            cmd1.Connection = sqlCon;
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "UPDATE Sach SET Ton_Kho = CAST(So_Luong AS INT) - CAST(Da_Muon AS INT)";
            cmd2.Connection = sqlCon;
            int update = cmd2.ExecuteNonQuery();
            return true;
        }
    }

}

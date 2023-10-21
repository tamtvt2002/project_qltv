using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class BorrowCard_DAL:ConnectToSql
    {

       
        // Hiển thị danh sách phiếu mượn
        public List<BorrowCard> ShowBorrowCard()
        {
            List<BorrowCard> dsbc = new List<BorrowCard>();
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "getMuonTra ";
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string maMT = reader.GetString(0);
                string tendg = reader.GetString(1);
                string lop = reader.GetString(2);
                string sdt = reader.GetString(3);
                string tennv = reader.GetString(4);
                int soluong = reader.GetInt32(5);

                BorrowCard bc = new BorrowCard();
                bc.idcart = maMT;
                bc.nameReader = tendg;
                bc.classMate = lop;
                bc.numberPhone = sdt;

                bc.nameStaff = tennv;
                bc.amount = soluong;
                dsbc.Add(bc);
            }
            reader.Close();
            return dsbc;
        }
        // Lấy mã đọc giả
        public List<Reader> AddIdReader()
        {
            List<Reader> readers = new List<Reader>();
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getDocGia";
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Reader reader1 = new Reader();
                reader1.ID = reader.GetString(0);
                readers.Add(reader1);
            }
            reader.Close();
            closeConnection();
            return readers;
        }
        // Lấy mã nhân viên
        public List<Reader> AddIdStaff()
        {
            List<Reader> readers = new List<Reader>();
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetMaNV";
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Reader reader1 = new Reader();
                reader1.ID = reader.GetString(0);
                readers.Add(reader1);
            }
            reader.Close();
            closeConnection();
            return readers;
        }

        // Lấy mã sách
        public List<Reader> AddIdBook()
        {
            List<Reader> readers = new List<Reader>();
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_GetAllMaSach";
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Reader reader1 = new Reader();
                reader1.ID = reader.GetString(0);
                readers.Add(reader1);
            }
            reader.Close();
            closeConnection();
            return readers;
        }

        public string AutoID(string code, string tableName, string idColumn)
        {
            int count = 0;
            string nextID1 = "";
            openConnection();
            SqlCommand cmd0 = new SqlCommand("Select count(*) from " + tableName, sqlCon);
            int check = (int)cmd0.ExecuteScalar();
            if (check > 0)
            {
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 " + idColumn + " FROM " + tableName + " ORDER BY " + idColumn + " DESC", sqlCon);
                string lastestID = (string)cmd.ExecuteScalar();
                int nextID = int.Parse(lastestID.Substring(2)) + 1;
                nextID1 = code + nextID.ToString("000");
                do
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM " + tableName + " WHERE " + idColumn + " = @madg";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@madg", nextID1);
                    count = (int)cmd.ExecuteScalar();

                    // Nếu mã đã được sử dụng, tăng giá trị số thứ tự lên và tạo mã mới
                    if (count > 0)
                    {
                        nextID++;
                        nextID1 = code + nextID.ToString("000");
                    }
                }
                while (count > 0);

            }
            else
            {
                int nextID = 1;
                nextID1 = code + nextID.ToString("000");
            }
            return nextID1;
        }

        public bool AddBorrowCard(BorrowCard bc, string idCard)
        {
            openConnection();
            string nextID1 = "";
            SqlCommand cmd0 = new SqlCommand("CountMuonTra", sqlCon);
            cmd0.CommandType = CommandType.StoredProcedure;
            int check = (int)cmd0.ExecuteScalar();

            if(check == 0)
            {
                nextID1 = AutoID("MT", "MUON_TRA", "Ma_MT");
            }
            else
            {
                // Tạo mã phiếu mượn tiếp theo
                SqlCommand cmd1 = new SqlCommand("getLatestMaMT", sqlCon);
                cmd1.CommandType = CommandType.StoredProcedure;
                string lastestID = (string)cmd1.ExecuteScalar();
                int nextID = int.Parse(lastestID.Substring(2)) + 1;
                nextID1 = "MT" + nextID.ToString("000");

                // Kiểm tra xem mã phiếu mượn tiếp theo đã được sử dụng chưa
                int count = 0;
                do
                {
                    SqlCommand cmdcheck = new SqlCommand("CountMuonTraByIdMT",sqlCon);
                    cmdcheck.CommandType = CommandType.StoredProcedure;
                    cmdcheck.Parameters.AddWithValue("@idmt", nextID1);
                    count = (int)cmdcheck.ExecuteScalar();

                    // Nếu mã đã được sử dụng, tăng giá trị số thứ tự lên và tạo mã mới
                    if (count > 0)
                    {
                        nextID++;
                        nextID1 = "MT" + nextID.ToString("000");
                    }
                }
                while (count > 0);
            }
                 
            // Lấy tên độc giả, lớp, sdt theo mã độc giả
            string madg = bc.idReader;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "GetDocGiaInfoById";
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
            // Lấy tên nhân viên theo mã nhân viên
            string idStaff = bc.idStaff;
            SqlCommand cmdibbook = new SqlCommand();
            cmdibbook.CommandType = CommandType.StoredProcedure;
            cmdibbook.CommandText = "GetTenNVById";
            cmdibbook.Parameters.AddWithValue("@manv", idStaff);
            cmdibbook.Connection = sqlCon;
            SqlDataReader readeridbook = cmdibbook.ExecuteReader();
            while (readeridbook.Read())
            {
                 bc.nameStaff = readeridbook.GetString(0);
            }
            readeridbook.Close();
 

            SqlCommand cmdsl = new SqlCommand();
            cmdsl.CommandType = CommandType.StoredProcedure;
            cmdsl.CommandText = "SumSoluongByIdMT";
            cmdsl.Parameters.AddWithValue("@mamt", idCard);
            cmdsl.Connection = sqlCon;
            int amount = (int)cmdsl.ExecuteScalar();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateMuonTra";


            cmd.Parameters.AddWithValue("@mamt", idCard);
            cmd.Parameters.AddWithValue("@madg", madg);
            cmd.Parameters.AddWithValue("@tendg", bc.nameReader);
            cmd.Parameters.AddWithValue("@lop", bc.classMate);
            cmd.Parameters.AddWithValue("@sdt", bc.numberPhone);
            cmd.Parameters.AddWithValue("@manv", idStaff);
            cmd.Parameters.AddWithValue("@tennv", bc.nameStaff);
            cmd.Parameters.AddWithValue("@soluong", amount);
           
            cmd.Connection = sqlCon;
            int kq = cmd.ExecuteNonQuery();
          

            if (kq > 0)
            {
                return true;
            }
            else return false;
        }

        // Lấy mã phiếu
        public string IdCard()
        {
            openConnection();
            // Tạo mã phiếu mượn tiếp theo
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CountMuonTra";
            cmd.Connection = sqlCon;
            int check = (int)cmd.ExecuteScalar();
            
            string lastestID = "";
            string nextID1 = "";



            SqlCommand cmd1 = new SqlCommand("GetLastMaMT", sqlCon);
            cmd1.CommandType = CommandType.StoredProcedure;
            lastestID = (string)cmd1.ExecuteScalar();
            int nextID = int.Parse(lastestID.Substring(2)) + 1;
            nextID1 = "MT" + nextID.ToString("000");

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
       
        public List<Book> updateAmountBook(string cardID)
        {
            List<Book> listbook = new List<Book>();
            
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetChiTietMuonTraByMaMT";
            cmd.Parameters.AddWithValue("@mamt", cardID);
            cmd.Connection = sqlCon;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Book book = new Book();
                book.idbook = reader.GetString(0);
                book.amount = reader.GetInt32(6).ToString();
                listbook.Add(book);
            }
            
            reader.Close();

            
            foreach (Book b in listbook)
            {
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "UpdateSachAfterMuon";
                cmd1.Parameters.AddWithValue("@muon",int.Parse(b.amount.Trim()));
                cmd1.Parameters.AddWithValue("@ms",b.idbook.Trim());
                cmd1.Connection = sqlCon;
                cmd1.ExecuteNonQuery();
            }

            return listbook;
        }
        public bool DeleteBorrowCard(BorrowCard bc)
        {
            string id = bc.idcart.Trim();
            openConnection();

            SqlCommand cmd0 = new SqlCommand();
            cmd0.CommandType = CommandType.StoredProcedure;
            cmd0.CommandText = "DeleteChiTietMuonTraByMaMT";
            cmd0.Parameters.AddWithValue("@ma", id);
            cmd0.Connection = sqlCon;
            cmd0.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteMuonTra";
            cmd.Parameters.AddWithValue("@ma", id);
            cmd.Connection = sqlCon;
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool detailPayDAL(List<BorrowCard> listBook, string idCard, BorrowCard bc)
        {
            openConnection();

            SqlCommand cmd0 = new SqlCommand();
            cmd0.CommandType = CommandType.StoredProcedure;
            cmd0.CommandText = "InsertMuonTra";
            cmd0.Parameters.AddWithValue("@maMT", idCard);
            cmd0.Connection = sqlCon;
            cmd0.ExecuteNonQuery();

            

            foreach (BorrowCard book in listBook)
            {
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "InsertChiTietMuonTra";
                cmd1.Parameters.AddWithValue("@ms", book.idbook);
                cmd1.Parameters.AddWithValue("@mmt", idCard);
                cmd1.Parameters.AddWithValue("@nm", bc.dateborrow);
                cmd1.Parameters.AddWithValue("@nt", bc.dateReturn);
                cmd1.Parameters.AddWithValue("@tts", bc.bookstatus);
                cmd1.Parameters.AddWithValue("@dt", bc.DateLate);
                cmd1.Connection = sqlCon;
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "UPDATE_SoLuong_ChiTietMuonTra";
                cmd2.Parameters.AddWithValue("@MaSach", book.idbook);
                cmd2.Parameters.AddWithValue("@MaMT", idCard);
                cmd2.Parameters.AddWithValue("@SoLuong", book.amount);
                cmd2.Connection = sqlCon;
                cmd2.ExecuteNonQuery();

                SqlCommand cmd6 = new SqlCommand();
                cmd6.CommandType = CommandType.StoredProcedure;
                cmd6.CommandText = "UpdateSoLuongTonKho";
                cmd6.Parameters.AddWithValue("@SoLuong", book.amount);
                cmd6.Parameters.AddWithValue("@MaSach", book.idbook);
                cmd6.Connection = sqlCon;
                cmd6.ExecuteNonQuery();

                SqlCommand cmd7 = new SqlCommand();
                cmd7.CommandType = CommandType.StoredProcedure;
                cmd7.CommandText = "Update_DaMuon";
                cmd7.Parameters.AddWithValue("@sluong", book.amount);
                cmd7.Parameters.AddWithValue("@MaSach", book.idbook);
                cmd7.Connection = sqlCon;
                cmd7.ExecuteNonQuery();
             
            }
            return true;
        }

    }
}

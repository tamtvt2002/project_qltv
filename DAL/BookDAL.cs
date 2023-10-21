using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Security.Claims;
using System.Xml.Linq;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace DAL
{
    public class BooksDAL : ConnectToSql
    {

        public string AutoID(string code, string tableName, string idColumn)
        {
            int count = 0;
            openConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "autoID";
            cmd.Parameters.AddWithValue("@tableName", tableName);
            cmd.Parameters.AddWithValue("@idColumn", idColumn);
            cmd.Connection = sqlCon;
            string lastestID = (string)cmd.ExecuteScalar();
            int nextID = int.Parse(lastestID.Substring(2)) + 1;
            string nextID1 = code + nextID.ToString("000");
            do
            {
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "count_ID";
                cmd1.Parameters.AddWithValue("@tableName", tableName);
                cmd1.Parameters.AddWithValue("@idColumn", idColumn);
                cmd1.Parameters.AddWithValue("@madg", nextID1);
                cmd1.Connection = sqlCon;
                count = (int)cmd1.ExecuteScalar();

                // Nếu mã đã được sử dụng, tăng giá trị số thứ tự lên và tạo mã mới
                if (count > 0)
                {
                    nextID++;
                    nextID1 = code + nextID.ToString("000");
                }
            }
            while (count > 0);
            return nextID1;
            
        }



        public bool amountCacul()
        {
            // select COUNT(*) from MUON_TRA where MaSach = @maSach
            openConnection();
            int total = 0;
            int borrow = 0;
            int rest = 0;

            Book b1 = new Book();
            SqlCommand cmdb = new SqlCommand();
            cmdb.CommandType = CommandType.StoredProcedure;
            cmdb.CommandText = "selectBook";
            cmdb.Connection = sqlCon;
            cmdb.ExecuteNonQuery();
            SqlDataReader reader = cmdb.ExecuteReader();

            while(reader.Read())
            {
                b1.idbook = reader.GetString(0);
                //total = int.Parse(b1.amount);
            }
            reader.Close();


            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "count_CHI_TIET_MUON_TRA";
            cmd.Parameters.AddWithValue("@maSach", b1.idbook);
            cmd.Connection = sqlCon;
            SqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                borrow = reader1.GetInt32(0);
            }
            reader1.Close();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "UpdateDaMuon";
            cmd1.Parameters.AddWithValue("@maSach", b1.idbook);
            cmd1.Parameters.AddWithValue("@Da_Muon", borrow);
            cmd1.Connection = sqlCon;
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand();
            string query = "getAmountBook";
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = query;
            cmd2.Parameters.AddWithValue("ms", b1.idbook);
            cmd2.Connection= sqlCon;
            cmd2.ExecuteNonQuery();
            SqlDataReader reader2= cmd2.ExecuteReader();
            while (reader2.Read())
            {
                rest = reader2.GetInt32(2);
            }
            reader2.Close();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.CommandText = "UpdateTonKho ";
            cmd3.Parameters.AddWithValue("@maSach", b1.idbook);
            cmd3.Parameters.AddWithValue("@tonKho", rest);
            cmd3.Connection = sqlCon;
            cmd3.ExecuteNonQuery();

            return true;
        }

        public List<Book> showListBook()
        {
            openConnection();
            List<Book> listBook = new List<Book>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_SACH_TG_TL";
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string ID = reader.GetString(0);
                string tenSach = "";
                string tacGia = "";
                string theLoai = "";
                string NXB = "";
                string namXB = DateTime.MinValue.ToString("dd-MM-yyyy");
                string tinhTrang = "";
                string soLuong = "";
                string daMuon = "";
                string tonKho = "";

                if (!reader.IsDBNull(1))
                {
                    tenSach = reader.GetString(1);
                }
                if (!reader.IsDBNull(3))
                {
                    tacGia = reader.GetString(3);
                }
                if (!reader.IsDBNull(5))
                {
                    theLoai = reader.GetString(5);
                }
                if (!reader.IsDBNull(7))
                {
                    NXB = reader.GetString(7);
                }
                if (!reader.IsDBNull(8))
                {
                    namXB = reader.GetString(8);
                }
                if (!reader.IsDBNull(9))
                {
                    tinhTrang = reader.GetString(9);
                }
                if (!reader.IsDBNull(10))
                {
                    soLuong = reader.GetString(10);
                                   
                }
                if (!reader.IsDBNull(11))
                {
                    daMuon = reader.GetString(11);

                }
                if (!reader.IsDBNull(12))
                {
                    tonKho = reader.GetString(12);
                }

                Book book = new Book();
                book.idbook = ID;
                book.namebook = tenSach;
                book.authorName = tacGia;
                book.category = theLoai;
                book.nxbName = NXB;
                book.nbxYear = namXB;
                book.status = tinhTrang;
                book.amount = soLuong;
                book.da_muon = daMuon.ToString();
                book.ton_kho= tonKho.ToString();
       

                listBook.Add(book);
            }
            reader.Close();
            return listBook;
        }

        public bool addBook(Book obj)
        {
            openConnection();

            string ID = AutoID("MS", "SACH", "MaSach");
            string tenSach = obj.namebook.Trim();
            string tacGia = obj.authorName.Trim();
            string theLoai = obj.category.Trim();
            string namXB = obj.nbxYear.Trim();
            string tenNXB = obj.nxbName.Trim();
            string soLuong = obj.amount.Trim();
            string daMuon = "0";

            string query = "count_book";
            SqlCommand cmd0 = new SqlCommand(query,sqlCon);
            cmd0.CommandType = CommandType.StoredProcedure;
            cmd0.Parameters.AddWithValue("@ten", tenSach);
            cmd0.Parameters.AddWithValue("@tenTL", theLoai);
            cmd0.Parameters.AddWithValue("@tenNXB", tenNXB);
            cmd0.Parameters.AddWithValue("@tenTg", tacGia);
            int check = (int)cmd0.ExecuteScalar();

            if (check == 0)
            {
                string idTG = AutoID("TG", "TAC_GIA", "Ma_TG");
                string idTL = AutoID("TL", "THE_LOAI", "Ma_TL");
                string maNXB = AutoID("XB", "NHA_XUAT_BAN", "Ma_NXB");

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Insert_TacGia ";
                cmd.Parameters.AddWithValue("@maTG", idTG);
                cmd.Parameters.AddWithValue("@tenTG", tacGia);
                cmd.Connection = sqlCon;
                int kqtg = cmd.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "Insert_THE_LOAI ";
                cmd1.Parameters.AddWithValue("@mtl", idTL);
                cmd1.Parameters.AddWithValue("@ttl", theLoai);
                cmd1.Connection = sqlCon;
                int kqtl = cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "insert_NXB ";
                cmd2.Parameters.AddWithValue("@maNXB", maNXB);
                cmd2.Parameters.AddWithValue("@tenNXB", tenNXB);
                cmd2.Connection = sqlCon;
                int kqnxb = cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand();
                cmd3.CommandType = CommandType.StoredProcedure;

                cmd3.CommandText = "InsertSach";
                cmd3.Parameters.AddWithValue("@masach", ID);
                cmd3.Parameters.AddWithValue("@tensach", tenSach);
                cmd3.Parameters.AddWithValue("@maTG", idTG);
                cmd3.Parameters.AddWithValue("@ttg", tacGia);

                cmd3.Parameters.AddWithValue("@mtl", idTL);
                cmd3.Parameters.AddWithValue("@ttl", theLoai);
                cmd3.Parameters.AddWithValue("@mnxb", maNXB);
                cmd3.Parameters.AddWithValue("@tnxb", tenNXB);


                cmd3.Parameters.AddWithValue("@namxb", namXB);
                cmd3.Parameters.AddWithValue("@tts", "Mới");
                cmd3.Parameters.AddWithValue("@soLuong", soLuong);
                cmd3.Parameters.AddWithValue("@daMuon", daMuon);
                cmd3.Parameters.AddWithValue("@tonKho", soLuong);
                cmd3.Connection = sqlCon;
                int kq = cmd3.ExecuteNonQuery();

                if (kqtg == 0)
                {
                    if (kqtl == 0)
                    {
                        if (kqnxb == 0)
                        {
                            if (kq == 0)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            else
            {
                SqlCommand cmd4 = new SqlCommand();
                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.CommandText = "find_MaSach_by_TenSach";
                cmd4.Parameters.AddWithValue("@tenSach",tenSach);
                cmd4.Connection = sqlCon;
                string oldId = (string)cmd4.ExecuteScalar();

                SqlCommand cmd5 = new SqlCommand();
                cmd5.CommandType = CommandType.StoredProcedure;
                cmd5.CommandText = "updateSoLuongSach";
                cmd5.Parameters.AddWithValue("@soluong", int.Parse(soLuong));
                cmd5.Parameters.AddWithValue("@MaSach", oldId);
                cmd5.Connection = sqlCon;
                cmd5.ExecuteNonQuery();

                SqlCommand cmd6 = new SqlCommand();
                cmd6.CommandType = CommandType.StoredProcedure;
                cmd6.CommandText = "update_Ton_Kho";
                cmd6.Parameters.AddWithValue("@soluong", int.Parse(soLuong));
                cmd6.Parameters.AddWithValue("@MaSach", oldId);
                cmd6.Connection = sqlCon;
                cmd6.ExecuteNonQuery();

            }
            return true;
        }
        public bool updateBook(Book obj)
        {

            string id = obj.idbook.Trim();
            string tenSach = obj.namebook.Trim();
            string tacGia = obj.authorName.Trim();
            string theLoai = obj.category.Trim();
            string namXB = obj.nbxYear.Trim();
            string trangThai = obj.status.Trim();
            string tenNXB = obj.nxbName.Trim();
            string soLuong = obj.amount.Trim();


            openConnection();
            string ms = obj.idbook.Trim();
            string maTacGia = "";
            string maTheLoai = "";
            string maNXB = "";

            SqlCommand cmd_Mtg = new SqlCommand();
            cmd_Mtg.CommandType = CommandType.StoredProcedure;
            cmd_Mtg.CommandText = "get_MaTG";
            cmd_Mtg.Parameters.AddWithValue("@ms", ms);
            cmd_Mtg.Connection = sqlCon;
            SqlDataReader reader = cmd_Mtg.ExecuteReader();
            while (reader.Read())
            {
                maTacGia = reader.GetString(0);
            }
            reader.Close();

            SqlCommand cmd_Mtl = new SqlCommand();
            cmd_Mtl.CommandType = CommandType.StoredProcedure;
            cmd_Mtl.CommandText = "GetMaTLFromSACH";
            cmd_Mtl.Parameters.AddWithValue("@ms", ms);
            cmd_Mtl.Connection = sqlCon;

            SqlDataReader reader1 = cmd_Mtl.ExecuteReader();
            while (reader1.Read())
            {
                maTheLoai = reader1.GetString(0);
            }
            reader1.Close();

            SqlCommand cmd_Mnxb = new SqlCommand();
            cmd_Mnxb.CommandType = CommandType.StoredProcedure;
            cmd_Mnxb.CommandText = "get_MaNXB";
            cmd_Mnxb.Parameters.AddWithValue("@ms", ms);
            cmd_Mnxb.Connection = sqlCon;

            SqlDataReader reader2 = cmd_Mnxb.ExecuteReader();
            while (reader2.Read())
            {
                maNXB = reader2.GetString(0);
            }
            reader2.Close();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "update_TenTG";
            cmd1.Parameters.AddWithValue("@mtg", maTacGia);
            cmd1.Parameters.AddWithValue("@ttg", tacGia);
            cmd1.Connection = sqlCon;
            int kqtg = cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "update_Ten_TL_by_MaTL";
            cmd2.Parameters.AddWithValue("@mtl", maTheLoai);
            cmd2.Parameters.AddWithValue("@ttl", theLoai);
            cmd2.Connection = sqlCon;
            int kqtl = cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.CommandText = "updateTenNXB";
            cmd3.Parameters.AddWithValue("@maNXB", maNXB);
            cmd3.Parameters.AddWithValue("@tenNXB", tenNXB);
            cmd3.Connection = sqlCon;
            int kqnxb = cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = new SqlCommand();
            cmd4.CommandType = CommandType.StoredProcedure;
            cmd4.CommandText = "UpdateSach";
            cmd4.Parameters.AddWithValue("@masach", id);
            cmd4.Parameters.AddWithValue("@tensach", tenSach);
            cmd4.Parameters.AddWithValue("@tenTG", tacGia);
            cmd4.Parameters.AddWithValue("@tenTL", theLoai);
            cmd4.Parameters.AddWithValue("@tenNXB", tenNXB);
            cmd4.Parameters.AddWithValue("@namXB", namXB);
            cmd4.Parameters.AddWithValue("@tinhtrang", trangThai);
            cmd4.Parameters.AddWithValue("@soLuong", soLuong);
            cmd4.Connection = sqlCon;

            int kq = cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "UPDATE Sach SET Ton_Kho = CAST(So_Luong AS INT) - CAST(Da_Muon AS INT)";
            cmd5.Connection = sqlCon;
            int update = cmd5.ExecuteNonQuery();

            if (kqtg > 0)
            {
                if(kqtl>0)
                {
                    if(kqnxb>0)
                    {
                        if(kq>0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public bool deleteBook(Book obj)
        {

            openConnection();
            string ms = obj.idbook.Trim();
            string maTacGia = "";
            string maTheLoai = "";
            string maNXB = "";
            // lấy mã tác giả từ bảng sách
            SqlCommand cmd_mtg = new SqlCommand();
            cmd_mtg.CommandType = CommandType.StoredProcedure;
            cmd_mtg.CommandText = "GetMaTGByMaSach";
            cmd_mtg.Parameters.AddWithValue("@ms", ms);
            cmd_mtg.Connection = sqlCon;

            SqlDataReader reader = cmd_mtg.ExecuteReader();
            while (reader.Read())
            {
                maTacGia = reader.GetString(0);
            }
            reader.Close();


            SqlCommand cmd_Mtl = new SqlCommand();
            cmd_Mtl.CommandType = CommandType.StoredProcedure;
            cmd_Mtl.CommandText = "GetMaTLByMaSach";
            cmd_Mtl.Parameters.AddWithValue("@ms", ms);
            cmd_Mtl.Connection = sqlCon;



            SqlDataReader reader2 = cmd_Mtl.ExecuteReader();
            while (reader2.Read())
            {
                maTheLoai = reader2.GetString(0);
            }
            reader2.Close();

            SqlCommand cmd_Mnxb = new SqlCommand();
            cmd_Mnxb.CommandType = CommandType.StoredProcedure;
            cmd_Mnxb.CommandText = "GetMaNXBByMaSach";
            cmd_Mnxb.Parameters.AddWithValue("@ms", ms);
            cmd_Mnxb.Connection = sqlCon;

            SqlDataReader reader3 = cmd_Mnxb.ExecuteReader();
            while (reader3.Read())
            {
                maNXB = reader3.GetString(0);
            }
            reader3.Close();

            // Kiểm tra xem sách có đang mượn không
            SqlCommand cmd6 = new SqlCommand();
            cmd6.CommandType = CommandType.StoredProcedure;
            cmd6.CommandText = "CheckSachInCTMT";
            cmd6.Parameters.AddWithValue("@maSach", ms);
            cmd6.Connection = sqlCon;

            int muonTra = (int)cmd6.ExecuteScalar();
            if (muonTra == 0)
            {
                SqlCommand cmd3 = new SqlCommand();
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.CommandText = "DeleteSach";
                cmd3.Parameters.AddWithValue("@ms", ms);
                cmd3.Connection = sqlCon;

                int kq = cmd3.ExecuteNonQuery();
                // Xóa bảng tác giả theo mã tác giả

                SqlCommand cmd_Mtg = new SqlCommand();
                cmd_Mtg.CommandType = CommandType.StoredProcedure;
                cmd_Mtg.CommandText = "DeleteTacGia";
                cmd_Mtg.Parameters.AddWithValue("@mtg", maTacGia);
                cmd_Mtg.Connection = sqlCon;

                int kqtq = cmd_Mtg.ExecuteNonQuery();
                // Lấy mã thể loại từ bảng sách




                // Xóa bảng thể loại theo mã thể loại
                SqlCommand cmd_mtl = new SqlCommand();
                cmd_mtl.CommandType = CommandType.StoredProcedure;
                cmd_mtl.CommandText = "DeleteTheLoai";
                cmd_mtl.Parameters.AddWithValue("@mtl", maTheLoai);
                cmd_mtl.Connection = sqlCon;


                int kqtl = cmd_mtl.ExecuteNonQuery();



                // Xóa bảng thể loại theo mã thể loại

                SqlCommand cmd_mnxb = new SqlCommand();
                cmd_mnxb.CommandType = CommandType.StoredProcedure;
                cmd_mnxb.CommandText = "DeleteNhaXuatBan";
                cmd_mnxb.Parameters.AddWithValue("@mnxb", maNXB);
                cmd_mnxb.Connection = sqlCon;

                int kqmnxb = cmd_mnxb.ExecuteNonQuery();

                if (kq > 0)
                {
                    if (kqtq > 0)
                    {
                        if (kqtl > 0)
                        {
                            if (kqmnxb > 0)
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public List<Book> search(string search)
        {
            List<Book> listBook = new List<Book>();
            Book b = new Book();
            string tmp = search.Trim();
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SearchSach";
            cmd.Parameters.AddWithValue("@search", tmp);
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                b.idbook = reader.GetString(0);
                b.namebook = reader.GetString(1);
                b.nxbName = reader.GetString(2);
                b.nbxYear = reader.GetString(3);
                b.authorName = reader.GetString(4);
                b.category = reader.GetString(5);
                b.amount = reader.GetString(6);
                b.da_muon = reader.GetString(7);
                b.ton_kho = reader.GetString(8);
                listBook.Add(b);
            }
            reader.Close();
            return listBook;
        }
    }
}

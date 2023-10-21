using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BorrowCard_child_DAL:ConnectToSql
    {
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
                book.ton_kho = tonKho.ToString();

                listBook.Add(book);
            }
            reader.Close();
            return listBook;
        }

        public List<Book> showDetailBook(string cardID)
        {
            openConnection();
            List<Book> listBook = new List<Book>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetBookAndLoanDetailByMT";
            cmd.Parameters.AddWithValue("@mmt", cardID);
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
             
                string soLuong = "";
             
                string tonKho = "";
                string ngayMuon = "";
                string ngayTra = "";
                

                tenSach = reader.GetString(1);                                           
                tacGia = reader.GetString(3);                             
                theLoai = reader.GetString(5);               
                NXB = reader.GetString(7);            
                namXB = reader.GetString(8);             
                                                  
                                        
                tonKho = reader.GetString(12);
                ngayMuon= reader.GetString(15);
                ngayTra = reader.GetString(16);
                soLuong = reader.GetInt32(19).ToString();

                Book book = new Book();
                book.idbook = ID;
                book.namebook = tenSach;
                book.authorName = tacGia;
                book.category = theLoai;
                book.nxbName = NXB;
                book.nbxYear = namXB;
              
                book.amount = soLuong;
              
                book.ton_kho = tonKho.ToString();
                book.dateBorrow = ngayMuon;
                book.dateReturn = ngayTra;
                listBook.Add(book);
            }
            reader.Close();
            return listBook;
        }

        //public bool addBorrowBook(List<BorrowCard> listCard, string idBook)
        //{         
        //    listCard = new List<BorrowCard>();
        //    BorrowCard aCard = new BorrowCard();
        //    aCard.idbook = idBook;

        //    listCard.Add(aCard);
        //    return true;             
        //}
        public List<Book> searchcu(string search)
        {
            List<Book> listBook = new List<Book>();
            
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
                Book b = new Book();
                b.idbook = reader.GetString(0);
                b.namebook = reader.GetString(1);
                b.nxbName = reader.GetString(7);
                b.nbxYear = reader.GetString(8);
                b.authorName = reader.GetString(3);
                b.category = reader.GetString(5);
                b.ton_kho = reader.GetString(12);
                listBook.Add(b);
            }
            reader.Close();
            return listBook;
        }





        //public string AutoID(string code, string tableName, string idColumn)
        //{
        //    int count = 0;
        //    string nextID1 = "";
        //    openConnection();
        //    SqlCommand cmd0 = new SqlCommand("Select count(*) from " + tableName , sqlCon);
        //    int check = (int)cmd0.ExecuteScalar();
        //    if (check > 0)
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT TOP 1 " + idColumn + " FROM " + tableName + " ORDER BY " + idColumn + " DESC", sqlCon);
        //        string lastestID = (string)cmd.ExecuteScalar();
        //        int nextID = int.Parse(lastestID.Substring(2)) + 1;
        //        nextID1 = code + nextID.ToString("000");
        //        do
        //        {
        //            cmd.CommandText = "SELECT COUNT(*) FROM " + tableName + " WHERE " + idColumn + " = @madg";
        //            cmd.Parameters.Clear();
        //            cmd.Parameters.AddWithValue("@madg", nextID1);
        //            count = (int)cmd.ExecuteScalar();

        //            // Nếu mã đã được sử dụng, tăng giá trị số thứ tự lên và tạo mã mới
        //            if (count > 0)
        //            {
        //                nextID++;
        //                nextID1 = code + nextID.ToString("000");
        //            }
        //        }
        //        while (count > 0);

        //    }
        //    else
        //    {
        //        int nextID =  1;
        //        nextID1 = code + nextID.ToString("000");
        //    }
        //    return nextID1;
        //}
        //string idMT = "";

        //public string createID()
        //{
        //    idMT = AutoID("MT", "MUON_TRA", "Ma_MT");
        //    openConnection();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = "insert into MUON_TRA (Ma_MT) values (@idMt)";
        //    cmd.Parameters.AddWithValue("@idMt", idMT);
        //    cmd.Connection = sqlCon;
        //    cmd.ExecuteNonQuery();
        //    return idMT;
        //}
        //public bool add(string idbook)
        //{
        //    openConnection();
        //    SqlCommand cmd1 = new SqlCommand();
        //    cmd1.CommandType = CommandType.Text;
        //    cmd1.CommandText = "insert into CHI_TIET_MUON_TRA (Ma_MT,Ma_Sach) values (@maMt,@maSach)";
        //    cmd1.Parameters.AddWithValue ("maMt", idMT);
        //    cmd1.Parameters.AddWithValue ("maSach", idbook);
        //    cmd1.Connection = sqlCon;
        //    int k = cmd1.ExecuteNonQuery();

        //    if (k>0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }

   
}

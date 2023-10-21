using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DTO;
using static System.Net.Mime.MediaTypeNames;


namespace DAL
{
    public class Main_user_DAL:ConnectToSql
    {
        // Hiển thị danh sách book
        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SelectAllSach";
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string masach = reader.GetString(0);
                string tensach = reader.GetString(1);
                string tentg = reader.GetString(2);
                string tennxb = reader.GetString(3);
                string namxb = reader.GetString(4);
                string tentl = reader.GetString(5);
                string tonkho;
                if(!reader.IsDBNull(6))
                {
                    tonkho = reader.GetString(6);
                }
                else
                {
                    tonkho = "0";
                }
                Book b = new Book();
                b.idbook = masach;
                b.namebook = tensach;
                b.authorName = tentg;
                b.nxbName = tennxb;
                b.nbxYear = namxb;
                b.category = tentl;
                b.ton_kho = tonkho;
                books.Add(b);
            }
            reader.Close();
            return books;
        }
        // Tìm kiếm
        public Book SearchBook(string search, Book b)
        {
            string tmp = search.Trim();
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SearchSachByMaOrTen ";
            cmd.Parameters.AddWithValue("@ma", tmp);
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                b.idbook = reader.GetString(0);
                b.namebook = reader.GetString(1);
                b.authorName = reader.GetString(3);
                b.nxbName = reader.GetString(7);
                b.nbxYear = reader.GetString(8);
                b.category = reader.GetString(5);
                if(!reader.IsDBNull(12))
                {
                    b.ton_kho = reader.GetString(12);

                }
                else
                {
                    b.ton_kho = "0";
                }
            }
            reader.Close();
            return b;
        }
    }
}

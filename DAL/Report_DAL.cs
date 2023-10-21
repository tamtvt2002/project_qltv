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
    public class Report_DAL:ConnectToSql
    {
        // sách đang cho mượn
        public List<BorrowCard> ShowBorrowCard()
        {
            List<BorrowCard> dsbc = new List<BorrowCard>();
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            string query = "Get_Sach_ChiTietMuonTra";
            cmd.CommandText = query;
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string maMT = reader.GetString(14);
                string tensach = reader.GetString(1);
                string masach = reader.GetString(0);
                string tentl = reader.GetString(5);
                string ngaymuon = reader.GetString(15);
                string ngaytra = reader.GetString(16);
                string tinhtrang;
                if(!reader.IsDBNull(6))
                {
                    tinhtrang = reader.GetString(17);
                }
                else
                {
                    tinhtrang = "";
                }
                BorrowCard bc = new BorrowCard();
                bc.idcart = maMT;
                bc.namebook = tensach;
                bc.idbook = masach;
                bc.category = tentl;
                bc.dateborrow = ngaymuon;
                bc.dateReturn = ngaytra;
                bc.bookstatus = tinhtrang;
                dsbc.Add(bc);
            }
            reader.Close();
            return dsbc;
        }
        // Sách trễ hạn
        public List<BorrowCard> ShowBookLate()
        {
            List<BorrowCard> dsbc = new List<BorrowCard>();
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetMuonTraDetails";
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string maMT = reader.GetString(0);
                string tensach = reader.GetString(1);
                string masach = reader.GetString(2);
                string tentl = reader.GetString(3);
                string ngaymuon = reader.GetString(4);
                string ngaytra = reader.GetString(5);
                string tinhtrang;
                if (!reader.IsDBNull(6))
                {
                    tinhtrang = reader.GetString(6);
                }
                else
                {
                    tinhtrang = "";
                }
                int songaytrehen = (int)reader.GetInt32(7);
                BorrowCard bc = new BorrowCard();
                bc.idcart = maMT;
                bc.namebook = tensach;
                bc.idbook = masach;
                bc.category = tentl;
                bc.dateborrow = ngaymuon;
                bc.dateReturn = ngaytra;
                bc.bookstatus = tinhtrang;
                bc.DateLate = songaytrehen;
                int check = (int)bc.DateLate;
                if(check <0)
                {
                    dsbc.Add(bc);
                }
            }
            reader.Close();
            return dsbc;
        }
        // Đã trả
        public List<BorrowCard> ShowBookReturned()
        {
            List<BorrowCard> dsbc = new List<BorrowCard>();
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            string query = "usp_LayThongTinSachDaTra";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@datra", "Đã trả");
            cmd.Connection = sqlCon;
            int kq = cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();

            if (kq > 0 && reader.Read())
            {
                string maMT = reader.GetString(0);
                string tensach = reader.GetString(1);
                string masach = reader.GetString(2);
                string tentl = reader.GetString(3);
                string ngaymuon = reader.GetString(4);
                string ngaytra = reader.GetString(5);
                string tinhtrang;
                if (!reader.IsDBNull(6))
                {
                    tinhtrang = reader.GetString(6);
                }
                else
                {
                    tinhtrang = "";
                }
                BorrowCard bc = new BorrowCard();
                bc.idcart = maMT;
                bc.namebook = tensach;
                bc.idbook = masach;
                bc.category = tentl;
                bc.dateborrow = ngaymuon;
                bc.dateReturn = ngaytra;
                bc.bookstatus = tinhtrang;
                dsbc.Add(bc);
            }
            reader.Close();
            return dsbc;
        }
        // Tài khoản
        public List<Accounts> GetInfoAcc()
        {
            List<Accounts> ds = new List<Accounts>();
           
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetAllTaiKhoan ";
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Accounts acc = new Accounts();
                string nameAcc = reader.GetString(0);
                string pass = reader.GetString(1);

                acc.Ten_TK = nameAcc;
                acc.password = pass;
                ds.Add(acc);
            }
            reader.Close();           
            return ds;
        }

    }
}

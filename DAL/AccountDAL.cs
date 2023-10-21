using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Security.Principal;
using System.Collections;

namespace DAL
{
    public class AccountDAL:ConnectToSql
    {
        public bool accountCheck(Accounts a)
        {
            string name = a.nameUser;
            string pass = a.password;
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "checkAccount";
            cmd.Parameters.AddWithValue("@username", name);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.Connection = sqlCon;

            int k = (int)cmd.ExecuteScalar();
            if (k > 0)
            {  
                return true;
            }
            else
            {
                return false;
            }           
        }
        // Lấy fullname theo tên đăng nhập để hiển thị ở form Main
        public string getUserName(Accounts a)
        {
            string name = a.nameUser;
            string pass = a.password;
            string fullname = null;
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "getUserName";
            cmd.Parameters.AddWithValue("@tendn", name);
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    fullname = reader.GetString(4);
                }
            }
            else
            {
                return "exit";
            }
            return fullname;
        }
        public string getUser(Accounts a)
        {
            string fullname = getUserName(a);
            return fullname;
        }

        // Tạo tài khoản online
        public bool accountCreate(Accounts a)
        {
            string name = a.nameUser;
            string pass = a.password;
            int quyen = a.quyen;
            string id = a.id;
            string fullname = a.fullName;
            string Class = a.Class;
            string NumberPhone = a.NumberPhone;
            string Ten_TK = name;

            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "createAcount";
            cmd.Parameters.AddWithValue ("@username", name);
            cmd.Connection = sqlCon;
            int k = (int)cmd.ExecuteScalar();
            if(k > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CheckPermission( Accounts a)
        {
            openConnection();
            int quyen = 0 ;
            string tentk = a.nameUser;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "checkPermission";
            cmd.Parameters.AddWithValue("@tentk", tentk);
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                quyen = reader.GetInt32(0);
            }
            reader.Close();
            return quyen;
        }
        // Kiểm tra khách hàng đã có tài khoản chưa
        public bool CheckUserAcc(Accounts a)
        {
            string name = a.nameUser;
            string pass = a.password;
            int quyen = a.quyen;
            string id = a.id;
            string fullname = a.fullName;
            string Class = a.Class;
            string NumberPhone = a.NumberPhone;
            string Ten_TK = name;

            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "checkUserAccount";
            cmd.Parameters.AddWithValue("@sodt", NumberPhone);
            cmd.Connection = sqlCon;
            int k = (int)cmd.ExecuteScalar();
            if (k > 0)
            {
                return true;
            }
            else
            {
                // Tạo mã độc giả tự động
                SqlCommand cmd1 = new SqlCommand();
                
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "getFirstMaDG";
                cmd1.Connection = sqlCon;
                string lastestID = (string)cmd1.ExecuteScalar();

                // Tạo mã độc giả tiếp theo
                //phương thức Substring() để lấy một chuỗi con bắt đầu từ ký tự thứ hai (index = 1) của lastestID.
                int nextID = int.Parse(lastestID.Substring(2)) + 1;
                string nextID1 = "KH" + nextID.ToString("000");

                // Kiểm tra xem mã độc giả tiếp theo đã được sử dụng chưa
                int count = 0;
                do
                {
                    cmd1.Parameters.Clear();
                    cmd1.CommandText = "count_DocGia";               
                    cmd1.Parameters.AddWithValue("@madg", nextID1);
                    count = (int)cmd1.ExecuteScalar();

                    // Nếu mã đã được sử dụng, tăng giá trị số thứ tự lên và tạo mã mới
                    if (count > 0)
                    {
                        nextID++;
                        nextID1 = "KH" + nextID.ToString("000");
                    }
                }
                while (count > 0);
                SqlCommand cmd0 = new SqlCommand();

                cmd0.CommandType = CommandType.StoredProcedure;
                cmd0.CommandText = "addAccount";
                cmd0.Parameters.AddWithValue("@tentk", name);
                cmd0.Parameters.AddWithValue("@matkhau", pass);
                cmd0.Parameters.AddWithValue("@quyen", 1);
                cmd0.Connection = sqlCon;
                cmd0.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "addReader";
                cmd2.Parameters.AddWithValue("@madg", nextID1);
                cmd2.Parameters.AddWithValue("@tendg", fullname);
                cmd2.Parameters.AddWithValue("@lop", Class);
                cmd2.Parameters.AddWithValue("@sdt", NumberPhone);
                cmd2.Parameters.AddWithValue("@tendn", Ten_TK);
                cmd2.Connection = sqlCon;
                cmd2.ExecuteNonQuery();
                return false;
            }
        }
    }
}

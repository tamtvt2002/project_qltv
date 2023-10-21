using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class AccountBLL
    {
        AccountDAL acc = new AccountDAL();
        public bool checkAccount(Accounts account)
        {
            return acc.accountCheck(account);
        }
        public bool accountCreate(Accounts account)
        {
            return acc.accountCreate(account);
        }
        public string getUserName(Accounts account)
        {
            string fullname = acc.getUser(account);
            return fullname;
        }

        public int CheckPermision(Accounts a)
        {
            int quyen = acc.CheckPermission(a);
            return quyen;
        }

        public bool CheckUserAcc(Accounts a)
        {
            return acc.CheckUserAcc(a);
        }
    }
}

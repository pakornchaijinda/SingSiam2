using SingSiamOffice.Models;
using Microsoft.EntityFrameworkCore;

namespace SingSiamOffice.Authentication
{
    public class UserAccountService
    {
        //private List<UserAccount> _users;

        //public UserAccountService()
        //{
        //    _users = new List<UserAccount>
        //    {
        //        new UserAccount{ UserName = "admin", Password = "admin", Role = "Administrator" },
        //        new UserAccount{ UserName = "user", Password = "user", Role = "User" }
        //    };
        //}

        //public UserAccount? GetByUserName(string userName)
        //{
        //    return _users.FirstOrDefault(x => x.UserName == userName);
        //}

        Manage.Hasher hasher = new Manage.Hasher();

        private List<Userfile> _users;
        private Userfile _login;
        private SingsiamnewdbContext db = new SingsiamnewdbContext();
        public UserAccountService()
        {

            _users = db.Userfiles.ToList();
        }

        public async Task<Userfile> GetByUserName(string userName, string passWord)
        {
            if (await checkUserPassword(userName, passWord) == false)
            {
                return null;
            }
            else
            {
                return db.Userfiles.Where(x => x.Code == userName).AsNoTracking().FirstOrDefault();
            }

        }
        public async Task<bool> checkUserPassword(string username, string password)
        {
        
            _login = db.Userfiles.Where(u => u.Code == username ).AsNoTracking().FirstOrDefault();
            if (_login == null)
            {
                return false;//ไม่มี user นี้
            }
            string hashedPWD = password;
            if (hashedPWD == _login.Password)
            {
                return true;
            }
            else
            {
                return false;//password ผิด
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using SingSiamOffice.Models;

namespace SingSiamOffice.Manage
{
    public class UserManagement
    {
        private readonly SingsiamdbContext db = new SingsiamdbContext();

        public string GenerateSalt(int maxSize = 10)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            var data = new byte[maxSize];
            using (var crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            var result = new StringBuilder(maxSize);
            foreach (var b in data)
            {
                result.Append(chars[b % chars.Length]);
            }
            return result.ToString();
        }

        public string HashPassword(string inputPassword, string salt)
        {
            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(salt));
            var buffer = Encoding.UTF8.GetBytes($"{inputPassword}{salt}");
            return Convert.ToBase64String(hmac.ComputeHash(buffer)).Replace("-", "");
        }

        public async Task<List<Role>> ListAllRolesAsync()
        {
            return await db.Roles.AsNoTracking().Where(s => s.IsActive).ToListAsync();
        }

        public async Task<List<Login>> ListAllUsersAsync()
        {
            return await db.Logins.Include(s => s.Branch).Include(s => s.Role).AsNoTracking().ToListAsync();
        }

        public async Task<Login> GetUserLoginAsync(Login input)
        {
            return await db.Logins.Include(s => s.Role)
                .FirstOrDefaultAsync(s => s.Username == input.Username && s.Dob == input.Dob);
        }

        public async Task<int> GetUserIdAsync(string username)
        {
            var data = await db.Logins.AsNoTracking()
                .FirstOrDefaultAsync(s => s.Username == username);
            return data.Id;
        }

        public async Task<bool> CheckUserLoginActiveAsync(UserLogin input)
        {
            return await db.Logins.Where(s => s.Username == input.UserName)
                .Select(s => s.IsActive).FirstOrDefaultAsync();
        }

        public async Task<bool> CheckUserLoginPassAsync(UserLogin input)
        {
            var data = await db.Logins.FirstOrDefaultAsync(s => s.Username == input.UserName);
            if (data == null) return false;

            var hashedPWD = HashPassword(input.Password, data.Salt);
            return hashedPWD == data.Password;
        }

        public async Task<bool> AddUserLoginAsync(Login input)
        {
            var salt = GenerateSalt();
            var login = new Login
            {
                Username = input.Username,
                Salt = salt,
                Password = HashPassword(input.Password, salt),
                Fullname = input.Fullname,
                Email = input.Email,
                RoleId = input.RoleId,
                IsActive = true,
                CreatedAt = DateTime.Now,
                Phone = input.Phone,
                Dob = input.Dob,
                BranchId = input.BranchId,
                EmNickname = input.EmNickname,
                Code = input.Code,
                Img = input.Img,
                Address = input.Address
            };

            try
            {
                await db.Logins.AddAsync(login);
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> EditUserLoginAsync(Login input)
        {
            var toEdit = await db.Logins.FirstOrDefaultAsync(s => s.Id == input.Id);
            if (toEdit == null) return false;

            try
            {
                toEdit.Username = input.Username;
                toEdit.Password = HashPassword(input.Password, toEdit.Salt);
                toEdit.Fullname = input.Fullname;
                toEdit.Email = input.Email;
                toEdit.RoleId = input.RoleId;
                toEdit.IsActive = input.IsActive;
                toEdit.CreatedAt = DateTime.Now;
                toEdit.Phone = input.Phone;
                toEdit.Dob = input.Dob;
                toEdit.BranchId = input.BranchId;
                toEdit.EmNickname = input.EmNickname;
                toEdit.Img = input.Img;
                toEdit.Address = input.Address;

                db.Entry(toEdit).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteUserLoginAsync(Login input)
        {
            var toEdit = await db.Logins.FirstOrDefaultAsync(s => s.Id == input.Id);
            if (toEdit == null) return false;

            try
            {
                toEdit.IsActive = false;
                db.Entry(toEdit).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> AddEventLogAsync(SingSiamOffice.Models.EventLog toAdd)
        {
            try
            {
                await db.EventLogs.AddAsync(toAdd);
                await db.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

using ETMS___Using_Sqlite.Entities;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ETMS___Using_Sqlite.Features
{
    class Authentication
    {
        private TimeSheetDbContext _context;
        private string username;
        private string password;
        public Authentication(TimeSheetDbContext context, string username, string password)
        {
            this.username = username;
            this.password = password;
            _context = context;
        }
        public bool IsAuthenticated { get; private set; } = false;
        public bool ValidateLogin()
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Please provide username and password!");
            }
            var user = _context.UserAccounts.
                Where(u => u.UserName == username.Trim() && u.Password == password.Trim()).
                FirstOrDefault();
            if (user == null)
            {
                return IsAuthenticated = false;
            }
            return IsAuthenticated = true;
        }
        public void LogOut()
        {
            IsAuthenticated = false;
        }
    }
}

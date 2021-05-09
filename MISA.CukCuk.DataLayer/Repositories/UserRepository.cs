using Dapper;
using MISA.Common.Models;
using MISA.DataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MISA.DataLayer.Repositories
{
    public class UserRepository : DbContext<User>, IUserRepository
    {
        public IEnumerable<User> FindUser(string userName, string password)
        {
            string sql = $"SELECT * FROM User WHERE UserName = {userName}, Password = {password}";
            var data = _dbConnection.Query<User>($"SELECT * FROM User WHERE UserName = '{userName}' AND Password = '{password}'", commandType: CommandType.Text);
            return data;
        }
    }
}

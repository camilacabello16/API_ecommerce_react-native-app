using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.DataLayer.interfaces
{
    public interface IUserRepository : IDbContext<User>
    {
        IEnumerable<User> FindUser(string userName, string password);
    }
}

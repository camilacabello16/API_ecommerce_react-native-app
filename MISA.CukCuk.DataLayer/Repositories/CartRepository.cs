using Dapper;
using MISA.Common.Models;
using MISA.DataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MISA.DataLayer.Repositories
{
    public class CartRepository : DbContext<Cart>, ICartRepository
    {
        public IEnumerable<Cart> GetByUserID(Guid userId)
        {
            var data = _dbConnection.Query<Cart>("SELECT * FROM Cart WHERE UserId = @userId", new { userId = userId }, commandType: CommandType.Text);
            return data;
        }

        public int InsertToCart(Guid userId, Guid productId)
        {
            var res = _dbConnection.Execute($"INSERT INTO Cart (CartId, UserId, ProductId) VALUES (UUID(), '{userId}', '{productId}')", commandType: CommandType.Text);
            return res;
        }
    }
}

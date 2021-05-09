using Dapper;
using MISA.Common.Models;
using MISA.DataLayer.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MISA.DataLayer.Repositories
{
    public class ProductRepository : DbContext<Product>, IProductRepository 
    {
        public IEnumerable<Product> GetProductByCategoryID(int categoryId)
        {
            var data = _dbConnection.Query<Product>("SELECT * FROM Product WHERE CategoryId = @categoryId", new { categoryId = categoryId}, commandType: CommandType.Text);
            return data;
        }

        public IEnumerable<Product> GetProductByUserID(Guid userId)
        {
            string dataString = userId.ToString();
            string test = $"SELECT * FROM Product WHERE UserId = '{userId}'";
            var data = _dbConnection.Query<Product>($"SELECT * FROM Product WHERE UserId = '{dataString}'", commandType: CommandType.Text);
            return data;
        }
    }
}

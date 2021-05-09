using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.DataLayer.interfaces
{
    public interface IProductRepository : IDbContext<Product>
    {
        IEnumerable<Product> GetProductByCategoryID(int categoryId);
        IEnumerable<Product> GetProductByUserID(Guid userId);
    }
}

using MISA.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.DataLayer.interfaces
{
    public interface ICartRepository:IDbContext<Cart>
    {
        IEnumerable<Cart> GetByUserID(Guid userId);
        int InsertToCart(Guid userId, Guid productId);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    /// <summary>
    /// Giỏ hàng 
    /// </summary>
    public class Cart:BaseEntity
    {
        public Guid CartId { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
    }
}

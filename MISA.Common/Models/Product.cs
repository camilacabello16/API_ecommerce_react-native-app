using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    /// <summary>
    /// Sản phẩm
    /// </summary>
    public class Product:BaseEntity
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public Guid UserId { get; set; }
        public int CategoryId { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public string ProductPrice { get; set; }
        public string ProductWeight { get; set; }
    }
}

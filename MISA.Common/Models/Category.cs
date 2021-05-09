using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    /// <summary>
    /// Loại quần áo
    /// </summary>
    public class Category:BaseEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

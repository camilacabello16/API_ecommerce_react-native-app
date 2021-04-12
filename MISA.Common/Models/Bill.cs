using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    /// <summary>
    /// Bảng hóa đơn
    /// </summary>
    public class Bill
    {
        public Guid BillId { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public string TotalPrice { get; set; }
    }
}

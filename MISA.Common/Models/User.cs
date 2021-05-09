using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    /// <summary>
    /// Người dùng
    /// </summary>
    public class User:BaseEntity
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}

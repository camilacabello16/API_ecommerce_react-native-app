using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.Common.Models
{
    /// <summary>
    /// Bình luận của người dùng
    /// </summary>
    public class Comment:BaseEntity
    {
        public Guid CommentId { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public string Content { get; set; }
    }
}

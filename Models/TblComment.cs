using System;
using System.Collections.Generic;

#nullable disable

namespace Mindfork_Blogs.Models
{
    public partial class TblComment
    {
        public long CommentId { get; set; }
        public long BlogId { get; set; }
        public string Comment { get; set; }
        public long UserId { get; set; }
        public DateTime Date { get; set; }
        public long LikeCount { get; set; }
        public long DislikeCount { get; set; }
    }
}

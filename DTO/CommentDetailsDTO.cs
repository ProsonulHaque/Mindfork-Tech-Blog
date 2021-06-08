using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfork_Blogs.DTO
{
    public class CommentDetailsDTO
    {
        public long CommentId { get; set; }
        public string Comment { get; set; }
        public string CommentedBy { get; set; }
        public DateTime CommentDate { get; set; }
        public long LikeCount { get; set; }
        public long DislikeCount { get; set; }
    }
}

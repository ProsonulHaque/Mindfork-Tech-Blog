using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfork_Blogs.DTO
{
    public class BlogPostDTO
    {
        public long BlogId { get; set; }
        public string BlogName { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostDate { get; set; }
        public long TotalComments { get; set; }
        public IEnumerable<CommentDetailsDTO> Comments { get; set; }
    }
}

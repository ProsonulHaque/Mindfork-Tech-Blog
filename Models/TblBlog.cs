using System;
using System.Collections.Generic;

#nullable disable

namespace Mindfork_Blogs.Models
{
    public partial class TblBlog
    {
        public long BlogId { get; set; }
        public string BlogName { get; set; }
        public long UserId { get; set; }
        public DateTime? Date { get; set; }
    }
}

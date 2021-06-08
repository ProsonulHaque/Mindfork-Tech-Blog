using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfork_Blogs.DTO
{
    public class PaginationDTO<T>
    {
        public long PageNo { get; set; }
        public long PageSize { get; set; }
        public IEnumerable<T> PageData { get; set; }
    }
}

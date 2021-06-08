using Mindfork_Blogs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfork_Blogs.Helper
{
    public static class PaginationHelper<T>
    {
        public static PaginationDTO<T> Paginator(IEnumerable<T> Data, long PageSize, long PageNo)
        {
            Data = Data.Skip((int)(PageSize * (PageNo - 1))).Take((int)PageSize);

            return new PaginationDTO<T>()
            {
                PageNo = PageNo,
                PageSize = Data.Count(),
                PageData = Data
            };
        }
    }
}

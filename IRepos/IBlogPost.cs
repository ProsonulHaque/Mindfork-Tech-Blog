using Mindfork_Blogs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfork_Blogs.IRepos
{
    public interface IBlogPost
    {
        PaginationDTO<BlogPostDTO> GetAllBlogPosts(long PageNo, long PageSize);
        PaginationDTO<BlogPostDTO> GetBlogPostsBySearch(string searchKey, long PageNo, long PageSize);
    }
}

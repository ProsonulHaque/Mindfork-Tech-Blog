using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mindfork_Blogs.DTO;
using Mindfork_Blogs.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfork_Blogs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPost _IRepo;

        public BlogPostController(IBlogPost _Repo)
        {
            _IRepo = _Repo;
        }

        [HttpGet]
        [Route("GetAllBlogPost")]
        public IActionResult GetAllBlogPost(long PageNo, long PageSize)
        {
            return Ok(_IRepo.GetAllBlogPosts(PageNo, PageSize));
        }

        [HttpGet]
        [Route("GetBlogPostsBySearch")]
        public IActionResult GetBlogPostsBySearch(string searchkey, long PageNo, long PageSize)
        {
            return Ok(_IRepo.GetBlogPostsBySearch(searchkey, PageNo, PageSize));
        }
    }
}

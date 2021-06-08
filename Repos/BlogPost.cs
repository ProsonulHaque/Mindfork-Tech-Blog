using Mindfork_Blogs.DTO;
using Mindfork_Blogs.Helper;
using Mindfork_Blogs.IRepos;
using Mindfork_Blogs.Models;
using System.Collections.Generic;
using System.Linq;

namespace Mindfork_Blogs.Repos
{
    public class BlogPost : IBlogPost
    {
        private readonly MindforkDBContext _context;

        public BlogPost(MindforkDBContext context)
        {
            _context = context;
        }

        public PaginationDTO<BlogPostDTO> GetAllBlogPosts(long PageNo, long PageSize)
        {
            var data = (from blogs in _context.TblBlogs
                        join users in _context.TblUsers on blogs.UserId equals users.UserId

                        select new BlogPostDTO()
                        {
                            BlogId = blogs.BlogId,
                            BlogName = blogs.BlogName,
                            PostedBy = users.Name,
                            PostDate = blogs.Date,
                            
                            Comments = (from comments in _context.TblComments
                                        join cUser in _context.TblUsers on comments.UserId equals cUser.UserId
                                        where comments.BlogId == blogs.BlogId

                                        select new CommentDetailsDTO()
                                        {
                                            CommentId = comments.CommentId,
                                            Comment = comments.Comment,
                                            CommentedBy = cUser.Name,
                                            CommentDate = comments.Date,
                                            LikeCount = comments.LikeCount,
                                            DislikeCount = comments.DislikeCount

                                        }).AsEnumerable(),

                            TotalComments = (from comments in _context.TblComments 
                                            where comments.BlogId == blogs.BlogId
                                            select blogs).Count()
                        }).AsEnumerable();

            return PaginationHelper<BlogPostDTO>.Paginator(data, PageSize, PageNo);
        }

        public PaginationDTO<BlogPostDTO> GetBlogPostsBySearch(string searchKey, long PageNo, long PageSize)
        {
            var data = (from blogs in _context.TblBlogs
                        join users in _context.TblUsers on blogs.UserId equals users.UserId
                        where blogs.BlogName.ToLower().Contains(searchKey.ToLower()) || users.Name.ToLower().Contains(searchKey.ToLower())

                        select new BlogPostDTO()
                        {
                            BlogId = blogs.BlogId,
                            BlogName = blogs.BlogName,
                            PostedBy = users.Name,
                            PostDate = blogs.Date,

                            Comments = (from comments in _context.TblComments
                                        join cUser in _context.TblUsers on comments.UserId equals cUser.UserId
                                        where comments.BlogId == blogs.BlogId

                                        select new CommentDetailsDTO()
                                        {
                                            CommentId = comments.CommentId,
                                            Comment = comments.Comment,
                                            CommentedBy = cUser.Name,
                                            CommentDate = comments.Date,
                                            LikeCount = comments.LikeCount,
                                            DislikeCount = comments.DislikeCount

                                        }).AsEnumerable(),

                            TotalComments = (from comments in _context.TblComments
                                             where comments.BlogId == blogs.BlogId
                                             select blogs).Count()
                        }).AsEnumerable();

            return PaginationHelper<BlogPostDTO>.Paginator(data, PageSize, PageNo);
        }
    }
}

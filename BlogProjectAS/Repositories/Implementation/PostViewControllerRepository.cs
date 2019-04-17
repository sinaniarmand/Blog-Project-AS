using BlogProjectAS.Data;
using BlogProjectAS.Repositories.Interfaces;
using BlogProjectAS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectAS.Repositories.Implementation
{
    public class PostViewControllerRepository : RepositoryBase<PostsViewModel>, IPostViewControllerRepository
    {
        public PostViewControllerRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }

    }
}

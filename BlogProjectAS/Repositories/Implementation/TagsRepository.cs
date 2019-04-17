using BlogProjectAS.Data;
using BlogProjectAS.Models;
using BlogProjectAS.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectAS.Repositories.Implementation
{
    public class TagsRepository : RepositoryBase<Tag>, ITagsRepository
    {
        public TagsRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}

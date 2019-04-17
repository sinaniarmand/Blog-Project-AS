using BlogProjectAS.Models;
using BlogProjectAS.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Repositories.Interfaces
{
    public interface IPostRepository : IRepositoryBase<Post>
    {
     IEnumerable<ExpandoObject> FindFromNCategory();
    }
}

﻿using BlogProjectAS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectAS.Repositories.Interfaces
{
   public interface IPostsPerUser : IRepositoryBase<PostsPerUser>
    {
        PostsPerUser FindPostsPerUser(string userId);
   
    }
}

using BlogProject.Repositories;
using BlogProjectAS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectAS.Repositories.Interfaces
{
   public interface PostTagViewModelInterface :IRepositoryBase<PostTagsViewModel>
    {
        IEnumerable<PostTagsViewModel> GetPostsForView(string titleSearch=null, string tag=null);
        PostTagsViewModel GetFullPost(int id);
    }
}

using BlogProject.Repositories.Interfaces;
using BlogProjectAS.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProjectAS.Repositories
{
    public interface IRepositoryWrapper
    {
        IPostRepository Post { get; }
        PostTagViewModelInterface PostCategory { get; }
        
        IPostsPerUser PostPerUser { get; }
        ITagsRepository Tags { get; }
        ICommentRepository Comments { get; }
       IPostTagRepository PostTags { get; }
        void Save();
        void Dispose();
    }
}

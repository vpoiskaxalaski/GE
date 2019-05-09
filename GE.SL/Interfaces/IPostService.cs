using GE.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace GE.SL.Interfaces
{
    public  interface IPostService
    {
        List<PostVM> GetAll();

        void Remove(int id);

        PostVM FindById(int id);

        void Update(PostVM post);

        void CreatePost(RegisterPostViewModel model, IEnumerable<IFormFile> images, ApplicationUserVM user);
    }
}

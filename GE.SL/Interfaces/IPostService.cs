using GE.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.SL.Interfaces
{
    public  interface IPostService
    {
        List<PostVM> GetAll();

        void CreatePost(RegisterPostViewModel model, IEnumerable<IFormFile> images, IFormFile video, ApplicationUserVM user);
    }
}

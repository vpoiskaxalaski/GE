﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GE.Models
{
    public class ApplicationUserVM : IdentityUser
    {
        public virtual PointVM Points { get; set; }
        //public string UserName { get; set; }
        //public string Email { get; set; }
        //public string PasswordHash { get; set; }
        //public string PhoneNumber { get; set; }
        public string Role { get; set; }

    }
}

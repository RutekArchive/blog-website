﻿using Microsoft.AspNetCore.Identity;

namespace Blog.Domain.Models
{
    public class Role : IdentityRole
    {
        public Role()
        {

        }

        public Role(string roleName)
            : base(roleName)
        {

        }
    }
}

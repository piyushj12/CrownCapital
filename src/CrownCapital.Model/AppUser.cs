﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CrownCapital.Model
{
    public class AppUser : IdentityUser
    {
        public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
    }
}

﻿using CrownCapital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrownCapital.Service.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}

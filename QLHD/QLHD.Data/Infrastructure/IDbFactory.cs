﻿using QLHD.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHD.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        QLHDDbContext Init();
    }
}

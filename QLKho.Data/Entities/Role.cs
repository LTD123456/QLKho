﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Data.Entities
{
    public class Role:IdentityRole<Guid>
    {
        public string Notes{ get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Data.Entities
{
    public class User:IdentityUser<Guid>
    {
        public string DisplayName{ get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<Input>Inputs{ get; set; }
        public ICollection<Output>Outputs{ get; set; }
    }
}

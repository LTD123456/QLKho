using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Database.Entities
{
    public class OutputInfo
    {
        public string Id{ get; set; }
        public string IdObject{ get; set; }
        public string IdInputInfo{ get; set; }
        public int Count{ get; set; }
        public string IdCustomer{ get; set; }
        public DateTime DateOutput{ get; set; }
    }
}

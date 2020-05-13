using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Database.Entities
{
    public class Suplier
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Address { get; set; }
        public string Phone{ get; set; }
        public string Email{ get; set; }
        public string Memo{ get; set; }
        public DateTime ContractDate { get; set; }
    }
}

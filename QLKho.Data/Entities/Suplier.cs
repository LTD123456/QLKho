using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Data.Entities
{
    public class Suplier
    {
        public Suplier()
        {
            Items = new HashSet<Item>();
        }
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string Address { get; set; }
        public string Phone{ get; set; }
        public string Email{ get; set; }
        public string Memo{ get; set; }
        public DateTime ContractDate { get; set; }
        //set Item
        public ICollection<Item>Items{ get; set; }
    }
}

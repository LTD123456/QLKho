using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Data.Entities
{
    public class Unit
    {
        public Unit()
        {
            Items = new HashSet<Item>();
        }
        public string Id{ get; set; }
        public string DisplayName { get; set; }
        public bool Stop { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Data.Entities
{
    public class InputInfo
    {
        public string Id { get; set; }
        public string IdObject{ get; set; }
        public string IdInput { get; set; }
        public int Count { get; set; }
        public int InputPrice{ get; set; }
        public int OutputPrice{ get; set; }
        public string Status{ get; set; }
    }
}

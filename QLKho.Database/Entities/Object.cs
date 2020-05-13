using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Database.Entities
{
    public class Object
    {
        public string Id{ get; set; }
        public string DisplayName{ get; set; }
        public string IdUnit { get; set; }
        public string IdSuplier { get; set; }
        public string QRCode { get; set; }
        public string BarCode { get; set; }
    }
}

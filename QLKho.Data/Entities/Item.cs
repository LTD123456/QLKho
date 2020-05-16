using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Data.Entities
{
    public class Item
    {
        public Item()
        {
            InputInfos = new HashSet<InputInfo>();
            OutputInfos = new HashSet<OutputInfo>();
        }
        public string Id{ get; set; }
        public string DisplayName{ get; set; }
        
        public string QRCode { get; set; }
        public string BarCode { get; set; }
        //set Unit
        public string IdUnit { get; set; }
        public Unit Unit { get; set; }
        //set InputInfo
        public ICollection<InputInfo> InputInfos { get; set; }
        //set Suplier
        public string IdSuplier { get; set; }
        public Suplier Suplier { get; set; }
        //set OutptutInfo
        public ICollection<OutputInfo>OutputInfos{ get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Data.Entities
{
    public class InputInfo
    {
        public InputInfo()
        {
            OutputInfos = new HashSet<OutputInfo>();
        }
        public string Id { get; set; }
        public int Count { get; set; }
        public int InputPrice { get; set; }
        public int OutputPrice { get; set; }
        public string Status { get; set; }
        //set Input
        public string IdInput { get; set; }
        public Input Input { get; set; }
        //Set Item
        public string IdItem { get; set; }
        public Item Item { get; set; }
        //Set OutputInfo
        public ICollection<OutputInfo> OutputInfos { get; set; }
    }
}

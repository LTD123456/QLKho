using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Data.Entities
{
    public class OutputInfo
    {
        public string Id{ get; set; }
        public int Count{ get; set; }
        public DateTime DateOutput{ get; set; }
        //Set Item 
        public string IdItem { get; set; }
        public Item Item{ get; set; }
        //set InputInfo
        public string IdInputInfo { get; set; }
        public InputInfo InputInfo{ get; set; }
        //Set Customer 
        public string IdCustomer { get; set; }
        public Customer Customer{ get; set; }
        //Set Output
        public string IdOutput { get; set; }
        public Output Output { get; set; }
    }
}

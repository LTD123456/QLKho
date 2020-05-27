using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Service.DTOCommons
{
    public class PageViewModel<T>
    {
        IEnumerable<T> Objects { get; set; }
        public int TotalRecord{ get; set; }
    }
}

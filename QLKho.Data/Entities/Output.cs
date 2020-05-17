using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Data.Entities
{
    public class Output
    {
        public Output()
        {
            OutputInfos = new HashSet<OutputInfo>();
        }
        public string Id{ get; set; }
        public DateTime  DateOutput { get; set; }
        //set Outputinfo
        public ICollection<OutputInfo> OutputInfos{ get; set; }

        public Guid IdUser{ get; set; }
        public User User { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QLKho.Data.Entities
{
    public class Input
    {
        public Input()
        {
            InputInfos = new HashSet<InputInfo>();
        }
        public string Id { get; set; }
        public DateTime DateInput { get; set; }
        //set InputInfo
        public ICollection<InputInfo> InputInfos { get; set; }
        public Guid IdUser{ get; set; }
        public User User{ get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod7
{
    internal class Members
    {
        public List<Member> members { get; set; }
        public Members() { }
        public Members(List<Member> members)
        {
            this.members = members;
        }

    }
}

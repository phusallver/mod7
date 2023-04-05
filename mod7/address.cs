using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod7
{
    internal class address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }

        public address(string streetAddress, string city, string state)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
        }
    }
}

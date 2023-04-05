using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod7
{
    internal class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public Address(string streetAddress, string city, string state)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
        }
    }
}

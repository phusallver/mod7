using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod7
{
    internal class courses
    {
        public string code { get; set; }
        public string name { get; set; }

        public courses(string code, string name)
        {
            this.code = code;
            this.name = name;
        }
    }
}

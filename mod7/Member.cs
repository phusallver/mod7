using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod7
{
    internal class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; } 
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }

        public Member(string firstName, string lastName, string gender, int age, string nim)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.nim = nim;
        }
    }
}

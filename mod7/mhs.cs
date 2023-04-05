using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace mod7
{
    internal class mhs
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }

        public mhs() { }
        public mhs(string firstName, string lastName, string gender, int age, Address address, List<Course> courses)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.courses = courses;
        }
    }
}

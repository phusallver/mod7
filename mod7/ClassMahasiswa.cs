using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod7
{
    internal class ClassMahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public address address { get; set; }
        public List<courses> courses { get; set; }
        public ClassMahasiswa() { }
        public ClassMahasiswa(string firstname, string lastname, string gender, int age, address address, List<courses> courses)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.courses = courses;
        }
    }
}

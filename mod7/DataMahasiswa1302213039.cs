using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace mod7
{
    internal class DataMahasiswa1302213039
    {
        

        public class address {
            public string streetAddress { get; set;}
            public string city { get; set;}
            public string state { get; set;}

            public address(string streetAdress, String city, String state)
            {
                this.streetAddress = streetAdress;
                this.city = city;
                this.state = state;
            }
        }

        public class courses
        {
            public string code { get; set; }
            public string name { get; set; }
            public courses(string code, string name)
            {
                this.code = code;
                this.name = name;
            }
        }

        public class ClassMahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public address address { get; set; }
            public List<courses> courses { get; set; }

            public ClassMahasiswa() { }
            public ClassMahasiswa(string firstName, string lastName, string gender,int age, address address, List<courses> courses)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.gender = gender;
                this.age = age;
                this.address = address;
                this.courses = courses;
            }
        }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Documents\\mod7\\jurnal7_1_1302213039.json");
            ClassMahasiswa mahasiswa = new ClassMahasiswa();
            mahasiswa = JsonSerializer.Deserialize<ClassMahasiswa>(jsonString);
            Console.WriteLine("Nama : " + mahasiswa.firstName + " " + mahasiswa.lastName);
            Console.WriteLine("Gender : " + mahasiswa.gender);
            Console.WriteLine("Age : " + mahasiswa.age);
            Console.WriteLine("Address: " + mahasiswa.address.streetAddress
                + ", " + mahasiswa.address.city + ", " + mahasiswa.address.state);
            Console.WriteLine("Courses: ");

            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i + 1) + " " +
                    mahasiswa.courses[i].name + " - " +
                    mahasiswa.courses[i].code);
            }

        }

    }
}

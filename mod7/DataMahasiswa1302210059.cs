using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace mod7
{
    internal class DataMahasiswa1302210059
    {
        public class Address
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
        public class Courses
        {
            public string code { get; set; }
            public string name { get; set; }
            public Courses(string code, string name)
            {
                this.code = code;
                this.name = name;
            }
        }
        public class ContohClassMahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Address address { get; set; }
            public List<Courses> courses { get; set; }
            public ContohClassMahasiswa(string firstName, string lastName, string gender, int age, Address address, List<Courses> courses)
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
            String jsonString = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Documents\\GitHub\\mod7\\jurnal7_1_1302210059.json");
            ContohClassMahasiswa mahasiswa = JsonSerializer.Deserialize<ContohClassMahasiswa>(jsonString);

            Console.WriteLine("Seorang mahasiswa "+ mahasiswa.gender + ", bernama " + mahasiswa.firstName + " " + mahasiswa.lastName +
                " dengan usia " + mahasiswa.age + " tahun, yang beralamat pada jalan " + mahasiswa.address.streetAddress+" Kota "+ 
                mahasiswa.address.city +" Provinsi "+ mahasiswa.address.state);
            Console.WriteLine("Berikut adalah untuk jadwal kuliahnya: \n");
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i + 1) + " " + mahasiswa.courses[i].name + " - " + mahasiswa.courses[i].code);
            }
        }
    }
}

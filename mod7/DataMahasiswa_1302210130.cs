using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace mod7
{
    internal class DataMahasiswa_1302210130
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\mod7\\jurnal7_1_1302210130.json");
            mhs mahasiswa = new mhs();
            mahasiswa = JsonSerializer.Deserialize<mhs>(jsonString);
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

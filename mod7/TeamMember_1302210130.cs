using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace mod7
{
    internal class TeamMember_1302210130
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\mod7\\jurnal7_2_1302210130.json");
            Kelompok mahasiswa = new Kelompok();
            mahasiswa = JsonSerializer.Deserialize<Kelompok>(jsonString);


            Console.WriteLine("List anggota kelompok : ");
            for (int i = 0; i < mahasiswa.members.Count; i++)
            {
                Console.WriteLine("Mahasiswa ke-" + (i + 1));
                Console.WriteLine("\tNama : "+mahasiswa.members[i].firstName + " - " +
                    mahasiswa.members[i].lastName);
                Console.WriteLine("\tNIM : " +
                    mahasiswa.members[i].nim);
                Console.WriteLine("\tGender :" + mahasiswa.members[i].gender);
                Console.WriteLine("\tUmur :" + mahasiswa.members[i].age);
            }
        }
    }
}

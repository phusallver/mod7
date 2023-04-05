using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace mod7
{
    internal class TeamMembers1302213039
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Documents\\mod7\\jurnal7_1_1302213039.json");
            Kelompok mahasiswa = new Kelompok();
            mahasiswa = JsonSerializer.Deserialize<Kelompok>(jsonString);


            Console.WriteLine("List anggota kelompok : ");
            for (int i = 0; i < mahasiswa.members.Count; i++)
            {
                Console.WriteLine("Mahasiswa ke-" + (i + 1));
                Console.WriteLine("\tNama : " + mahasiswa.members[i].firstName + " - " +
                    mahasiswa.members[i].lastName);
                Console.WriteLine("\tNIM : " +
                    mahasiswa.members[i].nim);
                Console.WriteLine("\tGender :" + mahasiswa.members[i].gender);
                Console.WriteLine("\tUmur :" + mahasiswa.members[i].age);
            }
        }
    }

    internal class Anggota
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }

        public Anggota() { }
    }

    internal class Kelompok
    {
        public List<Anggota> members { get; set; }
    }

    
}

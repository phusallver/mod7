using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static mod7.DataMahasiswa1302210059;

namespace mod7
{
    internal class TeamMembers1302210059
    {
        public class Member
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
        public class Members
        {
            public List<Member> members { get; set; }
            public Members() { }
            public Members(List<Member> members)
            {
                this.members = members;
            }
        }

        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Documents\\GitHub\\mod7\\jurnal7_2_1302210059.json");
            Members Team = JsonSerializer.Deserialize<Members>(jsonString);

            for (int i = 0; i < Team.members.Count; i++)
            {
                Console.WriteLine("Member " + (i + 1) + " ");
                Console.WriteLine("Nama :" +
                    Team.members[i].firstName + " " + Team.members[i].lastName
                    );
                Console.WriteLine("NIM :" + Team.members[i].nim);
                Console.WriteLine("Gender :" + Team.members[i].gender);
                Console.WriteLine("Umur :" + Team.members[i].age);
                Console.WriteLine();
            }
        }
    }
}

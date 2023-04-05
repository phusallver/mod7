using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace mod7
{
    internal class TeamMembers_1302213102
    {
        public void ReadJSON()
        {
            string jsonString = File.ReadAllText("D:\\mod7\\jurnal7_2_1302213102.json");
            Members Team = new Members();
            Team = JsonSerializer.Deserialize<Members>(jsonString);

            for (int i = 0; i < Team.members.Count; i++)
            {
                Console.WriteLine("Member" + (i + 1) + " ");
                Console.WriteLine( "Nama :" +
                    Team.members[i].firstName + " "+ Team.members[i].lastName
                    );
                Console.WriteLine("NIM :" + Team.members[i].nim);
                Console.WriteLine("Gender :" + Team.members[i].gender);
                Console.WriteLine("Umur :" + Team.members[i].age);
                Console.WriteLine();
            }


        }
    }
}

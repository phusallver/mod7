
using mod7;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302210124 ryan = new DataMahasiswa1302210124();
        ryan.ReadJSON();

        Console.WriteLine("\n=======================================\n");
        TeamMembers1302210059 anggota = new TeamMembers1302210059();
        anggota.ReadJSON();
    }
}
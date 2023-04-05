using mod7;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302210059 fadel = new DataMahasiswa1302210059();
        fadel.ReadJSON();

        Console.WriteLine("\n=======================================\n");
        TeamMembers1302210059 anggota = new TeamMembers1302210059();
        anggota.ReadJSON();
    }
}
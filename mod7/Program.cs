using mod7;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302213102 fahryan = new DataMahasiswa_1302213102();
        fahryan.ReadJSON();
        TeamMembers_1302213102 anggota = new TeamMembers_1302213102();
        anggota.ReadJSON();
    }
}
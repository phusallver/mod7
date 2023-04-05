using System;
using System.Text.Json;

public class DataMahasiswa1302210124
{
	public void ReadJSON()
	{
		String jsonString = File.ReadAllText("C:\\Users\\PRAKTIKAN\\Documents\\mod7\\jurnal7_1_1302210124.json");
		ClassMahasiswa mahasiswa = new ClassMahasiswa();
		mahasiswa = JsonSerializer.Deserialize<ClassMahasiswa>(jsonString);

        Console.WriteLine("Seorang mahasiswa berjenis kelamin" + mahasiswa.gender + ", bernama " + mahasiswa.firstName + " " + mahasiswa.lastName +
                " dengan usia " + mahasiswa.age + " tahun, yang beralamat pada jalan " + mahasiswa.address.streetaddress + " Kota " +
                mahasiswa.address.city + " Provinsi " + mahasiswa.address.state);
        Console.WriteLine("Mata Kuliah yang diambil: \n");
        for (int i = 0; i < mahasiswa.courses.Count; i++)
        {
            Console.WriteLine("MK " + (i + 1) + " " + mahasiswa.courses[i].name + " - " + mahasiswa.courses[i].code);
        }
    }


    public class ClassMahasiswa { 
		public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<courses> courses { get; set; }
        public ClassMahasiswa() { }
        public ClassMahasiswa(string firstname, string lastname, string gender, int age, Address address, List<courses> courses)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.courses = courses;
        }


    }

	public class Address {
		public string streetaddress { get; set; }
		public string city { get; set; }
		public string state { get; set; }

		public Address(string streetaddress, string city, string state) { 
			this.streetaddress = streetaddress;
			this.city = city;
			this.state = state;
		}
	}

	public class courses {
		public string code { get; set; }
		public string name { get; set; }

		public courses(string code, string name) { 
			this.code = code;
			this.name = name;
		}
	}
}

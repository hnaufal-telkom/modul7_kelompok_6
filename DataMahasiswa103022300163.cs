using System.Text.Json;
using System.Text.Json.Serialization;

class Data {
    [JsonPropertyName("firstName")]
    public String FirstName { get; set; }
    [JsonPropertyName("lastName")]
    public String LastName { get; set; }
    [JsonPropertyName("gender")]
    public String Gender { get; set; }
    [JsonPropertyName("age")]
    public long Age { get; set; }
    [JsonPropertyName("address")]
    public Address Address { get; set; }
    [JsonPropertyName("courses")]
    public Courses[] Courses { get; set; }
}
class Address
{
    [JsonPropertyName("streetAddress")]
    public String StreetAddress { get; set; }
    [JsonPropertyName("city")]
    public String City { get; set; }
    [JsonPropertyName("state")]
    public String State { get; set; }
}
class Courses
{
    [JsonPropertyName("code")]
    public String Code { get; set; }
    [JsonPropertyName("name")]
    public String Name { get; set; }
}
class DataMahasiswa103022300163 {

  public void ReadJSON() {
        String jsonString = File.ReadAllText("jurnal7_1_103022300163.json");

        try
        {
            Data data = JsonSerializer.Deserialize<Data>(jsonString);

            if (data == null)
            {
                Console.WriteLine("Gagal membaca JSON");
            }

            Console.WriteLine("[[ Data Mahasiswa ]]");
            Console.WriteLine($"Nama\t: {data.FirstName} {data.LastName}");
            Console.WriteLine($"Gender\t: {data.Gender}");
            Console.WriteLine($"Umur\t: {data.Age}");
            Console.WriteLine($"Alamat\t: Jalan {data.Address.StreetAddress}, {data.Address.City}, {data.Address.State}\n");
            Console.WriteLine("Mata Kuliah yang sedang diikuti:");
            foreach (Courses course in data.Courses)
            {
                Console.WriteLine($"- {course.Code} - {course.Name}");
            }
        } catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

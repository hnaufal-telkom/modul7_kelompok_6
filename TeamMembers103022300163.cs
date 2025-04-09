using System.Text.Json;
using System.Text.Json.Serialization;

class Members {
    [JsonPropertyName("firstName")]
    public String FirstName { get; set; }
    [JsonPropertyName("lastName")]
    public String LastName { get; set; }
    [JsonPropertyName("gender")]
    public String Gender { get; set; }
    [JsonPropertyName("age")]
    public long Age { get; set; }
    [JsonPropertyName("nim")]
    public string Nim { get; set; }
}
class DataMember
{
    [JsonPropertyName("members")]
    public Members[] Members { get; set; }
}
class TeamMembers103022300163
{

  public void ReadJSON() {
        String jsonString = File.ReadAllText("jurnal7_2_103022300163.json");

        try
        {
            DataMember data = JsonSerializer.Deserialize<DataMember>(jsonString);

            if (data == null)
            {
                Console.WriteLine("Gagal membaca JSON");
            }

            Console.WriteLine("Team member list:");
            foreach (Members member in data.Members)
            {
                Console.WriteLine($"{member.Nim} {member.FirstName} {member.LastName} ({member.Age} {member.Nim})");
            }
        } catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

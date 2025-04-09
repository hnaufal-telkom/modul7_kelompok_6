using System.Text.Json;
using System.Text.Json.Serialization;

class DataGlossary {
    [JsonPropertyName("GlossDiv")]
    public GlossDiv GlossDiv { get; set; }
}
class GlossDiv
{
    [JsonPropertyName("GlossList")]
    public GlossList GlossList { get; set; }
}
class GlossList
    {
    [JsonPropertyName("GlossEntry")]
    public GlossEntry GlossEntry { get; set; }
}
class GlossEntry
{
    [JsonPropertyName("ID")]
    public string ID { get; set; }
}
class GlossaryItem103022300163
{

  public void ReadJSON() {
        String jsonString = File.ReadAllText("jurnal7_3_103022300163.json");

        try
        {
            DataGlossary data = JsonSerializer.Deserialize<DataGlossary>(jsonString);

            if (data == null)
            {
                Console.WriteLine("Gagal membaca JSON");
            }

            Console.WriteLine($"{data.GlossDiv.GlossList.GlossEntry.ID}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

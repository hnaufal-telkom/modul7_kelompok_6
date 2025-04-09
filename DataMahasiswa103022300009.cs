using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using modul7_kelompok_6;

namespace modul7_kelompok_6
{
    internal class DataMahasiswa103022300009
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("larstName")]
        public string LastName { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("age")]
        public string Age { get; set; }

        [JsonPropertyName("address")]
        public string Address Address { get; set; }

        [JsonPropertyName("Courses")]
        public string List[] Courses { get; set; }

    
        public void ReadJson()
        {
        String filePath = ""@C: \Users\fathirrizky\Downloads\jurnal7_103022300009\modul7_kelompok_6";
        if (File.Exists(filePath))
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            string jsonString = File.ReadAllText(filePath);
            DataMahasiswa103022300009 data = JsonSerializer.Deserialize<DataMahasiswa103022300009>(jsonString, options);
            Console.WriteLine("first name: " + data.FirstName);
            Console.WriteLine("last name: " + data.LastName);
            Console.WriteLine("gender: " + data.Gender);
            Console.WriteLine("age: " + data.Age);
            Console.WriteLine("street: " + data.Address.StreetAddress);
            Console.WriteLine("city: " + data.Address.City);
            Console.WriteLine("state: " + data.Address.State);
            Console.WriteLine("Courses: ");
            foreach (var course in data.Courses)
            {
                Console.WriteLine(course.Code + " - " + course.Name);

            }
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}

public class address
{
    [JsonPropertyName("streetAddress")]
    public string StreetAddress { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }
}

public class Course
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}



        

       public class Course
        {
            [JsonPropertyName("code")]
            public string Code { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }
        }



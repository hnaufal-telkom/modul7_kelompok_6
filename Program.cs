// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa103022300163 dataMh = new DataMahasiswa103022300163();
        dataMh.ReadJSON();

        Console.WriteLine("");

        TeamMembers103022300163 members = new TeamMembers103022300163();
        members.ReadJSON();

        Console.WriteLine("");

        GlossaryItem103022300163 glossary = new GlossaryItem103022300163();
        glossary.ReadJSON();
    }
}

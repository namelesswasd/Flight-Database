using Flight.DataAccess;
using Flight.DataAccess.Repositories;
using Flight.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        FlightRepository f1 = new FlightRepository();
        f1.Create(new FlightInstance(1, "England", "USA", DateTime.Now, 109.9));
        Console.WriteLine(f1.GetToString(1));
    }
}
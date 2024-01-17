namespace park;

public abstract class Transport
{
    public string Destination { get; set; } = "Не определно";
    public int Number { get; set; }
    public DateTime DepartureTime { get; set; }
    public int NumberSeats { get; set; }

    public Transport(string destination, int number, DateTime departureTime, int nmberSeats)
        {
            Destination = destination;
            Number = number;
            DepartureTime = departureTime;
            NumberSeats = nmberSeats;
        }

    public abstract void TransportType();

//метод, который нельзя переопределить
    public void PrintInfo() 
    {
        Console.WriteLine($"Место назначения = {Destination}, \nНомер = {Number}, \nВремя отправления = {DepartureTime}, \nЧисло мест = {NumberSeats}");
    }
}

    namespace park;
    public class WaterTransport : Transport
    {
        public string TrType;

        public WaterTransport(string destination, int number, DateTime departureTime, int nmberSeats) : base(destination, number, departureTime, nmberSeats)
        {
            TrType = "Морской транспорт";
        }
        public override void TransportType()
        {
            Console.WriteLine($"Тип траспорта: {TrType}");
        }
    }
        public class AirTransport : Transport
    {
        public string TrType;

        public AirTransport(string destination, int number, DateTime departureTime, int nmberSeats) : base(destination, number, departureTime, nmberSeats)
        {
            TrType = "Воздушный транспорт";
        }

        public override void TransportType()
        {
            Console.WriteLine($"Тип траспорта: {TrType}");
        }
    }

       public class RoadTransport : Transport
    {
        public string TrType;

        public RoadTransport(string destination, int number, DateTime departureTime, int nmberSeats) : base(destination, number, departureTime, nmberSeats)
        {
            TrType = "Наземный транспорт";
        }

        public override void TransportType()
        {
            Console.WriteLine($"Тип траспорта: {TrType}");
        }
    }
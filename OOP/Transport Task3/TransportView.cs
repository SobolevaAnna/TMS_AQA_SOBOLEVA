    namespace park;
    public class Train : RoadTransport
    {
        public string TrView;

        public Train(string destination, int number, DateTime departureTime, int nmberSeats) : base(destination, number, departureTime, nmberSeats)
        {
            TrView = "Поезд";
        }

        public override void TransportType()
        {
            base.TransportType();
            Console.WriteLine($"Вид траспорта: {TrView}");
        }
    }

    public class Bus : RoadTransport
    {
        public string TrView;

        public Bus(string destination, int number, DateTime departureTime, int nmberSeats) : base(destination, number, departureTime, nmberSeats)
        {
            TrView = "Автобус";
        }

        public override void TransportType()
        {
            base.TransportType();
            Console.WriteLine($"Вид траспорта: {TrView}");
        }
    }

    public class Planes : AirTransport
    {
        public string TrView;

        public Planes(string destination, int number, DateTime departureTime, int nmberSeats) : base(destination, number, departureTime, nmberSeats)
        {
            TrView = "Самолет";
        }

        public override void TransportType()
        {
            base.TransportType();
            Console.WriteLine($"Вид траспорта: {TrView}");
        }
    }

    public class Speedboat : WaterTransport
{
        public string TrView;

        public Speedboat(string destination, int number, DateTime departureTime, int nmberSeats) : base(destination, number, departureTime, nmberSeats)
        {
            TrView = "Катер";
        }

        public override void TransportType()
        {
            base.TransportType();
            Console.WriteLine($"Вид траспорта: {TrView}");
            
        }
    }
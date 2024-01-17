    namespace park;
        internal class TransportService
    {
        public static void PrinttransortType(Transport transport)
        {
            switch (transport)
            {
                case Bus bus:
                    bus.TransportType(); break;
                case Train train:
                    train.TransportType(); break;
                case Planes plane:
                    plane.TransportType(); break;
                case Speedboat speedboat:
                speedboat.TransportType(); break;
        }
        }
    }

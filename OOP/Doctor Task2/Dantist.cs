namespace clinic;

    internal class Dantist : Doctor
    {
        public Dantist(string fio, string category) : base(fio, category) { }
        
        public override void Treatment()
        {
            base.Treatment();
            base.Healing();
        }

        public void Treatment(bool i)
        {
            base.Treatment();
            GetXray();
            InstallSeal();
            InstallBraces(i);
        }

        private void GetXray()
        {
            Console.WriteLine("Сделать рентген зубов");
        }

        private void InstallSeal()
        {
            Console.WriteLine("Поставить пломбу");
        }

        private void InstallBraces(bool i)
        {
            switch(i)
            {
                case true:
                    Console.WriteLine("Установить брекеты"); break;
                case false:
                    Console.WriteLine("Брекеты не нужны"); break;
            } 
        }
    }
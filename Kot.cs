namespace _13_metody
{
    internal class Kot
    {
        public string imie = "brak danych";
        public int wiek;
        public float waga;
        public string kolorOczu;
        public string kolorSiersci;

        private int liczbaZlapanychMyszy;
        private TimeSpan czasNaSnie;
        private DateTime poczatekSnu;

        public void PokazInformacje()
        {
            if (poczatekSnu != DateTime.MinValue)
            {
                czasNaSnie = ObliczCzasSnu();
            }
            Console.WriteLine($"imie: {imie} \nwiek: {wiek} \nwaga: {waga} " +
                $"\nkolor oczu: {kolorOczu} \nkolor siersci: {kolorSiersci} " +
                $"\nliczba zlapanych myszy: {liczbaZlapanychMyszy} \nczas na snie: {czasNaSnie}");
        }

        public void ZlapacMysz()
        {
            Console.WriteLine($"{imie}: mysz zlapana");
            liczbaZlapanychMyszy++;
        }

        public void Spac()
        {
            Console.WriteLine($"{imie} spi");
            poczatekSnu = DateTime.Now;
        }
        
        private TimeSpan ObliczCzasSnu() => DateTime.Now - poczatekSnu;
    }
}

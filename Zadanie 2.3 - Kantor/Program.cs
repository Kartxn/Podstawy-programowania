namespace Zadanie_2._3___Kantor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj kwote w PLN: ");
            double pln = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Podaj walute docelowa: ");
            Console.WriteLine("(USD, EUR, CHF, GBP)");
            
            string currency = Console.ReadLine();
            
            double plnTodollar = 0.25;
            double usdToEur = 0.91;
            double usdToChf = 0.88;
            double usdToGbp = 0.79;

            switch (currency)
            {
                case "USD":
                    double converted = pln * plnTodollar;
                    Console.WriteLine("Po przewalutowaniu " + pln + " PLN jest warte: " + converted + " USD");
                    break;
                case "EUR":
                    double convertedeur = pln * plnTodollar * usdToEur ;
                    Console.WriteLine("Po przewalutowaniu " + pln + " PLN jest warte: " + convertedeur + " EUR" );
                    break;
                case "CHF":
                    double convertedchf = pln * plnTodollar * usdToChf;
                    Console.WriteLine("Po przewalutowaniu " + pln + " PLN jest warte: " + convertedchf + " CHF" );
                    break;
                case "GBP":
                    double convertedgbp = pln * plnTodollar * usdToGbp;
                    Console.WriteLine("Po przewalutowaniu " + pln + " PLN jest warte: " + convertedgbp + " GBP" );
                    break;
                default: 
                    Console.WriteLine("Podano złe dane");
                    break;
            }
            
           
        }
    }
}
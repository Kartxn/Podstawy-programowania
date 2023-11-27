namespace Zadanie_2._1___Twierdzenie_Pitagorasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3.5;
            double b = 6;
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            
            Console.WriteLine(c);
            
            // niepotrzebny kod (zle przeczytane polecenie zadania)

            // Console.Write("Podaj pierwszą przyprostokatną:  ");
            // double x = Convert.ToDouble(Console.ReadLine());
            //
            // Console.Write("Podaj drugą przyprostokatną:  ");
            // double y = Convert.ToDouble(Console.ReadLine());
            //
            // double z = Math.Sqrt(x * x + y * y);
            //
            // Console.WriteLine("Przeciwpostokątna wynosi: " + z);
        }
    }
}
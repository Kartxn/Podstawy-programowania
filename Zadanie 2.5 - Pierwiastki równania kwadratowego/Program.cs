namespace Zadanie_2._5___Pierwiastki_równania_kwadratowego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Podaj liczbe b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Podaj liczbe c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta>0)
            {
                delta = Math.Sqrt(delta);
                double x1 = (-b - delta) / (2*a);
                double x2 = (-b + delta) / (2*a);

                Console.WriteLine("Pierwiastki maja wartosci: \nx1: " + String.Format("{0:0.##}", x1) + " x2 " +
                                  String.Format("{0:0.##}", x2));

            }
            else if (delta == 0)
            {
                double x0 = -b/(2*a);
                Console.WriteLine("Pierwiastek wynosi: " + String.Format("{0:0.##}", x0));
            }
            else
            {
                Console.WriteLine("Rownanie nie ma rozwiazan");
            }
        }
    }
}
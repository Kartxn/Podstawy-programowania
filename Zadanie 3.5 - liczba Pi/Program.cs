namespace Zadanie_3._5_liczba_Pi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Podaj liczbę punktów: ");
                int insquare = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                
                int incircle = 0;
                long start = Environment.TickCount;
                
                for (int i = 0; i <= insquare; i++)
                {
                    double x1 = rnd.Next(-1, 1);
                    double y1 = rnd.Next(-1, 1);

                    double x2 = rnd.NextDouble();
                    double y2 = rnd.NextDouble();
                    
                    double x3 = x1 + x2;
                    double y3 = y1 + y2;   
                    
                    if (x3 * x3 + y3 * y3 <= 1)
                    {
                        incircle++;
                    }
                }
                double pi = 4.0 * incircle / insquare;
                long stop = Environment.TickCount;
                long timer = stop - start;
                
                Console.WriteLine("W kole jest: " + incircle + " punktów");
                Console.WriteLine("Wynik to: " + pi);
                Console.WriteLine("Czas to: " + timer + " ms");
            
            
        }

    }
}

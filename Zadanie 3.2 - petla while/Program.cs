namespace Zadanie_3._2___petla_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double all = 0;
            double min = Int32.MaxValue;
           
                while (true)
                {
                    double x = Convert.ToDouble(Console.ReadLine());
                    
                    all = all + x;

                    if (x<min)
                    {
                        min = x;
                    }

                    if (x == 5)
                    {
                        break;
                    }
                }

                double powall = Math.Pow(all,2);
                
                Console.WriteLine("Suma elementów podniesiona do kwadratu wynosi: " + powall);
                Console.WriteLine("Najmniejszy element wynosi: " + min);
            
            
                
            
        }
    }
}
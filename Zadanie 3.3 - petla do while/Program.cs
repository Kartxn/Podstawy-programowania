namespace Zadanie_3._3___petla_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine(Math.Pow(i,2));
                i++;
            }
            while (i<=20);
        }
    }
}
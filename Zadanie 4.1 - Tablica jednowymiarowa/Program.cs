namespace Zadanie_4._1___Tablica_jednowymiarowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica1 = new int[10];
            
            for (int i = 0; i <= 9; i++ )
            {
                tablica1[i] = i;
                Console.WriteLine(tablica1[i]);
            }
            
        }
    }
}
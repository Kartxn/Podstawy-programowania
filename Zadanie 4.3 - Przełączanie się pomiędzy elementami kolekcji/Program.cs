namespace Zadanie_4._3___Przełączanie_się_pomiędzy_elementami_kolekcji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[100];
            
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = i + 1;
            }
            
            int sumaParzyste = 0;
            
            int sumaNieparzyste = 0;
            
            foreach (int liczba in tablica)
            {
                if (liczba % 2 == 0)
                {
                    sumaParzyste += liczba;
                }
                else
                {
                    sumaNieparzyste += liczba;
                }
            }
            
            Console.WriteLine("Suma liczb parzystych wynosi: " + sumaParzyste);
            Console.WriteLine("Suma liczb nieparzystych wynosi: " + sumaNieparzyste);

        }
    }
}
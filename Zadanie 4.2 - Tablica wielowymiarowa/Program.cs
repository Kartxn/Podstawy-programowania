namespace Zadanie_4._2___Tablica_wielowymiarowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica1 = new int[10,10];
            
            
            for (int i = 0; i <= 9; i++ )
            {
                tablica1[i,i] = i;
            }
            int licznik = 0;

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    Console.Write(tablica1[i, j] + " ");
                    licznik++;

                    if (licznik == 10)
                    {
                        Console.WriteLine();
                        licznik = 0;
                    }
                }
            }
            
            int dod = tablica1[0,0] + tablica1[1,1] + tablica1[2,2] + tablica1[3,3] + tablica1[4,4] +
                     tablica1[5,5] + tablica1[6,6] + tablica1[7,7] + tablica1[8,8] + tablica1[9,9];
            
            Console.WriteLine("\n Suma elementów po przekątnej wynosi: "+dod);

        }
    }
}
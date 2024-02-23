namespace Zadanie_5._5___Obsługa_wyjątków
{
    public class SamplesArrayList
    {

        public static void Main()
        {

            const int size = 10;

            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = 1;
                }
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\barte\OneDrive\Pulpit\dane.txt"))
                {
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            sw.Write(matrix[i, j].ToString() + " ");
                        }

                        sw.WriteLine();
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Błąd podczas zapisu do pliku: " + ex.Message);
            }

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\barte\OneDrive\Pulpit\dane.txt"))
                {
                    for (int i = 0; i < size; i++)
                    {
                        string[] line = sr.ReadLine().Split(' '); 
                        for (int j = 0; j < size; j++)
                        {
                            matrix[i, j] = int.Parse(line[j]);
                        }
                    }
                }
                
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Błąd podczas odczytu z pliku: " + ex.Message);
            }
        }
    }
}
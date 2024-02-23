namespace Zadanie_5._6___Ciąg_Fibonacciego
{
    public class SamplesArrayList
    {
        public static void Main()
        {
            static int Fibo(int n)
            {
                if (n <= 1)
                {
                    return n;
                }
                else
                {
                    return Fibo(n - 1) + Fibo(n - 2);
                }
            }
            
                Console.WriteLine("10 pierwszych liczb Fibonacciego:");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Fibo(i));
                }
        }
    }
}
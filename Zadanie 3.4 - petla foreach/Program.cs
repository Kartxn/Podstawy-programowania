namespace Zadanie_3._4___petla_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pets = { "cat", "dog", "parrot", "guinea pig" };
            
            foreach (string i in pets)
            {
                
                if (i == "dog")
                {
                   
                    Console.WriteLine("End");
                    break;
                    //continue;
                }
                
                Console.WriteLine(i);
                
            }

        }
    }
}
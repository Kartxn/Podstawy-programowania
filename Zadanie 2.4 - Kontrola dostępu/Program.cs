namespace Zadanie_2._4___Kontrola_dostępu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj swój wiek: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Access granted");
            }
            else if(age is <18 and >14 )
            {
                Console.WriteLine("Do you have parental consent? (Y/N)");
                string consent = Console.ReadLine();
                
                if (consent.ToUpper() == "Y")
                {
                    Console.WriteLine("Access granted");
                }
                else if (consent.ToUpper() == "N")
                {
                    Console.WriteLine("Access denied");
                }
                else
                {
                    Console.WriteLine("Wrong character");
                }
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }
    }
}
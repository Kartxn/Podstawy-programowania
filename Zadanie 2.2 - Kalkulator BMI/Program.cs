namespace Zadanie_2._2___Kalkulator_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj swoja wagę: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj swój wzrost w cm:  ");
            double y = Convert.ToDouble(Console.ReadLine());

            double z = x / ((y / 100) * (y / 100));

            Console.WriteLine($"Twoje BMI wynosi: {z:#.##}");
    }
    }
}
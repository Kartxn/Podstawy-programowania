using System;

namespace RectangleAreaCalculator
{
    class Rectangle
    {
        private double a;
        private double b;
        private double surface_area;
        
        public void read_data()
        {
            Console.Write("Podaj długość pierwszego boku: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj długość drugiego boku: ");
            b = Convert.ToDouble(Console.ReadLine());
        }
        
        public void process_data()
        {
            surface_area = a * b;
        }
        
        public void show_results()
        {
            Console.WriteLine($"Bok a: {a:F2}");
            Console.WriteLine($"Bok b: {b:F2}");
            Console.WriteLine($"Pole prostokąta: {surface_area:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.read_data();
            rectangle.process_data();
            rectangle.show_results();
        }
    }
}
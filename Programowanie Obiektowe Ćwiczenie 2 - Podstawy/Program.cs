using System;

namespace NumberSorter
{
    class NumberSorter
    {
        private int[] numbers;
        
        public void read_data()
        {
            numbers = new int[6];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Podaj liczbę {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        public void process_data()
        {
            Array.Sort(numbers);
        }
        
        public void show_results()
        {
            Console.WriteLine("Posortowane liczby:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NumberSorter sorter = new NumberSorter();
            sorter.read_data();
            sorter.process_data();
            sorter.show_results();
        }
    }
}
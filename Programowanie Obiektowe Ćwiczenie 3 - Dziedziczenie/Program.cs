using System;

namespace EmployeeManagement
{
    class Employee
    {
        protected string name;
        protected string lastname;
        protected string street;
        protected string city;
        
        public void read()
        {
            Console.Write("Podaj imię: ");
            name = Console.ReadLine();
            
            Console.Write("Podaj nazwisko: ");
            lastname = Console.ReadLine();
            
            Console.Write("Podaj ulicę: ");
            street = Console.ReadLine();
            
            Console.Write("Podaj miasto: ");
            city = Console.ReadLine();
        }
        
        public void show()
        {
            Console.WriteLine("Dane pracownika:");
            Console.WriteLine($"Imię: {name}");
            Console.WriteLine($"Nazwisko: {lastname}");
            Console.WriteLine($"Ulica: {street}");
            Console.WriteLine($"Miasto: {city}");
        }
    }
    
    class HR : Employee
    {
        private string education;
        private string businessrole;
        
        public void read1()
        {
            read();
            
            Console.Write("Podaj wykształcenie: ");
            education = Console.ReadLine();
            
            Console.Write("Podaj rolę biznesową: ");
            businessrole = Console.ReadLine();
        }
        
        public void show1()
        {
            show();
            Console.WriteLine($"Wykształcenie: {education}");
            Console.WriteLine($"Rola biznesowa: {businessrole}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HR hrEmployee = new HR();
            hrEmployee.read1();
            hrEmployee.show1();
        }
    }
}

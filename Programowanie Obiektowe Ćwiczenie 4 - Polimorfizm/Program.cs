public abstract class Device 
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }

    protected Device(string name, string manufacturer)
    {
        Name = name;
        Manufacturer = manufacturer;
    }
    
    public abstract void DisplayDetails();
}

public class Computer : Device
{
    public string Processor { get; set; }
    public int RAM { get; set; } 

    public Computer(string name, string manufacturer, string processor, int ram)
        : base(name, manufacturer)
    {
        Processor = processor;
        RAM = ram;
    }
    
    public override void DisplayDetails()
    {
        Console.WriteLine($"Computer: {Name}, Manufacturer: {Manufacturer}, Processor: {Processor}, RAM: {RAM} GB");
    }
}

public class Phone : Device
{
    public string OperatingSystem { get; set; }
    public int Storage { get; set; }

    public Phone(string name, string manufacturer, string operatingSystem, int storage)
        : base(name, manufacturer)
    {
        OperatingSystem = operatingSystem;
        Storage = storage;
    }
    
    public override void DisplayDetails()
    {
        Console.WriteLine($"Phone: {Name}, Manufacturer: {Manufacturer}, OS: {OperatingSystem}, Storage: {Storage} GB");
    }
}

public class Printer : Device
{
    public string Type { get; set; } 

    public Printer(string name, string manufacturer, string type)
        : base(name, manufacturer)
    {
        Type = type;
    }
    
    public override void DisplayDetails()
    {
        Console.WriteLine($"Printer: {Name}, Manufacturer: {Manufacturer}, Type: {Type}");
    }
}

public class Router : Device
{
    public int Speed { get; set; }

    public Router(string name, string manufacturer, int speed)
        : base(name, manufacturer)
    {
        Speed = speed;
    }
    
    public override void DisplayDetails()
    {
        Console.WriteLine($"Router: {Name}, Manufacturer: {Manufacturer}, Speed: {Speed} Mbps");
    }
}

class Program
{
    static List<Device> devices = new List<Device>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Add a new device");
            Console.WriteLine("2. Display all devices");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    AddDevice();
                    break;
                case "2":
                    DisplayDevices();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    static void AddDevice()
    {
        Console.WriteLine("Select device type:");
        Console.WriteLine("1. Computer");
        Console.WriteLine("2. Printer");
        Console.WriteLine("3. Router");
        Console.WriteLine("4. Phone");
        Console.Write("Choose an option: ");
        
        string deviceType = Console.ReadLine();

        Console.Clear();

        Console.Write("Enter name: ");
        
        string name = Console.ReadLine();
        
        Console.Write("Enter manufacturer: ");
        
        string manufacturer = Console.ReadLine();

        switch (deviceType)
        {
            case "1":
                
                Console.Write("Enter processor: ");
                
                string processor = Console.ReadLine();
                
                Console.Write("Enter RAM (GB): ");
                
                int ram = int.Parse(Console.ReadLine());
                
                devices.Add(new Computer(name, manufacturer, processor, ram));
                
                break;
            
            case "2":
                
                Console.Write("Enter type (Laser, Inkjet, etc.): ");
                
                string type = Console.ReadLine();
                
                devices.Add(new Printer(name, manufacturer, type));
                
                break;
            
            case "3":
                
                Console.Write("Enter speed (Mbps): ");
                
                int speed = int.Parse(Console.ReadLine());
                
                devices.Add(new Router(name, manufacturer, speed));
                
                break;
            
            case "4":
                
                Console.Write("Enter operating system: ");
                
                string os = Console.ReadLine();
                
                Console.Write("Enter storage (GB): ");
                
                int storage = int.Parse(Console.ReadLine());
                
                devices.Add(new Phone(name, manufacturer, os, storage));
                
                break;
            
            default:
                
                Console.WriteLine("Invalid device type. Please try again.");
                
                break;
        }

        Console.Clear();
        Console.WriteLine("Device added successfully!");
    }

    static void DisplayDevices()
    {
        Console.WriteLine("Devices:");
        foreach (var device in devices)
        {
            device.DisplayDetails();
        }
    }
}
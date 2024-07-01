public interface Vehicle
{
    string Make { get; set; }
    string Model { get; set; }
    int Year { get; set; }
    
    void Start();
    void Stop();
} 

public class Car : Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    
    public int NumberOfDoors { get; set; }
    
    public Car(string make, string model, int year, int numberOfDoors)
    {
        Make = make;
        Model = model;
        Year = year;
        NumberOfDoors = numberOfDoors;
    }
    
    public void Start()
    {
        Console.WriteLine($"{Make} {Model} is starting.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Make} {Model} is stopping.");
    }
    
    public void OpenTrunk()
    {
        Console.WriteLine("The trunk is open.");
    }
}
public class Bus : Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    
    public int PassengerCapacity { get; set; }
    
    public Bus(string make, string model, int year, int passengerCapacity)
    {
        Make = make;
        Model = model;
        Year = year;
        PassengerCapacity = passengerCapacity;
    }
    
    public void Start()
    {
        Console.WriteLine($"{Make} {Model} is starting.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Make} {Model} is stopping.");
    }
    
    public void OpenDoors()
    {
        Console.WriteLine("The bus doors are open.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle = null;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Create a Car");
            Console.WriteLine("2. Create a Bus");
            Console.WriteLine("3. Perform operations on your vehicle");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    vehicle = CreateCar();
                    break;
                case "2":
                    vehicle = CreateBus();
                    break;
                case "3":
                    if (vehicle != null)
                    {
                        PerformVehicleOperations(vehicle);
                    }
                    else
                    {
                        Console.WriteLine("No vehicle created yet.");
                    }
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    static Vehicle CreateCar()
    {
        Console.Write("Enter car make: ");
        
        string make = Console.ReadLine();
        
        Console.Write("Enter car model: ");
        
        string model = Console.ReadLine();
        
        Console.Write("Enter car year: ");
        
        int year = int.Parse(Console.ReadLine());
        
        Console.Write("Enter number of doors: ");
        
        int numberOfDoors = int.Parse(Console.ReadLine());

        return new Car(make, model, year, numberOfDoors);
    }

    static Vehicle CreateBus()
    {
        Console.Write("Enter bus make: ");
        
        string make = Console.ReadLine();
        
        Console.Write("Enter bus model: ");
        
        string model = Console.ReadLine();
        
        Console.Write("Enter bus year: ");
        
        int year = int.Parse(Console.ReadLine());
        
        Console.Write("Enter passenger capacity: ");
        
        int passengerCapacity = int.Parse(Console.ReadLine());

        return new Bus(make, model, year, passengerCapacity);
    }

    static void PerformVehicleOperations(Vehicle vehicle)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Vehicle: {vehicle.Make} {vehicle.Model} ({vehicle.Year})");
            Console.WriteLine("1. Start the vehicle");
            Console.WriteLine("2. Stop the vehicle");
            
            if (vehicle is Car)
            {
                Console.WriteLine("3. Open the trunk");
            }
            else if (vehicle is Bus)
            {
                Console.WriteLine("3. Open the doors");
            }
            
            Console.WriteLine("4. Back to main menu");
            
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    vehicle.Start();
                    break;
                case "2":
                    vehicle.Stop();
                    break;
                case "3":
                    if (vehicle is Car car)
                    {
                        car.OpenTrunk();
                    }
                    else if (vehicle is Bus bus)
                    {
                        bus.OpenDoors();
                    }
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
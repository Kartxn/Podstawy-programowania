namespace Zadanie_5._1___Metoda_Length_na_łańcuchach_tekstowych;
public class SamplesArrayList  {

    public static void Main()  {

        Console.WriteLine("Podaj miasto: ");
        string city = Console.ReadLine();
        
        Console.WriteLine("Podaj wojewodztwo: ");
        string viovodeoship = Console.ReadLine();

        Console.WriteLine("Nazwa miasta " + city + " zawiera "+ city.Length+ " liter. Nazwa województwa" + viovodeoship + " zawiera " +""+ viovodeoship.Length + " liter.");

    }
}
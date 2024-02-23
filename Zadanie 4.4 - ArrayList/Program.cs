using System.Collections;
namespace Zadanie_4._4___ArrayList;
public class SamplesArrayList  {

    public static void Main()  {
        
        ArrayList miasta = new ArrayList();
        
        miasta.Add("Gdańsk");
        miasta.Add("Warszawa");
        miasta.Add("Katowice");
        miasta.Add("Poznań");
        miasta.Add("Kraków");
        miasta.Add("Rzeszów");
        
        miasta.Sort();
        
        foreach (string miasto in miasta)
        {
            Console.WriteLine(miasto);
        }
    }
}
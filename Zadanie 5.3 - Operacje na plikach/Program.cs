namespace Zadanie_5._3___Operacje_na_plikach;
public class SamplesArrayList  {

    public static void Main()  {

        Console.WriteLine("Podaj tytuł książki: ");
        string txt1 = Console.ReadLine();
        
        Console.WriteLine("Podaj nazwisko autora: ");
        string txt2 = Console.ReadLine();
        
        string path = @"C:\Users\barte\OneDrive\Pulpit\library.txt";
        if (!File.Exists(path))
        {
            
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(txt1);
                sw.WriteLine(txt2);
                
            }	
        }
        
        using (StreamReader sr = File.OpenText(@"C:\Users\barte\OneDrive\Pulpit\library.txt"))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
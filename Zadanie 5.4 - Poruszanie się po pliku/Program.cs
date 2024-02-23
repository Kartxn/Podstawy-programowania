namespace Zadanie_5._4___Poruszanie_się_po_pliku;
public class SamplesArrayList  {

    public static void Main()  {

        string x = "Sekwencja kwasów nukleinowych: 5-AATTGGCC-3"; 
        
        string path = @"C:\Users\barte\OneDrive\Pulpit\biodata.txt";
        if (!File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(x);
            }
        }
        
        using (FileStream fs = new FileStream(@"C:\Users\barte\OneDrive\Pulpit\biodata.txt", FileMode.Open, FileAccess.Read))
        {
            fs.Seek(32, SeekOrigin.Begin); 
            
            byte[] buf = new byte[12];
            fs.Read(buf, 0, 12);
            string sekwe = System.Text.Encoding.ASCII.GetString(buf);
            Console.WriteLine(sekwe);
        }
        
        Console.Clear();
        File.Delete(@"C:\Users\barte\OneDrive\Pulpit\biodata.txt");
       
    }
}
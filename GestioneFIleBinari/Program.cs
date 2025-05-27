namespace GestioneFIleBinari;

class Program
{
    static void Main(string[] args)
    {
        string baseFolder = AppDomain.CurrentDomain.BaseDirectory;
        string fileName = "dati.txt";
        string path = Path.Combine(baseFolder, fileName);
        FileStream stream = new(path, FileMode.Open);
        using (stream)
        {
            stream.Seek(0, SeekOrigin.Begin);
        }
        Console.ReadKey();
    }
}

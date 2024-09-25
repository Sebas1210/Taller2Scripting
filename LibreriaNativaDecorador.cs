using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "example.txt";

        
        using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            byte[] data = Encoding.UTF8.GetBytes("Este es un ejemplo de patrón decorador en C#.");
            fileStream.Write(data, 0, data.Length);
        }

        
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        using (BufferedStream bufferedStream = new BufferedStream(fileStream))
        using (StreamReader reader = new StreamReader(bufferedStream))
        {
            
            string content = reader.ReadToEnd();
            Console.WriteLine("Contenido del archivo: ");
            Console.WriteLine(content);
        }

        
        File.Delete(filePath);
    }
}

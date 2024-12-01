using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "input.txt";
        
        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);
            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();

            foreach (string line in lines)
            {
                string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2 && int.TryParse(parts[0], out int left) && int.TryParse(parts[1], out int right))
                {
                    leftList.Add(left);
                    rightList.Add(right);
                }
            }

            Console.WriteLine("Linke Zahlen:");
            Console.WriteLine(string.Join(", ", leftList));

            Console.WriteLine("Rechte Zahlen:");
            Console.WriteLine(string.Join(", ", rightList));
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }
}
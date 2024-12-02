using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "input.txt";
        int distance = 0;
        
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

            leftList.Sort();
            rightList.Sort();

            for (int i = 0; i < rightList.Count; i++)
            {
                int temp = rightList[i] - leftList[i];
                Console.WriteLine(temp);
                distance += Math.Abs(temp);
            }

            Console.WriteLine("The total distance is: " + distance);
        }
        else
        {
            Console.WriteLine("The file does not exist.");
        }
    }
}
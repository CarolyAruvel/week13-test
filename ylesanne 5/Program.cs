using System;
using System.IO;

namespace ylesanne_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples\week13\funfacts.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            Console.WriteLine(dataFromFile[0]);

            Random rnd = new Random();
            int RandomIndex = rnd.Next(1, dataFromFile.Length);
            Console.WriteLine(dataFromFile[RandomIndex]);
        }
    }
}

using System;
using System.IO;

namespace Week13_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string starsFile = @"C:\Users\opilane\samples\week13\stars.txt";
            string planetsFile = @"C:\Users\opilane\samples\week13\planets.txt";
            Console.WriteLine("enter file name:");
            string fileName = Console.ReadLine();
            string newDirectoryFullPath = @$"{starsFile}\{planetsFile}";
            Console.WriteLine(newDirectoryFullPath);

            bool directoryExists = Directory.Exists(newDirectoryFullPath);

            if (directoryExists)
            {
                Console.WriteLine($"{fileName} already exists in {newDirectoryFullPath}");
            }
            else
            {
                Directory.CreateDirectory(newDirectoryFullPath);
                Console.WriteLine($"Directory {fileName} has been created.");
            }

            Directory.CreateDirectory(newDirectoryFullPath);

        }
    }
}

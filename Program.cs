using System;
using System.IO;

namespace FileCategorizer
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Press Enter to categorize files in the current directory...");
            Console.ReadLine();

            string currentDirectory = Directory.GetCurrentDirectory();
            string[] files = Directory.GetFiles(currentDirectory);

            foreach (string file in files)
            {
                string extension = Path.GetExtension(file);

                string destinationFolder = Path.Combine(currentDirectory, extension.TrimStart('.'));
                Directory.CreateDirectory(destinationFolder);

                string destinationFile = Path.Combine(destinationFolder, Path.GetFileName(file));
                File.Move(file, destinationFile);
            }

            Console.WriteLine("Files categorized and moved successfully.");
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}

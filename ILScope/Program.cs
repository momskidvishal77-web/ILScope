using System;
using ILScope.Metadata;

namespace ILScope
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter path to .NET assembly (.dll): ");
            string path = Console.ReadLine();

            if (!System.IO.File.Exists(path))
            {
                Console.WriteLine("File not found.");
                return;
            }

            MetadataExplorer.Explore(path);
        }
    }
}

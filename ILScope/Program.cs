using System;
using System.Reflection;
using ILScope.Core;
using ILScope.Metadata;

namespace ILScope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ILScope - .NET Intermediate Language Disassembler");
            Console.WriteLine("==============================================");

            Console.Write("Enter path to .NET assembly (.dll) : ");
            string? path = Console.ReadLine();

            try
            {
                // Load Assembly
                Assembly assembly = AssemblyLoader.LoadAssembly(path!);
                Console.WriteLine("\n Assembly Loaded Successfully!");
                Console.WriteLine($"Name  : {assembly.FullName}");
                Console.WriteLine($"Location: {assembly.Location}");

                //Metadata Exploration
                MetadataExplorer.PrintTypesAndMethods(assembly);


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
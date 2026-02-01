using System;
using System.Reflection;
using ILScope.Core;

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
                Assembly assembly = AssemblyLoader.LoadAssembly(path!);
                Console.WriteLine("\n Assembly Loaded Successfully!");
                Console.WriteLine($"Name  : {assembly.FullName}");
                Console.WriteLine($"Location: {assembly.Location}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
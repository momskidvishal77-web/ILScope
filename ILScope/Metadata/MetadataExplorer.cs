using System;
using System.Reflection;


namespace ILScope.Metadata
{
    internal class MetadataExplorer
    {
        public static void PrintTypesAndMethods(Assembly assembly)
        {
            Console.WriteLine("\n====METADATA =======\n");

            foreach (Type type in assembly.GetTypes())
            {
                Console.WriteLine($".class {type.FullName}");

                MethodInfo[] methods = type.GetMethods(
                    BindingFlags.Public | BindingFlags.NonPublic |
                    BindingFlags.Instance |
                    BindingFlags.Static |
                    BindingFlags.DeclaredOnly);

                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine($".method {method.ReturnType.Name} {method.Name}()");
                }

                Console.WriteLine();

            }

        }
    }
}

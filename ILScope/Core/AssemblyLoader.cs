using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;
namespace ILScope.Core
{
    internal class AssemblyLoader
    {
        public static Assembly LoadAssembly(string assemblyPath)
        {
            if (!File.Exists(assemblyPath))
            {
                throw new FileNotFoundException("Assembly file not found", assemblyPath);
            }
            assemblyPath = Path.GetFullPath(assemblyPath);

            return AssemblyLoadContext.Default.LoadFromAssemblyPath(assemblyPath);
        }
    }
}

using System;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using ILScope.Utils;

namespace ILScope.IL
{
    public static class ILReader
    {
        public static void ReadMethodIL(
            MetadataReader metadataReader,
            PEReader peReader,
            MethodDefinitionHandle methodHandle)
        {
            var methodDef = metadataReader.GetMethodDefinition(methodHandle);
            string methodName = metadataReader.GetString(methodDef.Name);

            Console.WriteLine($"  .method {methodName}");

            if (methodDef.RelativeVirtualAddress == 0)
            {
                Console.WriteLine("    // No IL body (abstract / extern)");
                return;
            }

            var body = peReader.GetMethodBody(methodDef.RelativeVirtualAddress);
            byte[] ilBytes = body.GetILBytes();

            ILDisassembler.PrintILBytes(ilBytes);
        }
    }
}

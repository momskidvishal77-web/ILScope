using System;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using ILScope.IL;

namespace ILScope.Metadata
{
    public static class MetadataExplorer
    {
        public static void Explore(string path)
        {
            using var stream = File.OpenRead(path);
            using var peReader = new PEReader(stream);

            if (!peReader.HasMetadata)
            {
                Console.WriteLine("No metadata found.");
                return;
            }

            MetadataReader metadataReader = peReader.GetMetadataReader();

            Console.WriteLine("\n===== METADATA =====");

            foreach (var typeHandle in metadataReader.TypeDefinitions)
            {
                var typeDef = metadataReader.GetTypeDefinition(typeHandle);
                string typeName = metadataReader.GetString(typeDef.Name);
                string typeNamespace = metadataReader.GetString(typeDef.Namespace);

                Console.WriteLine($"\n.class {typeNamespace}.{typeName}");

                foreach (var methodHandle in typeDef.GetMethods())
                {
                    ILReader.ReadMethodIL(metadataReader, peReader, methodHandle);
                }
            }
        }
    }
}

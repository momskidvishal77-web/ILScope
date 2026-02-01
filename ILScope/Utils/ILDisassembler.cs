using System;

namespace ILScope.Utils
{
    public static class ILDisassembler
    {
        public static void PrintILBytes(byte[] ilBytes)
        {
            Console.Write("    IL Bytes: ");

            foreach (byte b in ilBytes)
            {
                Console.Write($"{b:X2} ");
            }

            Console.WriteLine();
        }
    }
}

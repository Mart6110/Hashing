using Hashing.Interfaces.Classes;
using Hashing.Interfaces;
using System.Security.Cryptography;

namespace Hashing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nChoose an algorithm:");
                Console.WriteLine("1. MD5");
                Console.WriteLine("2. SHA1");
                Console.WriteLine("3. SHA256");
                Console.WriteLine("4. SHA384");
                Console.WriteLine("5. SHA512");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
                {
                    Console.WriteLine("Invalid choice.");
                    continue;
                }

                if (choice == 6)
                    break;

                HashAlgorithm hashAlgorithm;
                switch (choice)
                {
                    case 1:
                        hashAlgorithm = MD5.Create();
                        break;
                    case 2:
                        hashAlgorithm = SHA1.Create();
                        break;
                    case 3:
                        hashAlgorithm = SHA256.Create();
                        break;
                    case 4:
                        hashAlgorithm = SHA384.Create();
                        break;
                    case 5:
                        hashAlgorithm = SHA512.Create();
                        break;
                    default:
                        hashAlgorithm = MD5.Create();
                        break;
                }

                IHashAlgorithm algorithm;
                if (choice == 1 || choice == 2 || choice == 3 || choice == 4 || choice == 5)
                {
                    algorithm = new HashAlgorithmWrapper(hashAlgorithm);
                }
                else
                {
                    Console.WriteLine("HMAC is not supported in this version.");
                    continue;
                }

                var program = new HashingProgram(algorithm);
                program.Run();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing.Interfaces.Classes
{
    // Handles user interaction and execution flow
    public class HashingProgram
    {
        private readonly IHashAlgorithm _hashAlgorithm;

        public HashingProgram(IHashAlgorithm hashAlgorithm)
        {
            _hashAlgorithm = hashAlgorithm;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nEnter message to hash (press 'Enter' without typing to go back to algorithm selection): ");
                string message = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(message))
                    break;

                byte[] hash = _hashAlgorithm.ComputeHash(message);

                Console.WriteLine("Hash (HEX): " + BitConverter.ToString(hash).Replace("-", ""));
                Console.WriteLine("Press any key to hash another message or 'Enter' to go back to algorithm selection...");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                    break;

                Console.WriteLine();
            }
        }
    }
}

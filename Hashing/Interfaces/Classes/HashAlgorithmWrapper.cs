using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing.Interfaces.Classes
{
    // Implementation of hash algorithm operations
    public class HashAlgorithmWrapper : IHashAlgorithm
    {
        private readonly HashAlgorithm _algorithm;

        public HashAlgorithmWrapper(HashAlgorithm algorithm)
        {
            _algorithm = algorithm;
        }

        public byte[] ComputeHash(byte[] input)
        {
            return _algorithm.ComputeHash(input);
        }

        public byte[] ComputeHash(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            return ComputeHash(bytes);
        }
    }
}

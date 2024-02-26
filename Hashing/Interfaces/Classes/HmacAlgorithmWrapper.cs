using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing.Interfaces.Classes
{
    // Implementation of HMAC algorithm operations
    public class HmacAlgorithmWrapper : IHashAlgorithm
    {
        private readonly HMAC _algorithm;

        public HmacAlgorithmWrapper(HMAC algorithm)
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

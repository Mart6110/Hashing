using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing.Interfaces
{
    // Interface for hash algorithm operations
    public interface IHashAlgorithm
    {
        byte[] ComputeHash(byte[] input);
        byte[] ComputeHash(string input);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibMan
{
    public class Utilities
    {
        public static string CalculateHash(string input)
        {
            byte[] inputByte = Encoding.UTF8.GetBytes(input);
            SHA256 hashValue = SHA256.Create();
            byte[] hashByte = hashValue.ComputeHash(inputByte);
            StringBuilder stringBuilder = new StringBuilder();
            foreach(byte b in hashByte)
            {
                stringBuilder.Append(b.ToString("X2").ToLower());
            }
            return stringBuilder.ToString();
        }
    }
}

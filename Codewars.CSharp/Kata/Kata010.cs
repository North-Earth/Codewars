using System;
using System.Linq;
using System.Net;

namespace Codewars.CSharp.Kata
{
    /// <summary>
    /// Take the following IPv4 address: 128.32.10.1
    /// This address has 4 octets where each octet is a single byte (or 8 bits).
    /// 
    /// 1st octet 128 has the binary representation: 10000000
    /// 2nd octet 32 has the binary representation: 00100000
    /// 3rd octet 10 has the binary representation: 00001010
    /// 4th octet 1 has the binary representation: 00000001
    /// So 128.32.10.1 == 10000000.00100000.00001010.00000001
    /// 
    /// Because the above IP address has 32 bits, we can represent it as the unsigned 32 bit number: 2149583361
    /// Complete the function that takes an unsigned 32 bit number and returns a string representation of its IPv4 address.
    /// </summary>
    public class Kata010
    {
        /// <summary>
        /// My version.
        /// </summary>
        public static string UInt32ToIP(uint ip)
            => IPAddress.Parse(ip.ToString()).ToString();

        #region Best practice according to the community Codewars.

        public static string UInt32ToIPBestPractice1(uint ip)
            => string.Join(".", (new int[] { 24, 16, 8, 0 }).Select(e => ip >> e & 255));

        public static string UInt32ToIPBestPractice2(uint ip)
        {
            var reversed = new IPAddress(ip).ToString().Split('.').Reverse();
            return string.Join(".", reversed);
        }

        public static string UInt32ToIPBestPractice3(uint ip)
        {
            byte[] bytes = BitConverter.GetBytes(ip);
            Array.Reverse(bytes);
            return new IPAddress(bytes).ToString();
        }

        #endregion
    }
}

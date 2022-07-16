using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encode_and_Decode_Strings
{
    public class Program
    {
        //leetcode - https://leetcode.com/problems/encode-and-decode-strings/
        //gfg - https://www.geeksforgeeks.org/decode-the-string-encoded-with-the-given-algorithm/
        static void Main(string[] args)
        {
            var input = "ofrsgkeeeekgs";
            //op = geeksforgeeks
            var ouptput = DecodedString(input);
            Console.WriteLine(ouptput);


        }

        public static string DecodedString(string str)
        {
            var charT = new char[str.Length];
            var mid = str.Length / 2;
            charT[mid] = str[0];

            int count = 1;
            for (int i = 1; i < str.Length; i+=2)
            {
                charT[mid - count] = str[i];
                count++;
            }
            count = 1;
            for (int i = 2; i < str.Length; i+=2)
            {
                charT[mid + count] = str[i];
                count++;
            }
            return new string(charT);
        }
    }
}

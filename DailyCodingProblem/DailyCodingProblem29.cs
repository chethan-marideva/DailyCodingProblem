using System;

namespace ConsoleApp
{
    /// <summary>
    /// Run-length encoding is a fast and simple method of encoding strings. 
    /// The basic idea is to represent repeated successive characters as a single count and character. 
    /// For example, the string "AAAABBBCCDAA" would be encoded as "4A3B2C1D2A".Implement run-length encoding and decoding.
    /// You can assume the string to be encoded have no digits and consists solely of alphabetic characters.
    /// You can assume the string to be decoded is valid.
    /// </summary>
    class DailyCodingProblem29
    {
        public string RunLengthEncode(string str)
        {
            if (String.IsNullOrEmpty(str) || str.Length == 1) return str;

            string retVal = "";
            int count = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1]) count++;
                else
                {
                    if (count > 1) retVal += count.ToString();
                    retVal += str[i - 1].ToString();
                    count = 1;
                }
            }
            if (count > 1) retVal += count.ToString();
            retVal += str[str.Length - 1].ToString();

            return retVal;
        }
    }
}
    

    

   


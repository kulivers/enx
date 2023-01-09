using System;
using System.Text;

namespace enc
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            foreach (var info in Encoding.GetEncodings())
            {
                Console.WriteLine(info.DisplayName);
            }
        }
    }
}
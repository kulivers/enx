using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace enc
{
    internal class Program
    {
        public Program()
        {
        }
        
        public static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            foreach (var e in Encoding.GetEncodings())
            {
                Console.WriteLine(e.DisplayName);
            }
        }
    }
}
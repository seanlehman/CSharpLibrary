using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj1Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "a string";
            string s2 = "This is a \r\n multi-line string";
            Console.WriteLine(s);
            Console.WriteLine();
            Console.WriteLine(s2);

            //Concatenation
            string s3 = s + s2;
            Console.WriteLine($"Concatenation:   {s3}");
            Console.WriteLine();

            

            Console.ReadLine();
        }
    }
}

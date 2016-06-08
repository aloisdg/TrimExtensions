using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimExtensions.Sample {
    class Program {
        static void Main(string[] args) {
            const string source = "ab;cd;ef";

            Console.WriteLine (source.TrimAfterLastOf (";"));
            Console.WriteLine (source.TrimAfterFirstOf (";"));
            Console.WriteLine (source.TrimBeforeLastOf (";"));
            Console.WriteLine (source.TrimBeforeFirstOf (";"));
            Console.ReadLine();
        }
    }
}

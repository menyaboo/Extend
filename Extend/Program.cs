using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace Extend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lib lib = new Lib();
            lib.PrintStr();

            Console.ReadLine();
        }
    }
}

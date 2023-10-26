using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend
{
    internal class Lib
    {
        public string str = "Hello world";

        public void PrintStr(string message = "")
        {
            if (message.Length == 0)
                message = str;
            
            Console.WriteLine(message);
        }
    }
}

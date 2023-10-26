using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extend
{
    public class Lib
    {
        public string str = "Hello world";

        public string PrintStr(string message = "")
        {
            if (message.Length == 0)
                message = str;
            
            return message;
        }
    }
}

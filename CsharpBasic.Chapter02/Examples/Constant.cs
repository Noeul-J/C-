using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter02.Examples
{
    public class Constant
    {
        const float _PIE_VALUE = 3.14f;

        public void Run()
        {
            Console.WriteLine("파이는 {0}", _PIE_VALUE);
        }
    }
}

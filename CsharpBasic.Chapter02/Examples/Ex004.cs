﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter02.Examples
{
    public class Ex004
    {
        public void Run()
        {
            object objValue = 1;
            var vValue = "var";
            dynamic dValue = true;

            Console.WriteLine("object 변수 값은 {0}", objValue);
            Console.WriteLine("var 변수 값은 {0}", vValue);
            Console.WriteLine("dynamic 변수 값은 {0}", dValue);
        }
    }
}

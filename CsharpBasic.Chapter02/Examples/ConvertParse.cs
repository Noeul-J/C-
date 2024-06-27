using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter02.Examples
{
    public class ConvertParse
    {
        public void Run()
        {
            string strNumber = "10";

            // Parse는 문자열 값이 NULL인 경우 에러 발생
            // Convert는 문자열 값이 NULL인 경우 0을 반환

            int convertNumber = Convert.ToInt32(strNumber);
            int parseNumber = Int32.Parse(strNumber);

            Console.WriteLine("{0} + {1} = {2}", convertNumber, parseNumber, convertNumber + parseNumber);
        }
    }
}

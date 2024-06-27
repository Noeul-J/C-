using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter02.Examples
{
    public class Ex005
    {
        public void Run()
        {
            object objHello = "Hello World";
            var vHello = "Hello World";
            dynamic dHello = "Hello World";

            bool isContainsWord01 = objHello.ToString().Contains("Hello");
            bool isContainsWord02 = vHello.ToString().Contains("Hello");
            bool isContainsWord03 = dHello.ToString().Contains("Hello");

            Console.WriteLine("object 변수에 Hello가 포함되어 있다 ? {0}", isContainsWord01);
            Console.WriteLine("var 변수에 Hello가 포함되어 있다 ? {0}", isContainsWord02);
            Console.WriteLine("dynamic 변수에 Hello가 포함되어 있따 ? {0}", isContainsWord03);

            // var는 한번 데이터가 할당되면 다른 타입으로 변경 불가능
            //var vValue = "문자열 테스트";
            //vValue = 10;
            // dynamic는 프로그램이 런타임 될 때 변수 타입을 인식하기 때문에 오류나지 않음
            //dynamic dValue = "문자열 테스트2";
            //dValue = 10;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic.Chapter02.Examples
{
    public class Ex007
    {
        public void Run()
        {
            int korean = 100;
            int english = 100;
            int math = 98;
            int sports = 97;

            // 큰 범위의 데이터 > 작은 범위의 데이터 형 변환시 명시적으로 선언 필요(ex. 실수 > 정수)
            // 암시적 형 변환 double total = korean + english + math + sports;
            int total = korean + english + math + sports;
            double eval = (double)total / 4;

            Console.WriteLine("성적 총점 : {0}", total);
            Console.WriteLine("성적 평균 : {0}", eval);
        }
    }
}

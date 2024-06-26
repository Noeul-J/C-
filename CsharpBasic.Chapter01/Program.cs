namespace CsharpBasic.Chapter01
{
    class Program
    {
        static void Main(String[] args)
        {   //Examples 폴더 안에 Hello 클래스를 불러들여 Run 기능을 수행해라
            Examples.Hello hello = new Examples.Hello();
            hello.Run();
        }
    }
}
using System;

namespace TinyIocTest
{
    public class TestImpl2 : ITestType
    {

        public TestImpl2(string ctorParam)
        {
            Console.WriteLine($"TestImpl2 - In ctor, param: {ctorParam}");
        }

        public void func1(string param1)
        {
            Console.WriteLine($"TestImpl2 - Param1: {param1}");
        }

        public void func2(string param2)
        {
            Console.WriteLine($"TestImpl2 - Param2: {param2}");
        }
    }
}
using System;

namespace TinyIocTest
{
    public class TestImpl1 : ITestType
    {
        //public TestImpl1()
        //{
        //    Console.WriteLine("In ctor");
        //}

        public TestImpl1(string ctorParam)
        {
            Console.WriteLine($"TestImpl1 - In ctor, param: {ctorParam}");
        }

        public void func1(string param1)
        {
            Console.WriteLine($"TestImpl1 - Param1: {param1}");
        }

        public void func2(string param2)
        {
            Console.WriteLine($"TestImpl1 - Param2: {param2}");
        }
    }
}

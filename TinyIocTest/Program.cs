using System;
using TinyIoC;

namespace TinyIocTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cannot use the following to create a container when doing TinyIoCContainer.Current
            // downstream. Current will create a different instance. To fix this, do Current here.
            // Don't do this... var container = new TinyIoCContainer();
            // Do this...
            TinyIoCContainer container = TinyIoCContainer.Current;

            // Inject correct instance of interface based on some runtime decision or config param.
            // Here, will just hard code...
            var configValue = 2;

            if (configValue == 1)
                container.Register<ITestType, TestImpl1>().AsMultiInstance();
            else
                container.Register<ITestType, TestImpl2>().AsMultiInstance();

            var caller = container.Resolve(typeof(Caller));

            Console.ReadLine();
        }
    }
}

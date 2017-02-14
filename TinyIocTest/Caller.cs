using System.Collections.Generic;
using TinyIoC;

namespace TinyIocTest
{
    class Caller
    {
        private ITestType _testType;

        public Caller() 
        {
            var ctorParams = new Dictionary<string, object>();
            ctorParams.Add("ctorParam", "ctorParam value");

            // Resolve injected type and pass in constructor params.
            // Note that we're calling the constructor of the concrete type even though it's not defined in the 
            // interface. Can't define a ctor in the interface. So it's not strictly following the interface.
            // Still all implementations of ITestType must have this constructor to be properly injected here.
            // This works - Type must be registered as multi-instance...
            //      container.Register<ITestType, TestImpl1>().AsMultiInstance();
            ITestType testType = TinyIoCContainer.Current.Resolve<ITestType>(new NamedParameterOverloads(ctorParams));

            testType.func1("test1");
            testType.func2("test2");
        }
    }
}

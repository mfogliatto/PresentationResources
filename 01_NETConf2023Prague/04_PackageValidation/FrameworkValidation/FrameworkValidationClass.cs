using System;

namespace FrameworkValidation
{
    public class FrameworkValidationClass
    {
#if NET6_0
        public void DoSomething()
        {
            // Do something for .NET 6.0
        }
#else
    public void DoSomething(string input)
    {
            // Do something for other when targeting other .NET versions.
    }
#endif
    }
}

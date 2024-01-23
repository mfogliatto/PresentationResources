using UnusedLibraryB;

namespace UnusedReferences
{
    /// <summary>
    /// A class that contains methods that do something interesting.
    /// </summary>
    public class SomeClassUsingLibraryB
    {
        /// <summary>
        /// Invokes a method from Library B.
        /// </summary>
        public static void InvokeMethodInB()
        {
            SomeClassFromB.Bar();
        }
    }
}
using Newtonsoft.Json;

namespace UnusedReferences
{
    /// <summary>
    /// A class that contains methods that do something interesting.
    /// </summary>
    public class SomeClassUsingNewtonsoftJson
    {
        /// <summary>
        /// Invokes a serialize method from Newtonsoft.Json.
        /// </summary>
        public static void InvokeSerialize()
        {
            JsonConvert.SerializeObject(new List<string>());
        }
    }
}
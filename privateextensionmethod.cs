namespace YourOwnNameSpace
{
    using YourExtensionNameSpace;

    static class YourClass
    {
        public static void Test()
        {
            Console.WriteLine("Private extension method".Bracketize());
        }
    }
}

namespace YourOwnNameSpace
{
    namespace YourExtensionNameSpace
    {
        static class YourPrivateExtensions
        {
            public static string Bracketize(this string src)
            {
                return "{[(" + src + ")]}";
            }
        }
    }
}

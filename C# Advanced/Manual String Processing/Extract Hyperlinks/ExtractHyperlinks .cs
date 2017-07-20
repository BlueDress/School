using System;

namespace Extract_Hyperlinks
{
    public class Program
    {
        public static void Main()
        {
            var pattern = @"<a[^>]+?href\s*=\s*('|""|\s?)(.+?)\1(?=\s{1}|>)";
        }
    }
}

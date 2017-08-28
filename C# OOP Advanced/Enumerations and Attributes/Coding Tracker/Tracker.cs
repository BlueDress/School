using System;
using System.Linq;
using System.Reflection;

namespace Coding_Tracker
{
    public class Tracker
    {
        public Tracker()
        {

        }

        public void PrintMethodsByAuthor()
        {
            var type = typeof(Startup);
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            foreach (var methodInfo in methods)
            {
                if (methodInfo.CustomAttributes.Any(n => n.AttributeType == typeof(SoftUniAttribute)))
                {
                    var attributes = methodInfo.GetCustomAttributes(false);

                    foreach (SoftUniAttribute atribute in attributes)
                    {
                        Console.WriteLine($"{methodInfo.Name} is written by {atribute.Name}");
                    }
                }
            }
        }
    }
}

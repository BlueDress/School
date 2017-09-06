using System;
using System.Reflection;

namespace Black_Box_Integer
{
    public class Startup
    {
        public static void Main()
        {
            var type = typeof(BlackBoxInt);

            var blackBoxInst = (BlackBoxInt)Activator.CreateInstance(type, true);

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }

                var tokens = input.Split('_');
                var method = tokens[0];
                var value = int.Parse(tokens[1]);

                type.GetMethod(method, BindingFlags.NonPublic | BindingFlags.Instance).Invoke(blackBoxInst, new object[] { value });

                Console.WriteLine(type.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(blackBoxInst)); 
            }
        }
    }
}

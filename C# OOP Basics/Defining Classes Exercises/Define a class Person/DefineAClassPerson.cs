

using System;
using System.Reflection;

namespace Define_a_class_Person
{
    public class DefineAClassPerson
    {
        public static void Main()
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            var firstPerson = new Person();
            firstPerson.name = "Pesho";
            firstPerson.age = 20;

            var secondPerson = new Person
            {
                name = "Gosho",
                age = 20
            };
        }
    }
}

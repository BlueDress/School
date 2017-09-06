using System;
using System.Linq;
using System.Reflection;

namespace Harvesting_Fields
{
    public class Startup
    {
        public static void Main()
        {
            var type = typeof(HarvestingFields);
            var fieldsInfo = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);

            while (true)
            {
                var command = Console.ReadLine();

                if (command.Equals("HARVEST"))
                {
                    break;
                }

                switch (command)
                {
                    case "private":
                        foreach (var field in fieldsInfo.Where(fld => fld.IsPrivate))
                        {
                            Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                        }

                        break;
                    case "protected":
                        foreach (var field in fieldsInfo.Where(fld => fld.IsFamily))
                        {
                            Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                        }

                        break;
                    case "public":
                        foreach (var field in fieldsInfo.Where(fld => fld.IsPublic))
                        {
                            Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                        }

                        break;
                    case "all":
                        var accessModifier = string.Empty;

                        foreach (var field in fieldsInfo)
                        {
                            if (field.IsPublic)
                            {
                                accessModifier = "public";
                            }
                            else if (field.IsPrivate)
                            {
                                accessModifier = "private";
                            }
                            else
                            {
                                accessModifier = "protected";
                            }

                            Console.WriteLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
                        }
                        break;
                }
            }
        }
    }
}

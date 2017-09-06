using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Mission_Private_Impossible
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fieldsNames)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Class under investigation: {className}");

            var type = typeof(Hacker);

            var classInstance = Activator.CreateInstance(type, new object[] { });

            var fieldsInfo = typeof(Hacker).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);

            foreach (FieldInfo field in fieldsInfo.Where(fld => fieldsNames.Contains(fld.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return sb.ToString();
        }

        public string AnalyzeAcessModifiers(string className)
        {
            var sb = new StringBuilder();

            var type = typeof(Hacker);
            var fieldsInfo = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            var publicMethods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            var nonPublicMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var field in fieldsInfo)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }

            foreach (var method in nonPublicMethods.Where(met => met.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }

            foreach (var method in publicMethods.Where(met => met.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }

            return sb.ToString();
        }

        public string RevealPrivateMethods(string className)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {className}");

            var type = typeof(Hacker);

            sb.AppendLine($"Base Class: {type.BaseType.Name}");
                
            var nonPublicMethods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var method in nonPublicMethods)
            {
                sb.AppendLine(method.Name);
            }

            return sb.ToString();
        }
    }
}

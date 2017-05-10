using System;
using System.Collections.Generic;
using System.Linq;

namespace Fix_Emails
{
    public class FixEmails
    {
        public static void Main()
        {
            var emailList = new Dictionary<string, string>();

            while (true)
            {
                var name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }
                else
                {
                    var email = Console.ReadLine();
                    var temp = email.Split('.').ToArray();

                    if (temp[temp.Length - 1] != "uk" && temp[temp.Length - 1] != "us")
                    {
                        emailList[name] = email; 
                    }
                }
            }
            foreach (KeyValuePair<string, string> item in emailList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

using System;

namespace Students_Results
{
    public class StudentsResults
    {
        public static void Main()
        {
            var numberOfEntries = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}", "Name", "CAdv", "COOP", "AdvOOP", "Average"));

            for (int entry = 0; entry < numberOfEntries; entry++)
            {
                var nameAndResults = Console.ReadLine().Split('-');
                var name = nameAndResults[0].Trim();
                var results = nameAndResults[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var cadv = double.Parse(results[0]);
                var coop = double.Parse(results[1]);
                var advoop = double.Parse(results[2]);

                var average = (cadv + coop + advoop) / 3;

                Console.WriteLine(string.Format("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}", name, cadv, coop, advoop, average));
            }
        }
    }
}

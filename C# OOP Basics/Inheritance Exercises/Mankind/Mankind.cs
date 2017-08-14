using System;

namespace Mankind
{
    public class Mankind
    {
        public static void Main()
        {
            try
            {
                ReadAndPrintData();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void ReadAndPrintData()
        {
            var studentData = Console.ReadLine().Split();
            var studentFirstName = studentData[0];
            var studentLastName = studentData[1];
            var studentFacultyNumber = studentData[2];
            var student = new Student(studentFirstName, studentLastName, studentFacultyNumber);

            var workerData = Console.ReadLine().Split();
            var workerFirstName = workerData[0];
            var workerLastName = workerData[1];
            var workerWeekSalary = decimal.Parse(workerData[2]);
            var workerHoursPerDay = int.Parse(workerData[3]);
            var worker = new Worker(workerFirstName, workerLastName, workerWeekSalary, workerHoursPerDay);

            Console.WriteLine(student.ToString()); 
            Console.WriteLine(worker.ToString()); 
        }
    }
}

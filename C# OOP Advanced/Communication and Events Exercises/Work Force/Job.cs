using System;

namespace Work_Force
{
    public class Job
    {
        private string name;
        private int hoursNeededToComplete;
        private Employee employee;
        private bool isDone;

        public Job(string name, int workHoursNeededToComplete, Employee employee)
        {
            this.name = name;
            this.hoursNeededToComplete = workHoursNeededToComplete;
            this.employee = employee;
            this.isDone = false;
        }

        public bool IsDone { get { return this.isDone; } }

        public void Update()
        {
            this.hoursNeededToComplete -= this.employee.WorkHoursPerWeek;

            if (this.hoursNeededToComplete <= 0)
            {
                //this.OnJobDone(new EventArgs());
                Console.WriteLine($"Job {this.name} done!");
                this.isDone = true;
            }
        }

        //public event EventHandler JobDone;
        //
        //public void OnJobDone(EventArgs args)
        //{
        //    Console.WriteLine($"Job {this.name} done!");
        //
        //    if (this.JobDone != null)
        //    {
        //        this.JobDone(this, args);
        //    }
        //}

        public override string ToString()
        {
            return $"Job: {this.name} Hours Remaining: {this.hoursNeededToComplete}";
        }
    }
}

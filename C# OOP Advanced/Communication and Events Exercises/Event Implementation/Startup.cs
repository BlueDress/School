using System;

namespace Event_Implementation
{
    public class Startup
    {
        public static void Main()
        {
            var dispatcher = new Dispatcher();
            var handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            while (true)
            {
                var name = Console.ReadLine();

                if (name.Equals("End"))
                {
                    break;
                }

                dispatcher.Name = name;
            }
        }
    }
}

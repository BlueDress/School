using System.Collections.Generic;

namespace Border_Control
{
    internal class EntrantsOperationController
    {
        internal List<IEntrant> Entrants { get; }

        internal EntrantsOperationController()
        {
            this.Entrants = new List<IEntrant>();
        }

        internal void RegisterPerson(string[] personData)
        {
            var name = personData[0];
            var age = int.Parse(personData[1]);
            var id = personData[2];

            var person = new Person(name, age, id);

            Entrants.Add(person);
        }

        internal void RegisterRobot(string[] robotData)
        {
            var model = robotData[0];
            var id = robotData[1];

            var robot = new Robot(model, id);

            Entrants.Add(robot);
        }

        internal bool FakeId(string id, string idCheck)
        {
            if (id.EndsWith(idCheck))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

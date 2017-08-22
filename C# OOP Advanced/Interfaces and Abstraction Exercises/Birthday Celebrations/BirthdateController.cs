using System.Collections.Generic;

namespace Birthday_Celebrations
{
    internal class BirthdateController
    {
        internal List<IBirthdayCelebrators> BirthdayCelebrators { get; }

        internal BirthdateController()
        {
            this.BirthdayCelebrators = new List<IBirthdayCelebrators>();
        }

        internal void RegisterPerson(string[] personData)
        {
            var name = personData[0];
            var age = int.Parse(personData[1]);
            var id = personData[2];
            var birthdate = personData[3];

            var person = new Citizen(name, age, id, birthdate);

            BirthdayCelebrators.Add(person);
        }

        internal void RegisterPet(string[] petData)
        {
            var name = petData[0];
            var birthdate = petData[1];

            var pet = new Pet(name, birthdate);

            BirthdayCelebrators.Add(pet);
        }

        internal bool HasBirthday(string birthdate, string yearCheck)
        {
            if (birthdate.EndsWith(yearCheck))
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

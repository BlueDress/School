using System.Collections;
using System.Collections.Generic;

namespace Pet_Clinics
{
    public class PetRegister : IEnumerable<int>
    {
        private List<Pet> pets;
        private int numberOfRooms;

        public PetRegister(int numberOfRooms)
        {
            this.numberOfRooms = numberOfRooms;
            this.pets = new List<Pet>(numberOfRooms);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return AddClinicIterator();
        }

        public Pet this[int index]
        {
            get
            {
                return this.pets[index];
            }
            set
            {
                this.pets[index] = value;
            }
        }

        private IEnumerator<int> AddClinicIterator()
        {
            var centerRoom = this.numberOfRooms / 2;
            yield return centerRoom;

            for (int i = 1; i <= centerRoom; i++)
            {
                    yield return centerRoom - i;
                    yield return centerRoom + i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

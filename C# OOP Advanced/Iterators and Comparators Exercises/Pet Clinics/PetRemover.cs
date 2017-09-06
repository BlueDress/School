using System.Collections;
using System.Collections.Generic;

namespace Pet_Clinics
{
    public class PetRemover : IEnumerable<int>
    {
        private List<Pet> pets;
        private int numberOfRooms;

        public PetRemover(int numberOfRooms)
        {
            this.numberOfRooms = numberOfRooms;
            this.pets = new List<Pet>(numberOfRooms);
        }

        public IEnumerator<int> GetEnumerator()
        {
            return RemoveClinicIterator();
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

        private IEnumerator<int> RemoveClinicIterator()
        {
            for (int i = this.numberOfRooms / 2; i < this.numberOfRooms; i++)
            {
                yield return i;
            }

            for (int i = 0; i < this.numberOfRooms / 2; i++)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

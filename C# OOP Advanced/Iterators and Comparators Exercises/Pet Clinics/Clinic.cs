using System;
using System.Collections.Generic;

namespace Pet_Clinics
{
    public class Clinic
    {
        private string name;
        private int numberOfRooms;
        private List<Pet> pets;
        private PetRegister petRegister;
        private PetRemover petRemover;

        public Clinic(string name, int numberOfRooms)
        {
            this.name = name;
            this.NumberOfRooms = numberOfRooms;
            this.pets = new List<Pet>(new Pet[numberOfRooms]);
            this.petRegister = new PetRegister(numberOfRooms);
            this.petRemover = new PetRemover(numberOfRooms);
        }

        public PetRegister PetRegister { get { return this.petRegister; } }
        public PetRemover PetRemover { get { return this.petRemover; } }


        public int NumberOfRooms
        {
            get { return this.numberOfRooms; }
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException("Invalid Operation!");
                }

                this.numberOfRooms = value;
            }
        }

        public string Name { get { return this.name; } }
        public List<Pet> Pets { get { return this.pets; } }
    }
}

using System;
using System.Collections.Generic;

namespace Pet_Clinics
{
    public class ClinicsOperationsController
    {
        private List<Clinic> clinics;
        private List<Pet> pets;

        public ClinicsOperationsController()
        {
            this.clinics = new List<Clinic>();
            this.pets = new List<Pet>();
        }

        public void CreatePet(params string[] petInfo)
        {
            var name = petInfo[0];
            var age = int.Parse(petInfo[1]);
            var kind = petInfo[2];

            var pet = new Pet(name, age, kind);
            this.pets.Add(pet);
        }

        public void CreateClinic(params string[] clinicInfo)
        {
            var name = clinicInfo[0];
            var numberOfRooms = int.Parse(clinicInfo[1]);

            try
            {
                var clinic = new Clinic(name, numberOfRooms);
                this.clinics.Add(clinic);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool Add(string petName, string clinicName)
        {
            var pet = this.pets.Find(p => p.Name.Equals(petName));
            var clinic = this.clinics.Find(cl => cl.Name.Equals(clinicName));
            
            foreach (var roomIndex in clinic.PetRegister)
            {
                if (clinic.Pets[roomIndex] == null)
                {
                    clinic.Pets[roomIndex] = pet;
                    this.pets.Remove(pet);
                    return true;
                }
            }

            return false;
        }

        public bool Release(string clinicName)
        {
            var clinic = this.clinics.Find(cl => cl.Name.Equals(clinicName));

            foreach (var roomIndex in clinic.PetRemover)
            {
                if (clinic.Pets[roomIndex] != null)
                {
                    clinic.Pets[roomIndex] = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms(string clinicName)
        {
            var clinic = this.clinics.Find(cl => cl.Name.Equals(clinicName));

            for (int i = 0; i < clinic.Pets.Count; i++)
            {
                if (clinic.Pets[i] == null)
                {
                    return true;
                }
            }

            return false;
        }

        public void Print(string clinicName)
        {
            var clinic = this.clinics.Find(cl => cl.Name.Equals(clinicName));

            foreach (var pet in clinic.Pets)
            {
                if (pet != null)
                {
                    Console.WriteLine(pet);
                }
                else
                {
                    Console.WriteLine("Room empty");
                }
            }
        }

        public void Print(string clinicName, int roomNumber)
        {
            var clinic = this.clinics.Find(cl => cl.Name.Equals(clinicName));

            Console.WriteLine(clinic.Pets[roomNumber - 1]);
        }
    }
}

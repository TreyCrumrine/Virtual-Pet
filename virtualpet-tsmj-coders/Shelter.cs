using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Shelter
    {
        private Dictionary<int, Pets> petSanctuary = new Dictionary<int, Pets>();

        public Dictionary<int, Pets> PetSanctuary { get { return petSanctuary; } }

        //public Shelter()
        //{
        //    Pets pet = new OrganicPet("Cocaine", "Bear", 60, 60, 60);
        //    //PetSanctuary.Add(pet.IdNumber, pet);
        //    pet = new OrganicPet("Karen", "Llama", 60, 60, 60);
        //    PetSanctuary.Add(pet.IdNumber, pet);
        //    pet = new RoboticPet("Sebastian", "Titanium Lobster", 60, 60, 60);
        //    PetSanctuary.Add(pet.IdNumber, pet);
        //}

        public void CreateNewPet()
        {
            Console.WriteLine("What New Pet Do You Want to Create?\n Organic or Robotic?");
            string userChoice3 = Console.ReadLine().ToLower();
            if (userChoice3 == "organic")
            {
                OrganicPet orgPet = new OrganicPet();
                Console.WriteLine("What is the species?");
                orgPet.Species = Console.ReadLine();
                Console.WriteLine("What's da wittle guys name?");
                orgPet.Name = Console.ReadLine();
                AddNewPets(orgPet);
            }
            else if (userChoice3 == "robotic")
            {
                RoboticPet robPet = new RoboticPet();
                Console.WriteLine("What is the brand?");
                robPet.Species = Console.ReadLine();
                Console.WriteLine("What's da wittle guys name?");
                robPet.Name = Console.ReadLine();
                AddNewPets(robPet);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please Select Organic or Robotic.");
                CreateNewPet();
            }
        }
        public void AddNewPets(Pets pet)
        {
            PetSanctuary.Add(pet.IdNumber, pet);
            Console.WriteLine("\n");
        }

        public Pets FindPet(int idKey)// what happens if certain pet is not there?
        {
            return PetSanctuary[idKey];
        }


        public void RemovePets()
        {
            Console.WriteLine("Which pet would you like to remove? (Please type pet ID number)\"");
            Pets ToRemove = null;//creating a placeholder for a pet
            int removeChoice = int.Parse(Console.ReadLine());
            ToRemove = FindPet(removeChoice);


            if (ToRemove is not null)
            {
                PetSanctuary.Remove(removeChoice);
                Console.WriteLine("The pet " + ToRemove.Name + " has been removed.");
                Console.WriteLine("\n");              
            }
            else
            {
                Console.WriteLine("Shelter does not contain this animal");
            }
        }


        public void PrintAllPets()
        {
            foreach (var entry in petSanctuary)
            {
                entry.Value.Print();
                
            }
        }
        public void FeedAllPets()
        {
            foreach (var entry in petSanctuary)
            {
                entry.Value.Feed();

            }
        }
        public void PlayAllPets()
        {
            foreach (var entry in petSanctuary)
            {
                entry.Value.Play();

            }
        }
        public void DoctorAllPets()
        {
            foreach (var entry in petSanctuary)
            {
                entry.Value.Doctor();

            }
        }
        /// <summary>
        /// This will tick all pets
        /// </summary>
        public void TickAllPets()
        {
            foreach (var entry in petSanctuary)
            {
                entry.Value.Tick();
            }
        }
    }

}

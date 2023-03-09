using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class OrganicPet : Pets
    {
            
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        

        public OrganicPet(string name, string species, int health, int hunger, int boredom)
        {
            Name = name;
            Species = species;
            Health = health;
            Hunger = hunger;
            Boredom = boredom;
            IdNumber = idNumber++;
        }
        public OrganicPet()
        {
            Name = "PetName";
            Species = "Species";
            Health = 60;
            Hunger = 60;
            Boredom = 60;
            IdNumber = idNumber++;
        }
        public override void Feed()
        {
            Console.WriteLine("What Do You Want to Give Them To Eat?");
            Console.WriteLine("Pizza or Brussel Sprouts?");
            Console.WriteLine("\n");
            string userChoice5 = Console.ReadLine().ToLower();
            if (userChoice5 == "pizza")
            {
                Console.WriteLine("Your Pet Enjoyed That Immensely!");
            }
            else if (userChoice5 == "brussel sprouts")
            {
                Console.WriteLine("Your Pet Has Been Fed....But They Did Not Enjoy the Food. Do Better.\n");
            }
            else
            {
                Console.WriteLine("Unrecognized food, your pet just ate poop.");
            }
            Hunger = Hunger - 10;
            Console.WriteLine("Your Pet's Hunger Level is Now = " + Hunger);

        }
        public override void Play()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Play fetch or go to park? (type park or fetch)");
            Console.WriteLine("\n");
            string userChoice6 = Console.ReadLine().ToLower();
            if (userChoice6 == "fetch")
            {
                Console.WriteLine("Wow! that was so fun!");
            }
            else if (userChoice6 == "park")
            {
                Console.WriteLine("Your Pet had fun with you and others!.\n");
            }
            else
            {
                Console.WriteLine("Ughhhhh, ughhhhhhh, okay... Fun.");
            }
            Console.WriteLine( "Your Pet is Grateful For Your Attention <3\n");
            Boredom = Boredom - 20;
            Hunger = Hunger + 10;
            Health = Health + 10;
            Console.WriteLine("Boredom Level is Now = " + Boredom);
            Console.WriteLine("Hunger Level is Now = " + Hunger);
            Console.WriteLine("Health Level is Now = " + Health);
        }
        public override void Doctor()
        {
            Health = Health + 30;
            Console.WriteLine("Your Pet is Feeling Much Better! \n");
            Console.WriteLine("Health Level is Now = " + Health);
        }
        public override void Tick()
        {
            Hunger = Hunger + 5;
            Boredom = Boredom + 5;
            Health = Health - 5;
        }
        public override void Status()
        {
            Console.WriteLine("Current Status of Your Pet:");
            Console.WriteLine("\n");
            Console.WriteLine("Health Level = " + Health);
            Console.WriteLine("Hunger Level = " + Hunger);
            Console.WriteLine("Boredom Level = " + Boredom);
        }
        public override void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("ID number: " + IdNumber);
            Console.WriteLine("Boredom Level: " + Boredom);
            Console.WriteLine("Health Level: " + Health);
            Console.WriteLine("Hunger Level: " + Hunger);
            Console.WriteLine("\n");
        }
    }
}

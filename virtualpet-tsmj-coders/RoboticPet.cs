using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class RoboticPet : Pets
    {
       
        public int Charge { get; set; }
        public int Fuel { get; set; }
        public int SleepMode { get; set; }
        

        public RoboticPet(string name, string brand, int charge, int fuel, int sleepMode)
        {
            Name = name;
            Species = brand;
            Charge = charge;
            Fuel = fuel;
            SleepMode = sleepMode;
            IdNumber = idNumber++;
            
        }
        public RoboticPet()
        {
            Name = "PetName";
            Species = "Species";
            Charge = 60;//same as health
            Fuel = 60;//same as hunger
            SleepMode = 60;//same as play
            IdNumber = idNumber;
        }

        public override void Feed()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Your RoboPet really enjoyed the fuel.\n");
            Fuel = Fuel - 10;
            Console.WriteLine("The Fuel Level is now = " + Fuel);
        }
        //public override void FeedAll()//-----------------------------------------------ADDED
        //{
        //    Console.WriteLine("Your Pets are now full and sassy!");
        //    Fuel = Fuel - 10;
        //    Console.WriteLine("\n");
        //}

        public override void Play()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Your RoboPet is grateful for your attention\n");
            SleepMode = SleepMode - 20;
            Fuel = Fuel + 10;
            Charge = Charge + 10;
            Console.WriteLine("Sleep Mode Level is now = " + SleepMode);
            Console.WriteLine("Fuel Level is now = " + Fuel);
            Console.WriteLine("Charge Level is now = " + Charge);
        }
        //public override void PlayAll()//-----------------------------------------------ADDED
        //{
        //    Console.WriteLine("Your Pets are Grateful For Your Attention <3\n");
        //    SleepMode = SleepMode - 20;
        //    Fuel = Fuel + 10;
        //    Charge = Charge + 10;
        //}
        public override void Doctor()
        {
            Charge = Charge + 30;
            Console.WriteLine("Your RoboPet is feeling charged up!\n");
            Console.WriteLine("Charge Level is now = " + Charge);
        }
        //public override void DoctorAll()//-----------------------------------------------ADDED
        //{
        //    Charge = Charge + 30;
        //    Console.WriteLine("Your Pets are Feeling Much Better! \n");
        //}
        public override void Tick()
        {
            Fuel = Fuel + 5;
            SleepMode = SleepMode + 5;
            Charge = Charge - 5;
        }
        public override void Status()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Welcome to the Status Screen. Here is the status of your RoboPet.\n");
            Console.WriteLine("Charge Level is now = " + Charge);
            Console.WriteLine("Fuel Level is now = " + Fuel);
            Console.WriteLine("Sleep Mode Level is now = " + SleepMode);
        }

        public override void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("ID number: " + IdNumber);
            Console.WriteLine("Sleep Mode Level: " + SleepMode);
            Console.WriteLine("Charge Level: " + Charge);
            Console.WriteLine("Fuel Level: " + Fuel);
            Console.WriteLine("\n");
        }
    }

}


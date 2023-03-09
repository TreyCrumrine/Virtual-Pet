
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Xml;
using template_csharp_virtual_pet;

Shelter myShelter = new Shelter();

bool isRunning = true;
bool isRunning2 = true;
bool isRunning3 = true;
bool isRunning4= true;

string chosenSpecies;
string chosenName;

Console.WriteLine("\n");
Console.WriteLine("Welcome to Virtual Pet!");
Console.WriteLine("\n");
Console.WriteLine("Let's Create a Pet. Will it be Organic or Robotic? (Please type in your response)\n");
string type = Console.ReadLine().ToLower();// user unput 

string brand = "";
string roboName = "";
string species = "";
string name = "";


while (isRunning3)
{
    switch (type)
    {
        case "robotic":
            Console.WriteLine("\n");
            Console.WriteLine("Ok sweet. What brand?\n");
            brand = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Cool! What's the name of your new Robo Pet?\n");
            roboName = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine(".....that's unique. Sure.");
            Console.WriteLine("\n");
            Console.WriteLine("Press Enter to get to main menu.");
            Console.ReadKey();
            isRunning3 = false;
            break;
        case "organic":
            Console.WriteLine("\n");
            Console.WriteLine("What Kind of Species?\n");
            species = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Cool choice of species....but what should you name it?\n");
            name = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("What a cute name....really original.\n");
            Console.WriteLine("Press Enter to get to main menu.");
            Console.ReadKey();
            isRunning3 = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Please type 'Organic' or 'Robotic'");
            Console.ReadKey();
            isRunning3 = false;
            break;
    }

    Pets pet1 = null;
    if (type == "organic")// depending on what user chooses, the input needs to be stored in the shelter -- suggestion to only add either organic or robotic--  This sectiopn is added
    {
        pet1 = new OrganicPet(name, species, 60, 60, 60);
        myShelter.PetSanctuary.Add(pet1.IdNumber, pet1);
    }
    else
    {
        pet1 = new RoboticPet(roboName, brand, 60, 60, 60);
        myShelter.PetSanctuary.Add(pet1.IdNumber, pet1);
    }
    
    if (type == "organic")// added to conver robotic and organic name and species to one variable representation
    {
        chosenName = name;
        chosenSpecies = species;
    }
    else
    {
        chosenName = roboName;
        chosenSpecies = brand;
    }

    while (isRunning)
    {
        Console.Clear();
        Console.WriteLine("\n");
        Console.WriteLine("Now that you've made your pet....what do you wanna do?");
        Console.WriteLine("\n");
        Console.WriteLine("1. Feed " + chosenName + "\n");
        Console.WriteLine("2. Play with " + chosenName + "\n");
        Console.WriteLine("3. Take " + chosenName + " to the vet\n");
        Console.WriteLine("4. Check how " + chosenName + " the " + chosenSpecies + " is doing?\n");
        Console.WriteLine("5. Head over to the Pet Sanctuary\n");
        Console.WriteLine("Press Enter to Exit\n");
        Console.WriteLine("\n");

        string userChoice = Console.ReadLine().ToLower();
        switch (userChoice)
        {
            case "1":
                Console.Clear();
                pet1.Feed();// works for either organic or robotic
                Console.WriteLine("Press Enter for the main menu.");
                Console.ReadKey();
                break;
            case "2":
                Console.Clear();
                pet1.Play();// works for either organic or robotic
                Console.WriteLine("Press Enter for the main menu.");
                Console.ReadKey();
                break;
            case "3":
                Console.Clear();
                pet1.Doctor();// works for either organic or robotic
                Console.WriteLine("Press Enter for the main menu.");
                Console.ReadKey();
                break;
            case "4":
                Console.Clear();
                pet1.Status();// works for either organic or robotic
                Console.WriteLine("Press Enter for the main menu.");
                Console.ReadKey();
                break;
            case "5":
                Console.Clear();
                isRunning2 = true;
                while (isRunning2)

                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine("Welcome to The Sanctuary! What Would You Like To Do?\n");
                    Console.WriteLine("1. See All The Pets\n");
                    Console.WriteLine("2. Hang Out With Pet(s)\n");
                    Console.WriteLine("3. Create Another Pet\n");
                    Console.WriteLine("4. Remove a Pet From Sanctuary\n");
                    Console.WriteLine("5. Go Back to Menu\n");

                    string userChoice2 = Console.ReadLine().ToLower();
                    switch (userChoice2)
                    {
                        case "1":
                            Console.Clear();
                            myShelter.PrintAllPets();
                            isRunning4 = true;
                            while (isRunning4)
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("What would you like to do with pets?\n");
                                Console.WriteLine("1. Feed Pets\n");
                                Console.WriteLine("2. Hang Out With Pets(s)\n");
                                Console.WriteLine("3. Heal Pets\n");
                                Console.WriteLine("Press Enter for Main Menu.\n");

                                string userChoice3 = Console.ReadLine().ToLower();
                                switch (userChoice3)
                                {
                                    case "1":
                                        Console.Clear();
                                        myShelter.FeedAllPets();
                                        Console.ReadKey();
                                        break;
                                    case "2":
                                        Console.Clear();
                                        myShelter.PlayAllPets();
                                        Console.ReadKey();
                                        break;
                                    case "3":
                                        Console.Clear();
                                        myShelter.DoctorAllPets();
                                        Console.ReadKey();
                                        break;
                                    default:
                                        Console.Clear();
                                        isRunning4 = false;
                                        break;
                                }
                            }
                            
                            break;
                        case "2":
                            Console.Clear();
                            myShelter.PrintAllPets();
                            Console.WriteLine("Which Pet Would You Like to Select to Hang Out With? (Please type their ID number)");
                            Pets toDisplay = null;//creating a placeholder for a pet
                            int selectionChoice = int.Parse(Console.ReadLine());
                            toDisplay = myShelter.FindPet(selectionChoice);
                            if (toDisplay is not null)
                            {
                                toDisplay.Print();
                                Console.WriteLine("Would you like to feed the pet, play with it, or take it to the vet?");
                                string pickChoice = Console.ReadLine().ToLower();
                                if (pickChoice == "feed")
                                {
                                    toDisplay.Feed();
                                }
                                else if (pickChoice == "play")
                                {
                                    toDisplay.Play();
                                }
                                else if (pickChoice == "vet")
                                {
                                    toDisplay.Doctor();
                                }
                                else
                                {
                                    Console.WriteLine("Wasn't an option :/");
                                }
                            }
                            Console.WriteLine("Press Enter To Go Back To Menu.");
                            Console.ReadKey();
                            break;
                        case "3":
                            Console.Clear();
                            myShelter.CreateNewPet();
                            Console.WriteLine("Press Enter To Go Back To Menu..");
                            Console.ReadKey();
                            break;
                        case "4":
                            Console.Clear();                           
                            myShelter.PrintAllPets();
                            myShelter.RemovePets();                         
                            Console.WriteLine("Press Enter To Go Back To Menu.");
                            Console.ReadKey();
                            break;                       
                        default:
                            Console.Clear();
                            isRunning2 = false;
                            break;

                    }
                    myShelter.TickAllPets();
                }
                break;
            default:
                Console.Clear();
                isRunning = false;
                break;
        }
        myShelter.TickAllPets();
    }
}


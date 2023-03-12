using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ZooManagement
{
    internal class Animal
    {
        private string name;
        private int age;
        private string kingdom;
        private string enclosure;
        private string alimentation;
        private string behaviour;

        public string Name
        {
            get { return name; }
            set { name = value[0].ToString().ToUpper() + value.Substring(1).ToLower(); } // Turns the first letter of the name into upper case and the others into lower case.
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (int.TryParse(value.ToString(), out int validAge) & value > 0)
                {
                    age = validAge;
                }
                // Used to check if the user input is valid -> a valid SSN has exactly 9 numbers and only nummbers. 
                // If conversion from String to Int is succesfull, it's value is stored in `validSSN`.
                else
                {
                    age = -1; // If user input is not valid, SSN user input in `CreateAccount` will be asked again until it is valid.
                }
            }
        }

        public string Kingdom
        {
            get { return kingdom; }
            set
            {
                switch (value.ToLower())
                {
                    case "1":
                    case "fish":
                    case "2":
                    case "amphibian":
                    case "3":
                    case "reptile":
                    case "4":
                    case "bird":
                    case "5":
                    case "mammal":
                        kingdom = value[0].ToString().ToUpper() + value.Substring(1).ToLower();
                        break;

                    default:
                        kingdom = null;
                        break;
                }
            }
        }

        public string Enclosure
        {
            get { return enclosure; }
            set
            {
                switch (value.ToLower())
                {
                    case "1":
                    case "wild":
                    case "2":
                    case "captive":
                        enclosure = value[0].ToString().ToUpper() + value.Substring(1).ToLower();
                        break;

                    default:
                        enclosure = null;
                        break;
                }
            }
        }

        public string Alimentation
        {
            get { return alimentation; }
            set
            {
                switch (value.ToLower())
                {
                    case "1":
                    case "herbivore":
                    case "2":
                    case "carnivore":
                    case "3":
                    case "omnivore":
                        alimentation = value[0].ToString().ToUpper() + value.Substring(1).ToLower();
                        break;

                    default:
                        alimentation = null;
                        break;
                }
            }
        }

        public string Behaviour
        {
            get { return behaviour; }
            set
            {
                switch (value.ToLower())
                {
                    case "1":
                    case "aggressive":
                    case "2":
                    case "docile":
                        behaviour = value[0].ToString().ToUpper() + value.Substring(1).ToLower();
                        break;

                    default:
                        behaviour = null;
                        break;
                }
            }
        }

        public Animal()
        {
            Console.WriteLine("Enter the animal's name:");
            Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter the animal's age:");
            while (Age == -1) // Age will be asked from the user again if entry is not valid.
            {
                Age = Convert.ToInt32(Console.ReadLine());
                if (Age == -1)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input for 'Age'. A valid age consist only of integer numbers.");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Enter the animal's age:");
                }
            }
            Console.Clear();

            Console.WriteLine("Enter the animal's kingdom:\n\n1) Fish\n2) Amphibian\n3) Reptile\n4) Bird\n5) Mammal");
            while (Kingdom == null)
            {
                Kingdom = Console.ReadLine();
                if (Kingdom == null)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input for 'Kingdom'. Please enter a valid option (1, 2, 3, 4 or 5).");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Enter the animal's kingdom:\n\n1) Fish\n2) Amphibian\n3) Reptile\n4) Bird\n5) Mammal");
                }
            }
            Console.Clear();

            Console.WriteLine("Enter the animal's enclosuring:\n\n1) Wild\n2) Captive");
            while (Enclosure == null)
            {
                Enclosure = Console.ReadLine();
                if (Enclosure == null)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input for 'Enclosure'. Please enter a valid option (1 or 2).");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Enter the animal's enclosuring:\n\n1) Wild\n2) Captive");
                }
            }
            Console.Clear();

            Console.WriteLine("Enter the animal's alimentation:\n\n1) Herbivore\n2) Carnivore\n3) Omnivore");
            while (Alimentation == null)
            {
                Alimentation = Console.ReadLine();
                if (Alimentation == null)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input for 'Alimentation'. Please enter a valid option (1, 2 or 3).");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Enter the animal's alimentation:\n\n1) Herbivore\n2) Carnivore\n3) Omnivore");
                }
            }
            Console.Clear();

            Console.WriteLine("Enter the animal's behaviour:\n\n1) Aggressive\n2) Docile");
            while (Behaviour == null)
            {
                Behaviour = Console.ReadLine();
                if (Behaviour == null)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input for 'Behaviour'. Please enter a valid option (1 or 2).");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Enter the animal's behaviour:\n\n1) Aggressive\n2) Docile");
                }
            }
            Console.Clear();
        }

        public void ShowAnimal()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("kingdom: " + Kingdom);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Enclosure: " + Enclosure);
            Console.WriteLine("Alimentation: " + Alimentation);
            Console.WriteLine("Behaviour: " + Behaviour);
        }
    }
}
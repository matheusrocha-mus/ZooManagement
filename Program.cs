using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagement
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            bool keepRegistering; // Used to handle invalid user input in every `Console.ReadLine`.
            string input;

            List<Animal> animalList = new List<Animal>();
            List<int> agesFish = new List<int>();
            List<int> agesAmphibian = new List<int>();
            List<int> agesReptile = new List<int>();
            List<int> agesBird = new List<int>();
            List<int> agesMammal = new List<int>();

            do
            {
                Console.WriteLine("Would you like to register a new animal?");
                Console.WriteLine("\n1) Yes\n2) No");
                input = Console.ReadLine();
                Console.Clear();
                switch (input.ToLower())
                {
                    case "yes":
                    case "1":
                        keepRegistering = true;
                        Animal newAnimal = new Animal();
                        animalList.Add(newAnimal);
                        switch (newAnimal.Kingdom)
                        {
                            case "Fish":

                                break;
                            case "Amphibian":
                                break;
                            case "Reptile":
                                break;
                            case "Bird":
                                break;
                            case "Mammal":
                                break;
                        }

                        switch (newAnimal.Enclosure)
                        {

                        }

                        switch (newAnimal.Alimentation)
                        {

                        }

                        switch (newAnimal.Behaviour)
                        {

                        }
                        break;

                    case "no":
                    case "2":
                        keepRegistering = true;
                        if (animalList.Count == 0)
                        {
                            Console.WriteLine("Thank you for using our services! Enter any key to exit.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }

                        else
                        {
                            Console.WriteLine("Here's a list of all new registered animals:\n");
                            foreach (Animal animal in animalList)
                            {
                                animal.ShowAnimal();
                            }
                        }
                        break;

                    default:
                        keepRegistering = false;
                        Console.WriteLine("Invalid input. Please enter a valid option (1 or 2).");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            } while (!keepRegistering);

            Console.WriteLine("\nThank you for using our services! Press any key to exit.");
            Console.ReadKey();
        }
    }
}
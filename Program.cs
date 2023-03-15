using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace ZooManagement
{
    internal class Program
    {
        public static void CalculateAvgAgeByKingdom(List<Animal> animals)
        {
            var kingdomGroups = animals.GroupBy(a => a.Kingdom);

            foreach (var group in kingdomGroups)
            {
                var avgAge = group.Average(a => a.Age);
                Console.WriteLine($"{group.Key}s - {avgAge.ToString("0.00")} years old");
            }
        }

        public static void CalculateAnimalsByEnclosure(List<Animal> animals)
        {
            var enclosureGroups = animals.GroupBy(a => a.Enclosure);

            foreach (var group in enclosureGroups)
            {
                var count = group.Count();
                var percentage = (double)count / animals.Count * 100;
                Console.WriteLine($"{group.Key} - {count} animals ({percentage.ToString("0.00")}%)");
            }
        }

        public static void CalculateFoodIntakeByDiet(List<Animal> animals)
        {
            var dietGroups = animals.GroupBy(a => a.Diet);

            foreach (var group in dietGroups)
            {
                double totalFoodIntake = 0;
                foreach (Animal animal in group)
                {
                    totalFoodIntake += animal.FoodIntake;
                }
                Console.WriteLine($"{group.Key} - {totalFoodIntake} kg");
            }
        }

        public static void Main(string[] args)
        {
            bool keepRegistering; // Used to handle invalid user input in every `Console.ReadLine`.
            string input;
            List<Animal> animalList = new List<Animal>();

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

                        string name = null;
                        while (name == null)
                        {
                            Console.WriteLine("Enter the animal's name:");
                            input = Console.ReadLine();
                            if (!string.IsNullOrEmpty(input) & Regex.IsMatch(input, @"^[a-zA-Z\s]+$"))
                            {
                                string[] names = input.Split(' ');
                                for (int i = 0; i < names.Length; i++)
                                {
                                    names[i] = names[i][0].ToString().ToUpper() + names[i].Substring(1).ToLower();
                                }
                                name = string.Join(" ", names);
                            }
                            else
                            {
                                name = null;
                                Console.Clear();
                                Console.WriteLine("Invalid input. A valid name has no numbers or special characters.");
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                        }
                        Console.Clear();

                        int age = -1;
                        while (age == -1)
                        {
                            Console.WriteLine("Enter the animal's age (years):");
                            input = Console.ReadLine();
                            if (!string.IsNullOrEmpty(input) & int.TryParse(input, out int parsedAge) & parsedAge >= 0)
                            {
                                age = parsedAge;
                            }
                            else
                            {
                                age = -1;
                                Console.Clear();
                                Console.WriteLine("Invalid input. A valid age consists only of integer numbers (animal's years old).");
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                            }
                        }
                        Console.Clear();

                        string kingdom = null;
                        while (kingdom == null)
                        {
                            Console.WriteLine("Enter the animal's kingdom:\n\n1) Fish\n2) Amphibian\n3) Reptile\n4) Bird\n5) Mammal ");
                            input = Console.ReadLine();
                            switch (input.ToLower())
                            {
                                case "1":
                                case "fish":
                                    kingdom = "Fish";
                                    break;
                                case "2":
                                case "amphibian":
                                    kingdom = "Amphibian";
                                    break;
                                case "3":
                                case "reptile":
                                    kingdom = "Reptile";
                                    break;
                                case "4":
                                case "bird":
                                    kingdom = "Bird";
                                    break;
                                case "5":
                                case "mammal":
                                    kingdom = "Mammal";
                                    break;

                                default:
                                    kingdom = null;
                                    Console.Clear();
                                    Console.WriteLine("Invalid input. A valid kingdom would be one of the presented options (1, 2, 3, 4 or 5).");
                                    System.Threading.Thread.Sleep(2500);
                                    Console.Clear();
                                    break;
                            }
                        }
                        Console.Clear();

                        string enclosure = null;
                        while (enclosure == null)
                        {
                            Console.WriteLine("Enter the animal's enclosuring type:\n\n1) Wild\n2) Captive");
                            input = Console.ReadLine();
                            switch (input.ToLower())
                            {
                                case "1":
                                case "wild":
                                    enclosure = "Wild";
                                    break;
                                case "2":
                                case "captive":
                                    enclosure = "Captive";
                                    break;

                                default:
                                    enclosure = null;
                                    Console.Clear();
                                    Console.WriteLine("Invalid input. A valid enclosure would be one of the presented options (1 or 2).");
                                    System.Threading.Thread.Sleep(2500);
                                    Console.Clear();
                                    break;
                            }
                        }
                        Console.Clear();

                        string diet = null;
                        while (diet == null)
                        {
                            Console.WriteLine("Enter the animal's diet:\n\n1) Herbivore\n2) Carnivore\n3) Omnivore");
                            input = Console.ReadLine();
                            switch (input.ToLower())
                            {
                                case "1":
                                case "herbivore":
                                    diet = "Herbivore";
                                    break;
                                case "2":
                                case "carnivore":
                                    diet = "Carnivore";
                                    break;
                                case "3":
                                case "omnivore":
                                    diet = "Omnivore";
                                    break;

                                default:
                                    diet = null;
                                    Console.Clear();
                                    Console.WriteLine("Invalid input. A valid diet would be one of the presented options (1, 2 or 3).");
                                    System.Threading.Thread.Sleep(2500);
                                    Console.Clear();
                                    break;
                            }
                        }
                        Console.Clear();

                        double foodIntake = -1.0;
                        while (foodIntake == -1.0)
                        {
                            Console.WriteLine("Enter the animal's daily food intake (in kilograms):");
                            input = Console.ReadLine();
                            if (!string.IsNullOrEmpty(input) & double.TryParse(input, out double parsedFoodIntake) & parsedFoodIntake > 0)
                            {
                                foodIntake = parsedFoodIntake;
                            }
                            else
                            {
                                foodIntake = -1.0;
                                Console.Clear();
                                Console.WriteLine("Invalid input. A valid daily food intake value consists only of numbers - be it integer or float (animal's daily food intake in kilos).");
                                System.Threading.Thread.Sleep(3000);
                                Console.Clear();
                            }
                        }
                        Console.Clear();

                        string behaviour = null;
                        while (behaviour == null)
                        {
                            Console.WriteLine("Enter the animal's behaviour type:\n\n1) Aggressive\n2) Docile");
                            input = Console.ReadLine();
                            switch (input.ToLower())
                            {
                                case "1":
                                case "aggressive":
                                    behaviour = "Aggressive";
                                    break;
                                case "2":
                                case "docile":
                                    behaviour = "Docile";
                                    break;

                                default:
                                    behaviour = null;
                                    Console.Clear();
                                    Console.WriteLine("Invalid input. A valid behaviour would be one of the presented options (1 or 2).");
                                    System.Threading.Thread.Sleep(2500);
                                    Console.Clear();
                                    break;
                            }
                        }
                        Console.Clear();

                        Animal newAnimal = new Animal(name, age, kingdom, enclosure, diet, foodIntake, behaviour);
                        animalList.Add(newAnimal);
                        break;

                    case "no":
                    case "2":
                        keepRegistering = false;
                        if (animalList.Count == 0)
                        {
                            Console.WriteLine("Thank you for using our services! Enter any key to exit.");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Here's a list of all new registered animals:\n\n");
                            foreach (Animal animal in animalList)
                            {
                                animal.ShowAnimal();
                            }
                            Console.WriteLine("\nPress any key to continue");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Average age of new registered animals for each kingdom:\n");
                            CalculateAvgAgeByKingdom(animalList);
                            Console.WriteLine("\n\nTotal number and percentage of new registered animals for each enclosuring type:\n");
                            CalculateAnimalsByEnclosure(animalList);
                            Console.WriteLine("\n\nTotal daily food intake of new registered animals for each diet type:\n");
                            CalculateFoodIntakeByDiet(animalList);
                        }
                        break;

                    default:
                        keepRegistering = true;
                        Console.WriteLine("Invalid input. Please enter a valid option (1 or 2).");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            } while (keepRegistering);

            Console.WriteLine("\n\nThank you for using our services! Press any key to exit.");
            Console.ReadKey();
        }
    }
}
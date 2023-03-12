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

                        string kingdom = null;
                        while (kingdom == null)
                        {
                            Console.WriteLine("Enter the animal's kingdom:\n\n1) Fish\n2) Amphibian\n3) Reptile\n4) Bird\n5) Mammal ");
                            input = Console.ReadLine();
                            switch (input.ToLower())
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
                                    kingdom = input[0].ToString().ToUpper() + input.Substring(1).ToLower();
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

                        string enclosure = null;
                        while (enclosure == null)
                        {
                            Console.WriteLine("Enter the animal's enclosuring type:\n\n1) Wild\n2) Captive");
                            input = Console.ReadLine();
                            switch (input.ToLower())
                            {
                                case "1":
                                case "wild":
                                case "2":
                                case "captive":
                                    enclosure = input[0].ToString().ToUpper() + input.Substring(1).ToLower();
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

                        string diet = null;
                        while (diet == null)
                        {
                            Console.WriteLine("Enter the animal's diet:\n\n1) Herbivore\n2) Carnivore\n3) Omnivore");
                            input = Console.ReadLine();
                            switch (input.ToLower())
                            {
                                case "1":
                                case "herbivore":
                                case "2":
                                case "carnivore":
                                case "3":
                                case "omnivore":
                                    diet = input[0].ToString().ToUpper() + input.Substring(1).ToLower();
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

                        string behaviour = null;
                        while (behaviour == null)
                        {
                            Console.WriteLine("Enter the animal's behaviour type:\n\n1) Aggressive\n2) Docile");
                            input = Console.ReadLine();
                            switch (input.ToLower())
                            {
                                case "1":
                                case "aggressive":
                                case "2":
                                case "docile":
                                    behaviour = input[0].ToString().ToUpper() + input.Substring(1).ToLower();
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

                        Animal newAnimal = new Animal(name, age, kingdom, enclosure, diet, behaviour);
                        animalList.Add(newAnimal);
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
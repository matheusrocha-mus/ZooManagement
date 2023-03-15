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
        private string diet;
        private double foodIntake;
        private string behaviour;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Kingdom
        {
            get { return kingdom; }
            set { kingdom = value; }
        }

        public string Enclosure
        {
            get { return enclosure; }
            set { enclosure = value; }
        }

        public string Diet
        {
            get { return diet; }
            set { diet = value; }
        }
        public double FoodIntake
        {
            get { return foodIntake; }
            set { foodIntake = value; }
        }

        public string Behaviour
        {
            get { return behaviour; }
            set { behaviour = value; }
        }

        public Animal(string name, int age, string kingdom, string enclosure, string diet, double foodIntake, string behaviour)
        {
            Name = name;
            Age = age;
            Kingdom = kingdom;
            Enclosure = enclosure;
            Diet = diet;
            FoodIntake = foodIntake;
            Behaviour = behaviour;
        }

        public void ShowAnimal()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Kingdom: " + Kingdom);
            Console.WriteLine("Age: " + Age + " years old");
            Console.WriteLine("Enclosure: " + Enclosure);
            Console.WriteLine("Diet: " + Diet);
            Console.WriteLine("Daily food intake (in kilograms): " + FoodIntake + " kg");
            Console.WriteLine("Behaviour: " + Behaviour + "\n");
        }
    }
}
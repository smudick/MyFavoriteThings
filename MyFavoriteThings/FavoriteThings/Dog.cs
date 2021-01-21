using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Weight { get; set;  }

        private bool _snores = true;

        public Dog(string name, string breed, int weight)
        {
            Name = name;
            Breed = breed;
            Weight = weight;
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name}, the {Breed}, is sleeping on the couch");
            if (_snores)
            {
                Console.WriteLine($"{Name} is snoring.");
            }
            else
            {
                Console.WriteLine($"{Name} is sleeping quietly.");
            }
        }

        public void Eat()
        {
            if (Weight > 99)
            {
                Console.WriteLine($"{Name} needs to eat 4 cups of food per day");
            }
            else if (Weight >= 50 && Weight <= 99)
            {
                Console.WriteLine($"{Name} needs to eat 3 cups of food per day");
            }
            else
            {
                Console.WriteLine($"{Name} needs to eat 2 cups of food per day");
            }
        }
    }
}

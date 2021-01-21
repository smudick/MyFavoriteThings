using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    public class Food
    {
        public string Name { get; set; }
        public string Flavor { get; set; }
        public int Calories { get; set; }
        public string[] Ingredients { get; set; }

        private bool _isReadyToEat = false;

        public Food(string name, string flavor, int calories, string[] ingredients)
        {
            Name = name;
            Flavor = flavor;
            Calories = calories;
            Ingredients = ingredients;
        }

        public void Cook()
        {
            Console.WriteLine($"To prepare {Name}, combine {Ingredients[0]}, {Ingredients[1]}, and {Ingredients[2]}.");
            _isReadyToEat = true;
        }

        public void HealthCheck()
        {
            if (Calories <= 500)
            {
                Console.WriteLine($"{Name} is a healthy food.");
            }
            else
            {
                Console.WriteLine($"{Name} is not a healthy food.");
            }
        }
    }
}

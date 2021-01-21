using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.FavoriteThings
{
    class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public string FamousFor { get; set;  }

        public City(string name, string country, int population, string famousFor)
        {
            Name = name;
            Country = country;
            Population = population;
            FamousFor = famousFor;
        }

        public void Welcome()
        {
            Console.WriteLine($"Welcome to {Name}, {Country}! Here we are famous for {FamousFor}");
        }
        public void Census()
        {
            if (Population > 1000000)
            {
                Console.WriteLine($"{Name} is a very large city");
            }
            else
            {
                Console.WriteLine($"{Name} is not too large of a city");
            }
        }
    }
}

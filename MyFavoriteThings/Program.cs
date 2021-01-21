using System;
using MyFavoriteThings.FavoriteThings;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Food food1 = new Food("Green Chile Enchiladas", "Spicy", 1000, new string[]{ "Green Chiles", "Tortillas", "Cheese" });
            Food food2 = new Food("Ice Cream", "Sweet", 1500, new string[] { "Ice", "Cream", "Toppings" });
            food1.Cook();
            food2.Cook();
            food1.HealthCheck();
            food2.HealthCheck();

            Dog dog1 = new Dog("Pepper", "Mastiff", 115);
            Dog dog2 = new Dog("Goose", "Hound", 55);
            dog1.Sleep();
            dog2.Sleep();
            dog1.Eat();
            dog2.Eat();

            City city1 = new City("Florence", "Italy", 400000, "Art and Wine");
            City city2 = new City("Amsterdam", "Netherlands", 1200000, "Canals and Bicycles (and maybe drugs)");
            city1.Welcome();
            city2.Welcome();
            city1.Census();
            city2.Census();
        }

    }
}

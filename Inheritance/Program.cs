using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird Cardinal = new Bird()
            {
                CanFly = true,
                HasFeathers = true,
                Sound = "Chrip Chirp",
                Habitat = "Woodland",
                Name = "Cardinal",
                Age = 3,
                Color = "Red",
                Legs = 2,
            };

            Console.WriteLine($"My {Cardinal.Name} is a {Cardinal.Age} year old bird. He has {Cardinal.Legs} legs and is {Cardinal.Color}.");
            Console.WriteLine($"He makes a {Cardinal.Sound} sound and lives in a {Cardinal.Habitat} habitait");
            Console.WriteLine($"Can he fly? {Cardinal.CanFly}");
            Console.WriteLine($"Does he have feathers? {Cardinal.HasFeathers}");

            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Reptile BeardedDragon = new Reptile()
            {
                IsWarmBlooded = false,
                HasBackbone = true,
                IsPoisonous = false,
                LiveBearing = false,
                Name = "Bearded Dragon",
                Age = 9,
                Color = "Olive green",
                Legs = 4,
            };
             
            Console.WriteLine($"My {BeardedDragon.Name} is a {BeardedDragon.Age} year old reptile. She has {BeardedDragon.Legs} legs and is a {BeardedDragon.Color} color.");
            Console.WriteLine($"Is she warm blooded? {BeardedDragon.IsWarmBlooded}");
            Console.WriteLine($"Does she have a back bone? {BeardedDragon.HasBackbone}");
            Console.WriteLine($"Is she poisonous? {BeardedDragon.IsPoisonous}");
            Console.WriteLine($"Does she bear live young? {BeardedDragon.LiveBearing}");

        } 
    }  
}  
        
   

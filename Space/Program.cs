using System;
using System.Collections.Generic;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> otherPlanetList = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(otherPlanetList);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            // GetRange takes in the index to start with + the number of items
            var rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine($"Planet list: {String.Join(",", rockyPlanets)}");

            Console.WriteLine($"Planet list: {String.Join(",", planetList)}");

            planetList.Remove("Pluto");

            Console.WriteLine($"Planet list: {String.Join(",", planetList)}");

            var spaceshipInfo = new Dictionary<string, List<string>>();

            spaceshipInfo.Add("Entreprise", new List<string>() { "Mars", "Venus", "Neptune"});
            spaceshipInfo.Add("Voyager", new List<string>() { "Earth", "Jupiter" });
            spaceshipInfo.Add("Delta Flyer", new List<string>() { "Mercury", "Mars" });
            spaceshipInfo.Add("Yamato", new List<string>() { "Venus", "Earth", "Saturn", "Uranus" });

            foreach (var planet in planetList)
            {
                var listOfSpaceships = new List<string>();

                foreach(var spaceship in spaceshipInfo)
                {
                    if (spaceship.Value.Contains(planet))
                    {
                        listOfSpaceships.Add(spaceship.Key);
                    }
                }
                Console.WriteLine($"{planet}: {String.Join(", ", listOfSpaceships)}");
            }

        }
    }
}

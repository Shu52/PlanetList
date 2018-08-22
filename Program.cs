using System;

namespace lists
{
    using System.Collections.Generic; // Namespace containing data structures
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> morePlanetList = new List<string>(){"Uranus", "Neptune"};
            planetList.AddRange(morePlanetList);
            planetList.Insert( planetList.IndexOf( "Jupiter" ), "Earth" );
            planetList.Insert( planetList.IndexOf( "Jupiter" ), "Venus" );
            planetList.Add("Pluto");
            List<string> rockyPlanets = planetList.GetRange(0,4);
            planetList.Remove("Pluto");
        }
    }
}

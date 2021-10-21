using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryView
    {
        public Country DisplayCountry;
        public CountryView(Country country)
        {
            DisplayCountry = country;
        }
        public void Display()
        {
            Console.Clear();
            Console.WriteLine($"Name: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}");
            Console.WriteLine("Flag Colors:");
            foreach (string c in DisplayCountry.Colors)
            {
                ConsoleColor color;
                Enum.TryParse(c , out color);
                Console.ForegroundColor = color;               
                Console.WriteLine($"{c}");
                Console.ResetColor();               
            }
           
        }
    }
}

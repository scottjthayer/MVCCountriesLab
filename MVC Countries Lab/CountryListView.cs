using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> countryList)
        {
            Countries = countryList;
        }

        public void Display()
        {
            foreach (Country c in Countries)
            {       
                Console.WriteLine($"{Countries.IndexOf(c) + 1}. {c.Name}");
            }
        }
    }
}

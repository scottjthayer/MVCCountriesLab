using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries_Lab
{
    class CountryController
    {
        public List<Country> CountryDb { get; set; }

        public CountryController()
        {
            CountryDb = new List<Country>
            {
                new Country("USA", "North America", new List<string>{"Red", "White", "Blue"}),
                new Country("Japan", "Asia", new List<string>{"Red", "White"}),
                new Country("Ghana", "Africa", new List<string>{"Red", "Yellow", "Green"}),
                new Country("Bangladesh", "Asia", new List<string>{"Red", "Green"}),
                new Country("Vietnam", "Asia", new List<string>{"Red", "Yellow"}),
                new Country("Greece", "Europe", new List<string>{"Blue", "White"}),
                new Country("Ukraine", "Europe", new List<string>{"Blue", "Yellow"}),
                new Country("Honduras", "North America(Central)", new List<string>{"Blue", "White"}),
            };
        }

        public void CountryAction(Country c)
        {
            CountryView cV = new CountryView(c);
            cV.Display();
        }

        public void WelcomeAction()
        {
            CountryListView cLV = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country number from the following list:");       
            CountryListAction(cLV);
        }

        public void CountryListAction(CountryListView cLV)
        {
            cLV.Display();
            int input = Validator.Validator.GetNumber(1, CountryDb.Count);
            CountryAction(CountryDb[input - 1]);

        }
    }
}

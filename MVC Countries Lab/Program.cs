using System;

namespace MVC_Countries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController control = new CountryController();
            bool run = true;
            while (run == true)
            {
                control.WelcomeAction();
                run = Validator.Validator.getContinue("\nWould you like to learn about a different country?");
                Console.Clear();
            }
            Console.WriteLine("Thank you for using the Country Information Database Application.");


        }
    }
}

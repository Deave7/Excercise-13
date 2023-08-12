using System.Collections.Immutable;
using System.Runtime.CompilerServices;

namespace Excercise_13
{
    internal class Program
    {
        class Cat
        {

            public Cat(int catAge, string catRace, string catName)
            {
                this.catAge = catAge;
                this.catRace = catRace;
                this.catName = catName;
            }

            public Cat()
            {
                
            }

            private int catAge;
            private string catRace;
            private string catName;


            public static void Fetch()
            {
                Console.WriteLine("Are you crazy? A cat would never fetch something for you");
            }

            public  void Meow()
            {
                
                if (catAge < 1)
                {
                    Console.WriteLine("MEEEEEEEEeeeeEEEEEoooOOOOOW");
                }
                else
                {
                    Console.WriteLine("The cat just stares at you like you're the dumbest thing it's ever seen");
                }
            }

            public int CatAge
            {
                get
                {
                    return catAge;
                }
                set
                {
                    catAge = value;
                }
            }

            public string CatRace
            {
                get
                {
                    return catRace;
                }
                set
                {
                    catRace = value;
                }
            }

            public string CatName
            {
                get
                {
                    return catName;
                }
                set 
                { 
                    catName = value; 
                }
            }

        } //Övning 13.3-13.5

        class City //del av övning 13.6
        {
           public string name;
           public double temperature;

            public  City(string name, double temperature)
            {
                this.name = name;
                this.temperature = temperature;
            }

            
        }

        static void Exempel136() //Övning 13.6
        {
           IList<City> cities = new List<City>(); //Initierar en lista för objekt av klassen City

            /* test städer 
            cities.Add(new City("Lidköping", 15));
            cities.Add(new City("Borås", 20));
            cities.Add(new City("Stockholm", 5));
            cities.Add(new City("Backamo", 10));
            */

            Console.WriteLine("This program will let you enter cities with a temperature reading.");

            while (true) //Loopar tills användaren väljer att avsluta programmet 
            {
                
                //Skriver ut menyn
                Console.WriteLine("Please make a choose a option from the menu: ");
                Console.WriteLine("[A]dd city");
                Console.WriteLine("[T]emperatrues");
                Console.WriteLine("[M]ean temperature");
                Console.WriteLine("[H]ighest and lowest temperatures");
                Console.WriteLine("[Q]uit");

                string choice = Console.ReadLine(); //läser in användarinput

                switch (choice.ToUpper()) //switchsatsen kollar på variablen choice, .ToUpper sätter användarens svar till stora bokstäver 
                {
                    case "A":
                       
                        try
                        {
                            Console.Write("Please input the name of the city you want to add: ");
                            string cityName = Console.ReadLine();
                            Console.Write("Please input the temperature of the city:  ");
                            double cityTemperature = Convert.ToDouble(Console.ReadLine());

                            cities.Add(new City(cityName, cityTemperature)); //lägger till ett nytt City objekt i listan 

                            break;
                        }
                        catch
                        {
                            Console.WriteLine("You have to use letters for the name of the city and numbers for the temperature, try again!\n");
                            break;
                        }
                       
                    case "T":

                        if (cities.Count <= 0)
                        {
                            Console.WriteLine("There are no cities in the program yet, please add some!");
                        }
                        else
                        {
                            Console.WriteLine("Printing temperatures: ");
                            Console.WriteLine("-----------------");

                            //skriver ut alla städet i listan samt deras temperaturer
                            for (int i = 0; i < cities.Count; i++)
                            {
                                Console.WriteLine($"City name: {cities[i].name}, temperature: {cities[i].temperature}");
                            }

                            Console.WriteLine("-----------------\n");

                            
                        }

                        break;

                    case "M":

                        if (cities.Count <= 0)
                        {
                            Console.WriteLine("There are no cities in the program yet, please add some!");
                        }
                        else
                        {
                            //räknar ut medeltemperaturen
                            double sumTemperature = 0;
                            double meanTemperature = 0;

                            for (int i = 0; i < cities.Count; i++)
                            {
                                sumTemperature += cities[i].temperature;
                            }

                            meanTemperature = sumTemperature / cities.Count;

                            Console.WriteLine($"The mean temperature is: {meanTemperature}");
                            Console.WriteLine("");

                        }

                        break;

                    case "H":

                        if (cities.Count <= 0)
                        {
                            Console.WriteLine("There are no cities in the program yet, please add some!");
                        }
                        else
                        {
                            //Sorterar listan efter temperatur och skriver ut staden med den högsta och lägsta temperaturen 
                            cities.OrderBy(cities => cities.temperature).ToList();
                            Console.WriteLine($"{cities[0].name} has a temperature of {cities[0].temperature} which is the lowest");
                            Console.WriteLine($"{cities[cities.Count - 1].name} has a temperature of {cities[cities.Count - 1].temperature} which is the highest");
                            Console.WriteLine("");

                        }

                        break;

                    case "Q":
                        Console.WriteLine("The program is closing, see you next time");
                        return;

                    default:
                        Console.WriteLine("Your input was incorrect, please choose a option from the menu\n");
                        break;
                }
            }
            
            
        }

        static void Main(string[] args)
        {
            Exempel136();
        }
    }
}
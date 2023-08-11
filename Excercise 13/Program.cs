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



        static void Main(string[] args)
        {
           
        }
    }
}
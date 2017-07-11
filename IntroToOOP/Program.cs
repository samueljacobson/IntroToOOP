using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //When we initialize a new object, it is called INSTANTIATING (creating a new instance)
            //An object needs to be instantiated before it can be used
            //All objects of a specific type are created from the same template - CLASS
            //All objects from a class will have the same number and type of states, BUT...
            //each instance can have it's own unique values.

            //Format to instantiate an object:
            //ClassName objectName = new ClassName();
            Cat firstCat = new Cat();  //only used "new" keyword when using a constructor

            firstCat.Name = "Mittens";
            Console.WriteLine(firstCat.Age);

            Cat secondCat = new Cat("Oz", 3, "Orange and white");
            secondCat.Name = "Ozzy";   //.Name can change value
            Console.WriteLine(secondCat.Name);
            Console.WriteLine(secondCat.Age);
            secondCat.Eat();

            //To create a new object, we use a special m ethod called a CONSTRUCTOR

            //Thinking about objects in real life, create 3 examples with 5 states and 5 behaviors


            Superhero firstHero = new Superhero();  //to instantiate an object
            firstHero.StrengthLevel = 100;
            firstHero.HasCape = true;

            firstHero.BattleNemesis();
            Console.WriteLine(firstHero.HasCape);  //returns false
            Console.WriteLine(firstHero.StrengthLevel);  //returns 90

            firstHero.BattleNemesis();
            Console.WriteLine(firstHero.HasCape);  //returns false
            Console.WriteLine(firstHero.StrengthLevel);  //returns 80

            Superhero secondHero = new Superhero("Diamond Daniel");
            Console.WriteLine(secondHero.StrengthLevel);    //returns 100 (default, see constructor)

            secondHero.AllyGained();
            Console.WriteLine(secondHero.StrengthLevel);    //returns 110

            Superhero thirdHero = new Superhero("black Kevlar armor", "The Best Ever", 1000, "Being the best", false);

            thirdHero.BattleNemesis();
            Console.WriteLine("Oh no! Now my costume is " + thirdHero.Costume);     //returns tattered
            Console.WriteLine("And my strength has diminished to " + thirdHero.StrengthLevel);  //returns 990
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        //Inside of our class, we create the blueprint for our object
        //Classes are templates in OOP that we use to create objects
        //Named in Pascal Case

        //In OOP, there are two types of States:
        //Fields - variables that belong to a class
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //Properties - mix between a field and method that allow controlled access
        public string Name          //default setup
            {
                get {return this.name;}  //get returns the associated value, this.name points to object
                set {this.name = value;}
            }

        public int Age
        {
            get { return this.age; }  //in properties ; inside {}
        }

        //Behaviors:
        //Methods - repeatable/resuable sections of code

        //Constructors - specialized methods used when instantiating an object
        //  - allow us to control the state of an object upon creation
        //  - allow us to perform any actions the object might need upon creation
        //  - always share the name of the class
        //  - can have as many constructors as needed, as long as each have a unique signature (i.e. parameters in same data type order)
        public Cat()
        {
            //This is an example of a default constructor. A default constructor takes not arguments or parameters
            //Create oject without setting any values to fields
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;       //.this sets equal to the field, for defining specific instances of Cat
            this.age = age;
            this.furColor = furColor;
        }

        public void Eat()
        {
            if(isHungry)        //method
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);
        }
    }
}

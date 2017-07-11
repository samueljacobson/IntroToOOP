using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        //Create a Dog class
        //Should have fields for hair length, height, running speed, weight
        //Should have the following behaviors: run, bark, potty, cuddle
        //Should have at least one constructor

        //Fields
        private string hairLength;
        private double height;
        private double runningSpeed;
        private double weight;
        private bool crap = true;

        //Properties - give public access to private fields from program class
        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public double RunningSpeed
        {
            get { return this.height; }
            set { this.height = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public double BarkVolume { get; set; } //shortcut for default, creates barkVolume field as well


        //Constructors
        public Dog ()  //default
        {

        }

        public Dog (string hairLength, double height, double runningSpeed, double weight)
        {
            this.hairLength = hairLength;  //this.X are fields, after "=" refers to parameters)
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        //Behaviors
        public double Run()
        {
            Console.WriteLine("Go doggy go!!");
            RunningSpeed -= 1;
            return RunningSpeed;
        }

        public void Bark()
        {
            Console.WriteLine("Bork bork bork!");
        }

        public void Potty()
        {
            if(crap == true)        //property for crap not created, therefore always true
            {
                Console.WriteLine("Your dog just made a mess.");
            }
            else
            {
                Console.WriteLine("Your dog has to relive itself.");
            }
        }
        public void Cuddle()
        {
            Console.WriteLine("Aww, dog is so sweet.");
        }

    }
    
}

﻿using System;
using System.Collections.Generic;
using static System.Console;

namespace GeneralLibrary
{
    public class Person : IComparable<Person>
    {
        // Member Variables
        /*
        Fileds: 
            - Constant : Data can never change
            - Read - Only : Data can never change after class is instantiated, BUT i can change data from constructor
            - Event : 
        
        Methods :
            - Constructor : when the new keyword is called
            - Property : 
            - Indexer : 
            - Operator : 
        */
        // Fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheWorld FavoriteWonder;
        public List<Person> Children = new List<Person>();
        public const string Species = "Homo Sapiens";
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
        /*
        private : Only inside the class is accesible
        internal : Only accesible inside the same assembly
        protected : Only accesible from any type that inherits
        public : member is accesible everywhere
        internal protected:
        private protected:
        */
        // Contructors
        public Person()
        {
            Name = "Unkown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        #region Methods
        public void WriteToConsole()
        {
            WriteLine($"{Name}, was born on  a {DateOfBirth:dddd}.");
        }

        // static method to multiply
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }

        // instance method to multiply
        public Person ProceateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        // overload * operator to use as procreate
        public static Person operator * (Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }
        #endregion

        #region Local Functions
            // Initial Method
            public static int Factorial(int number)
            {
                if( number < 0)
                {
                    throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
                }
                return localFactorial(number);
                int localFactorial (int localNumber) // local function
                {
                    if(localNumber < 1) return 1;
                    return localNumber * localFactorial(localNumber -  1);
                }
            }
        #endregion

        #region Delegates

        public int MethodICall(string input)
        {
            return input.Length;
        }

        public int MethodICall2(string input)
        {
            return input.Length;
        }

        public event EventHandler Shout;
        // field
        public int AngerLevel;
        // method
        public void Poke()
        {
            AngerLevel ++;
            if(AngerLevel >= 3)
            {
                if(Shout!= null)
                {
                    // then call the delegate
                    Shout(this, EventArgs.Empty);
                }
            }
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
        #endregion


        public void TimeTravel(DateTime when)
        {
            if (when <= DateOfBirth)
            {
                throw new PersonException("If you travel back in time time to a date earlier than your own birth, THE UNIVERSE WILL EXPLODE!!!");
            }
            else
            {
                WriteLine($"Welcome to {when:yyyy}");
            }
        }

        #region Override Methods
        public override string ToString()
        {
            return $"{Name} is a {base.ToString()}";
        }
        #endregion


    }
}

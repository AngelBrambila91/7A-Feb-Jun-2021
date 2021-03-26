using System;
using GeneralLibrary;
using static System.Console;
using System.Diagnostics;

namespace PeopleApp
{
    class Program
    {
        delegate int DelegateWithMatchSignature (string s);
        static void Main(string[] args)
        {
            #region POO Stuff
                
            var baltazar = new Person();
            baltazar.Name = "Baltazar";
            WriteLine(baltazar.ToString());

            var leo = new Person();
            leo.Name = "Leonardo";
            leo.DateOfBirth = new DateTime(1990, 12, 22);
            WriteLine($"{leo.Name} was born in {leo.DateOfBirth: d MMMM yyyy}");

            var layla = new Person
            {
                Name = "Layla",
                DateOfBirth = new DateTime(1980, 3, 7),
                FavoriteWonder = WondersOfTheWorld.ColossusOfRhodes
            };
            WriteLine($"{layla.Name} was born in {layla.DateOfBirth: d MMMM yyyy}");
            baltazar.FavoriteWonder = WondersOfTheWorld.HangingGardensOfBabylon;
            
            baltazar.Children.Add(new Person
            {Name = "Alfred"});
            baltazar.Children.Add(new Person
            {Name = "Sakura Kinomot Desu"});

            WriteLine($"{baltazar.Name} has {baltazar.Children.Count} children :");
            for (int child = 0; child < baltazar.Children.Count; child++)
            {
                WriteLine($"{baltazar.Children[child].Name}");
            }

            BankAccount.InterestRate = 0.012M;
            var leoAccount = new BankAccount();
            leoAccount.AccountName = "Mister Leo";
            leoAccount.Balance = 3400;
            WriteLine($"{leoAccount.AccountName} earned {leoAccount.Balance * BankAccount.InterestRate:C} interest");

            var laylaAccount = new BankAccount();
            laylaAccount.AccountName = "Miss Layla";
            laylaAccount.Balance = 3400;
            WriteLine($"{laylaAccount.AccountName} earned {laylaAccount.Balance * BankAccount.InterestRate:C} interest");

            var blankPerson = new Person();
            WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created {blankPerson.Instantiated}");

            var martian = new Person("Marvin", "Mars");
            WriteLine($"{martian.Name} of {martian.HomePlanet} was created {martian.Instantiated}");
            #endregion

            #region Procreate
                var ana = new Person { Name = "Ana" };
                var tiberio = new Person { Name = "Tiberio" };
                var vicente = new Person { Name = "Vicente" };
                // call instance method
                var baby1 = ana.ProceateWith(tiberio);
                baby1.Name = "NoPalindromo";
                // static call
                var baby2 = Person.Procreate(vicente, ana);

                // ussing overload operator
                var baby3  = ana * tiberio;
                WriteLine($"{ana.Name} has {ana.Children.Count} children");
                WriteLine($"{tiberio.Name} has {tiberio.Children.Count} children");
                WriteLine($"{vicente.Name} has {vicente.Children.Count} children");
                WriteLine($"{ana.Name}'s first child is named \"{ana.Children[0].Name}\".");


            #endregion

            #region TestLocal Functions
                WriteLine($"5! is {Person.Factorial(5)}");
            #endregion

            #region Delegates
            var p1 = new Person();
            int answer = p1.MethodICall("Something");
            WriteLine(answer);
            // create delegate instance
            var d = new DelegateWithMatchSignature(p1.MethodICall);
            // call delegate
            int asnwer2 = d("Amibas");
            WriteLine(asnwer2);

            var dali = new Person();
            dali.Name = "Dali";
            dali.Shout += Dali_Shout;
            dali.Shout += Oscar_Shout;
            dali.Shout += Tach_Shout;
            dali.Poke();
            dali.Poke();
            dali.Poke();
            dali.Poke();
            dali.Poke();                
            #endregion

            #region Interfaces
                
            Person [] people = 
            {
                new Person { Name = "Bañuelos"},
                new Person { Name = "Ruth"},
                new Person { Name = "Felix"},
                new Person { Name = "Angel"},
                new Person { Name = "Jaime"}
            };

            WriteLine("Initial order of peolple : ");
            foreach (var person in people)
            {
                WriteLine($" {person.Name}");
            }
            WriteLine("Use persons IComparable");
            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($" {person.Name}");
            }

            WriteLine("Use persons IComparer");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine($" {person.Name}");
            }
            #endregion

            #region Generics
                var t1 = new Thing();
                t1.Data = 42;
                WriteLine($"Thing with an integer : {t1.Process(42)}");
                var t2 = new Thing();
                t2.Data = "apple";
                WriteLine($"Thing with a string : {t2.Process("apple")}");


                var gt1 = new GenericThing<int>();
                gt1.Data = 42;
                WriteLine($"Thing with an integer : {t1.Process(42)}");
                var gt2 = new GenericThing<string>();
                gt2.Data = "apple";
                WriteLine($"Thing with a string : {t2.Process("apple")}");

                string number1 = "4";
                WriteLine($"{number1} squared is {Squarer.Square<string>(number1)}");
                byte number2 = 3;
                WriteLine($"{number2} squared is {Squarer.Square<byte>(number2)}");
            #endregion        
            
        }
        #region Using Delegates
        private static void Dali_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry : {p.AngerLevel}");
        }

        private static void Oscar_Shout(object sender, EventArgs e)
        {
            
        }

        private static void Tach_Shout(object sender, EventArgs e)
        {
            WriteLine("Hello Govnr");
        }
        #endregion
    }
}

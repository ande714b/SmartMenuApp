using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;
using FunctionLibrary;

namespace SmartMenuApp
{
    class Bindings : IBindings
    {
        public void Call(string menuID)
        {
            // Ud fra den menufunktion der bliver callet, switcher den imellem tilhørende ID og funktion
            switch (menuID)
            {
                case "DoThis":
                    Console.WriteLine(Functions.DoThis());
                    break;

                case "DoThat":
                    Console.WriteLine(Functions.DoThat());
                    break;

                // Modtager input fra brugeren som herefter printes. 
                case "DoSomething":
                    Console.WriteLine("Skriv noget DoSomething() skal gøre: ");
                    string doSomehing = Console.ReadLine();
                    Console.WriteLine(Functions.DoSomething(doSomehing));
                    break;

                case "GetTheAnswerToLifeTheUniverseAndEverything":
                    Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything().ToString());
                    break;


                default:
                    Console.WriteLine("Menuen eksisterer ikke...");
                    break;
            }
        }
    }
}

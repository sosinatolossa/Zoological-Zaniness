using System;
using System.Collections.Generic;

namespace Zoological_Zaniness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //we are creating/defining new objects here
            Pigeon pigeon = new Pigeon();
            Seagull seagull = new Seagull();

            // we are creating a list of new objects for birds and we're calling the list "birds"
            List<IFlying> birds = new List<IFlying>() { pigeon, seagull };

            //we're calling the methods Run() and Fly() on our class pigeon
            pigeon.Run();
            pigeon.Fly();

            // same thing with seagull
            seagull.Run();
            seagull.Fly();

            // we have a list so if want to loop through each bird in the list
            // we have to use foreach method 
            // specify a type. What type is the bird in our list? It is IFlying interface
            foreach (IFlying aBird in birds)
            {
                // now we use a dot method and call the method Fly() on each bird in our list
                aBird.Fly();
            }
        }
    }
}

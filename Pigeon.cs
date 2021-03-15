using System;

namespace Zoological_Zaniness
{
    //Pigeon wants to use the interface IFlying so it will spicify that 
    // by using colon and the interface class
    public class Pigeon : IFlying
    {
        public void Walk()
        {
            Console.WriteLine("Walk around");
        }

        public void Run()
        {
            Console.WriteLine("You can't catch me!");
        }

        // this is the method we defined in the IFlying interface class
        // so we will define the method here
        public void Fly()
        {
            // this console is the method we're defining
            Console.WriteLine("I'm in the air!");
        }
    }
}
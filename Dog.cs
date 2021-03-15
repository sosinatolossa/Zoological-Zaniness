using System;
using System.Collections.Generic;


namespace Zoological_Zaniness
{
    public class PaintedDog : IWalking
    {
        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }
    }
}
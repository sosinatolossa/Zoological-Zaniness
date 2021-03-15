using System;
using System.Collections.Generic;

namespace Zoological_Zaniness
{
    // we're using two interface classes here because we can do that in c#
    class SeaTurtle : IWalking, ISwimming
    {
        // this is the property we defined in the ISwimming interface
        public int MaximumDepth { get; } = 100;

        // this is the method we used in the IWalking interface
        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

        // this is the method we used in the IWalking interface also
        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }

        //this is a method we used in the interface
        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }
    }
}
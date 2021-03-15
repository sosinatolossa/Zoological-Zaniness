using System;
namespace Zoological_Zaniness
{
    public class Seagull : IFlying
    {
        public void Walk()
        {
            Console.WriteLine("Walk around Because I'm a seagull");
        }

        public void Run()
        {
            Console.WriteLine("You can't catch me! Because I'm a seagull");
        }

        public void Fly() => Console.WriteLine("I'm in the air! Because I'm a seagull");

        public int MaximumDepth { get; } = 10;

        public void Swim()
        {
            Console.WriteLine("Swim, Swim");
        }
    }
}
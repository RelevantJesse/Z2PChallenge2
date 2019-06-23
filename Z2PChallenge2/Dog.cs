using System;
using System.Collections.Generic;
using System.Text;

namespace Z2PChallenge2
{
    class Dog : IAnimal
    {
        public string Name { get; }

        public Dog(string name)
        {
            Name = name;
        }

        public void Bark()
        {
            Console.WriteLine("Woof woof");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"I'm a dog eating {food}");
        }
    }
}

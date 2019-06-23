using System;
using System.Collections.Generic;
using System.Text;

namespace Z2PChallenge2
{
    interface IAnimal
    {
        string Name { get; }
        void Eat(string food);
    }
}

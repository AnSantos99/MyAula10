using System;
using System.Collections.Generic;
using System.Text;

namespace Agents
{
    public class Player : Agent
    {
        public Player(string name) : base(name) { }
        public override char Move()
        {
            Console.Write("Direção:");
            return Console.ReadLine().ToUpper()[0];
        }

        public override string ToString() => base.ToString() + $"I'm a Player and my name is {Name}";
        
    }
}

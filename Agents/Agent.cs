using System;
using System.Collections.Generic;
using System.Text;

namespace Agents
{
    public abstract class Agent
    {
        // Readonly Property get Name
        public string Name { get; }

        // Abstract Method tho return random direction 
        public abstract char Move();

        // Contructor to get name
        public Agent(string name) { Name = name; }
    }
}

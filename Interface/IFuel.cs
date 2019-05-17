using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    // All of them are public and abstract
    // Ifuel = Interface Fuel
    interface IFuel
    {
        float Efficiency { get; }
        void Burn();
    }
}

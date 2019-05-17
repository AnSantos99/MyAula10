using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Hidrogen : IFuel
    {
        public float Efficiency => 12.3f;

        public void Burn()
        {
            Console.WriteLine("Its burning");
        }
    }
}

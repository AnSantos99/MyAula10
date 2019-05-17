using System;

namespace Agents
{
    class Program
    {
        static void Main(string[] args)
        { 
            Agent[] s = new Agent[] { new NPC("Maria"), new NPC("José"), new Player("mario") };                        

            foreach (Agent a in s)
            {
                Console.WriteLine(a + " and my movement is " + a.Move());
            }
        }
    }
}

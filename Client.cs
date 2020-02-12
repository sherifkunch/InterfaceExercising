using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercising
{
    class Client
    {
        static void Main(string[] args)
        {
            IHuman human;
            Theodore theodore1;

            human = new Theodore();
            //You need to do a cast operation when assigning the interface reference that points to an instance of Theodore to the Theodore reference variable 
            theodore1 = (Theodore)human;
            theodore1.Name = "Fred";
            theodore1.Speak("I like public implementations!");

            human.Name = "Teddy";
            human.Speak("I like C#!");
        }
    }
}

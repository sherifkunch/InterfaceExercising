using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercising
{
    public class Theodore : IHuman
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void Speak(string Message)
        {
            Console.WriteLine("Hi my name is {0}. \n" + Message, Name);
        }
    }
}

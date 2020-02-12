using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercising
{
    public class Kirk : IHuman
    {
        private string name;


        string IHuman.Name
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

        void IHuman.Speak(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}

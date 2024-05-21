using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIE_WPF.aniclasses
{
    class Fish : Animal
    {
        public Fish(string name, int age, string eyeColour, bool hasF)
        {
            animalName = name;
            animalAge = age;
            animalEyeColour = eyeColour;
            hasFur = hasF;
        }
        public override void animalSound()
        {
            Console.WriteLine("The flish says: glug glug");
        }

        public override int sleep(int x)
        {
            Console.WriteLine("Fish zzzzzz for " + x.ToString()
                + "Hours");
            return x;
        }

        public override double sleep(double x)
        {
            Console.WriteLine("Fish zzzzzz for " + x.ToString()
                + "Hours");
            return x;
        }
    }
}

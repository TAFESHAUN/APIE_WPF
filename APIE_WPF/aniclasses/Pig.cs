using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIE_WPF.aniclasses
{
    class Pig : Animal  // Derived class (child) 
    {
        //public bool hasCurl { get; set; }
        public Pig(string name, int age, string eyeColour, bool hasF)//, bool hasC)
        {
            animalName = name;
            animalAge = age;
            animalEyeColour = eyeColour;
            hasFur = hasF;
            //hasCurl = hasC;
        }
        public override void animalSound()
        {
            Console.WriteLine("The pig says: oink oink");
        }

        public override int sleep(int x)
        {
            Console.WriteLine("Pig zzzzzz for " + x.ToString()
                + "Hours");
            return x;
        }

        public override double sleep(double x)
        {
            Console.WriteLine("Pig zzzzzz for " + x.ToString()
                + "Hours");
            return x;
        }
    }
}

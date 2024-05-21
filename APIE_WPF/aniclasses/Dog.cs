using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIE_WPF.aniclasses
{
    class Dog : Animal  // Derived class (child) 
    {
        public Dog(string name, int age, string eyeColour, bool hasF)
        {
            animalName = name;
            animalAge = age;
            animalEyeColour = eyeColour;
            hasFur = hasF;
        }

        public int dogfood
        {
            get => default;
            set
            {
            }
        }

        public int coolcollar
        {
            get => default;
            set
            {
            }
        }

        public int dogwalkinglead
        {
            get => default;
            set
            {
            }
        }

        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }

        public override int sleep(int x)
        {
            Console.WriteLine("Dog zzzzzz for " + x.ToString()
                + "Hours");
            return x;
        }

        public override double sleep(double x)
        {
            Console.WriteLine("Dog zzzzzz for " + x.ToString()
                + "Hours");
            return x;
        }

        public void dogbarksatperson()
        {
            throw new NotImplementedException();
        }
    }
}

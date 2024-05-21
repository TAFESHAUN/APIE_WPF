using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIE_WPF.aniclasses
{
    public abstract class Animal  // Base class (parent) 
    {
        //Encapsulated by auto properties
        public string animalName { get; set; } = "default";
        public int animalAge { get; set; }
        public string animalEyeColour { get; set; } = "default";
        public bool hasFur { get; set; }

        public abstract void animalSound();

        //Overloaded and Override abstract methods
        public abstract int sleep(int x);
        public abstract double sleep(double x);
    }
}

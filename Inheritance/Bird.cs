using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class
    class Bird : Animal
    {
        public bool CanFly { get; set; }
        public bool HasFeathers { get; set; }
        public string Sound { get; set; }
        public string Habitat { get; set; }


        public Bird()
        {
        }

        public Bird(bool canFly, bool hasFeathers, string sound, string habitat, string name, string color, int age, int legs)
        {
            CanFly = canFly;
            HasFeathers = hasFeathers;
            Sound = sound;
            Habitat = habitat;
            Name = name;
            Age = age;
            Color = color;
            Legs = legs;
         }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class

    class Reptile : Animal
    {
        public bool IsWarmBlooded { get; set; }
        public bool HasBackbone { get; set; }
        public bool IsPoisonous { get; set; }
        public bool LiveBearing { get; set; }

        public Reptile()
        {
        }

        public Reptile(bool isWarmBlooded, bool hasBackbone, bool isPoisonous, bool liveBearing, string name, string color, int age, int legs)
        {
            IsWarmBlooded = isWarmBlooded;
            HasBackbone = hasBackbone;
            IsPoisonous = isPoisonous;
            LiveBearing = liveBearing;
            Name = name;
            Age = age;
            Color = color;
            Legs = legs;
        }
    }
}

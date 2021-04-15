using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
     public class Wolf : Animals
    {

        public Wolf(string type = "Wolf", string name = "No name", string WhatEat = "anything ", uint speed = 0, uint TimeSleeping = 0) : base(type, name, WhatEat, speed, TimeSleeping)
        {

        }

        public void Eat()
        { Console.WriteLine($"\nThis {type} {name} eat {WhatEat} "); }
        public void Sleep()
        {
            if (TimeSleeping > 0)

                Console.WriteLine($"\nThis {type} {name} is sleeping {TimeSleeping} already");
            else
                Console.WriteLine($"\nThis {type} {name} isn't sleeping now ");
        }
        public void Walk()
        {
            if (speed > 0)

                Console.WriteLine($"\nThis {type} {name} is walking with speed {speed} ");
            else
                Console.WriteLine($"\nThis {type} {name} isn't walking now ");
        }



        public override string ToString() => $"Animal: {type}\nName: {name}\nWhat Eat: {WhatEat}";
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using static Zoo.Interface1;

namespace Zoo
{
    abstract public class Animals : IWalk, IEat, ISleep
    {
        public string name;
        public string type;
        public Animals(string type = "No type", string name = "No name", string WhatEat = "anything ", uint speed =0, uint TimeSleeping=0)
        {
            this.type = type;
            this.name = name;
            this.WhatEat = WhatEat;
            this.speed = speed;
            this.TimeSleeping = TimeSleeping;

        }

        public uint speed { get; set; }
        public string WhatEat { get; set; }
        public uint TimeSleeping { get; set; }

        public void Eat() { }
        public void Sleep() {}
        public void Walk() { }

        public void Watch()
        {
            
        }
    }
}

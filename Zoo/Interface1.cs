using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    interface Interface1
    {
        interface IWalk
        {
            void Walk();
            public uint speed { get; set; }
        }
        interface IEat
        {
            void Eat();
            string WhatEat { get; set; }
        }

        interface ISleep
        {
            void Sleep();
            uint TimeSleeping { get; set; }
        }

        interface IWatch
        {
            void Watch(ZooWorker worker, Animals animals);
        }


    }
}

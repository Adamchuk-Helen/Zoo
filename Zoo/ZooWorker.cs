using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class ZooWorker
    {
       public string name;
       public  ZooWorker(string name)
        {
        this.name = name;
        
        }

        public void Worker_Must_Doing(Animals animal)
        {
            Console.WriteLine($"\nWorker {name} must give to eat to {animal.type} {animal.name} {animal.WhatEat}");
        }

 

        public override string ToString() => $"Worker {name} ";
       
    }
}

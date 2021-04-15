using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Wolf wolf1 = new Wolf( name:"Grey");
            Fox fox1 = new Fox(name:"Red", TimeSleeping: 8, WhatEat: "meat");
            Fox fox2 = new Fox(name: "Masya", TimeSleeping: 7, speed: 50, WhatEat: "fish");
            List<Animals> animals = new List<Animals>
            { fox1, wolf1, fox2};

            foreach (var item in animals)
            {
                Console.WriteLine("\n\n-----------Animal--------------");
                Console.WriteLine(item);
            }

            fox1.Walk();
            fox2.Walk();
            wolf1.Walk();
            fox1.Sleep();
            fox2.Sleep();
            wolf1.Sleep();



            ZooWorker worker1 = new ZooWorker("Ivan");
            ZooWorker worker2 = new ZooWorker("Sasha");

            List<ZooWorker> workers = new List<ZooWorker>
            { worker1, worker2};

            foreach (var item in workers)
            {
                Console.WriteLine("\n\n-----------Zoo worker--------------");
                Console.WriteLine(item);
            }


            worker1.Worker_Must_Doing(fox1);
            worker1.Worker_Must_Doing(wolf1);
            worker2.Worker_Must_Doing(fox2);

            VideoCamera camera1 = new VideoCamera();
            VideoCamera camera2 = new VideoCamera();

            camera1.Watch(worker1, wolf1);
            camera2.Watch(worker2, fox2);

        }
    }
}

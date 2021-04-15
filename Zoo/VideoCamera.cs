using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class VideoCamera: Interface1.IWatch
    {
        public VideoCamera()
        {
           
        }


        public void Watch(ZooWorker worker, Animals animals)
        {
            Console.WriteLine($"\nThe worker {worker.name} looking for {animals.type} {animals.name}");
        }
    }
}

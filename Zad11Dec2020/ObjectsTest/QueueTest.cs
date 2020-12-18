using System;
using Zad11Dec2020.Objects;

namespace Zad11Dec2020.ObjectsTest
{
    
    public static class QueueTest
    {
        
        public static void Test()
        {
            Console.WriteLine("******************");
            Console.WriteLine("| Testing queue. |");
            Console.WriteLine("*******************");

            Queue queue = new Queue();
            queue.Enqueue(1);
            // Treba ispisati 1.
            Console.WriteLine(queue.Dequeue());
            // Treba ispisati da je red prazan.
            Console.WriteLine(queue.Dequeue());

            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            // Treba ispisati: 2, 3, 4, 5.
            queue.Print();

            // Treba ispisati 2,
            Console.WriteLine(queue.Dequeue());

            // Treba ispisati da su tri elementa.
            Console.WriteLine("Queue has " + queue.Size() + " elements.");

            // Treba ispisati 3, 4, 5
            queue.Print();
            
            Console.WriteLine("Next element is: " + queue.Front());
            
            Console.WriteLine("******************");
            Console.WriteLine("| Testing ended. |");
            Console.WriteLine("******************");
        }
        
    }
    
}
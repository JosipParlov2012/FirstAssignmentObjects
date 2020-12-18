using System;
using Zad11Dec2020.Objects;

namespace Zad11Dec2020.ObjectsTest
{
    
    public static class LinkedListTest
    {
        
        public static void Test()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("| Testing LinkedList. |");
            Console.WriteLine("***********************");

            LinkedList list = new LinkedList();
            
            list.Add(1);
            list.Add(2);
            list.Print();
            
            list.AddAt(3, 1);
            list.Print();
            list.AddAt(4, 4);
            list.AddAt(4, 3);
            list.Print();
            
            Console.WriteLine("LinkedList has " + list.Size() + " elements.");

            list.MoveFirst();
            list.Remove();
            list.Print();
            list.RemoveAt(1);
            list.Print();

            // Point at end.
            list.MoveLast();
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Print();
            
            list.MoveTo(4);
            Console.WriteLine("Now pointing to: " + list.GetCurrent());
            
            Console.WriteLine("******************");
            Console.WriteLine("| Testing ended. |");
            Console.WriteLine("******************");
        }
        
    }
    
}
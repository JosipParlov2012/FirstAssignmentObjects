using System;
using Zad11Dec2020.Objects;

namespace Zad11Dec2020.ObjectsTest
{
    
    public static class StackTest
    {
        
        public static void Test()
        {
            Console.WriteLine("******************");
            Console.WriteLine("| Testing Stack. |");
            Console.WriteLine("******************");

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            // Treba ispisati: 4, 3, 2, 1
            stack.Print();

            stack.Pop();
            // Treba ispisati 3
            Console.WriteLine("On top: " + stack.Peek());
            
            stack.Pop();
            // Treba ispisati: 2, 1
            stack.Print();
            
            stack.Pop();
            stack.Pop();
            // Treba ispisati: Stog je prazan.
            stack.Pop();
            
            Console.WriteLine("******************");
            Console.WriteLine("| Testing ended. |");
            Console.WriteLine("******************");
        }
        
    }
    
}
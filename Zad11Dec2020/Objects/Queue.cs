using System;
/* 
 * conserve - reserves
 */

namespace Zad11Dec2020.Objects
{
    
    public class Queue
    {

        private static string PREFIX = "[Queue]";
        private static bool DEBUG = true;
        private static int SIZE = 100;
        
        private readonly int[] _elements = new int[SIZE];
        private int _pointer = -1;

        public Queue()
        {
            if (DEBUG) Log("Object created.");
        }

        public int Size() => _pointer + 1;

        public bool IsEmpty() => _pointer < 0;

        private void Log(string line)
        {
            Console.WriteLine(PREFIX + " " + line);
        }

        public void Print()
        {
            if (IsEmpty())
            {
                if (DEBUG) Log("Queue empty. Did not print.");
                return;
            }

            string elementString = "";
            for (int i = 0; i < Size(); i++)
            {
                elementString += _elements[i];
                if (i < Size() - 1) elementString += ", ";
            }
            Log("Elements: " + elementString + ".");
        }
        
        public bool Enqueue(int item)
        {
            if (_pointer >= SIZE)
            {
                if (DEBUG) Log("Stackoverflow. Did not enqueue.");
                return false;
            }
            
            _elements[++_pointer] = item;
            if (DEBUG) Log("Element added: " + item);
            return true;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                if (DEBUG) Log("Queue empty. Did not dequeue.");
                return -1;
            }

            int result = _elements[0];
            for (int i = 0; i < Size(); i++)
            {
                _elements[i] = _elements[i + 1];
            }
            _pointer--;
            if (DEBUG) Log("Dequeued element: " + result);
            return result;
        }

        public int Front()
        {
            if (IsEmpty())
            {
                if (DEBUG) Log("Queue empty. Did not fetch.");
                return -1;
            }

            return _elements[0];
        }
        
    }
    
}
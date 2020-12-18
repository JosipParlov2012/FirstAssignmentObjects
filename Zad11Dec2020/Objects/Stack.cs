using System;

namespace Zad11Dec2020.Objects
{
    
    class Stack
    {

        private static string PREFIX = "[Stack]";
        private static bool DEBUG = true;
        private static int SIZE = 100;
        
        private readonly int[] _elements = new int[SIZE];
        private int _pointer = -1;

        public Stack()
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
                if (DEBUG) Log("Stack empty. Did not print.");
                return;
            }

            string elementString = "";
            for (int i = _pointer; i >= 0; i--)
            {
                elementString += _elements[i];
                if (i > 0) elementString += ", ";
            }
            Log("Elements: " + elementString + ".");
        }

        public bool Push(int item)
        {
            if (_pointer >= SIZE)
            {
                if (DEBUG) Log("Stackoverflow. Did not push.");
                return false;
            }
            
            _elements[++_pointer] = item;
            if (DEBUG) Log("Element added: " + item);
            return true;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                if (DEBUG) Log("Stack empty. Did not pop.");
                return -1;
            }

            int result = _elements[_pointer--];
            if (DEBUG) Log("Popped element: " + result);
            return result;
        }

        internal int Peek()
        {
            if (IsEmpty())
            {
                if (DEBUG) Log("Stack empty. Did not peek.");
                return -1;
            }

            return _elements[_pointer];
        }
        
    }

}

using System;

namespace Zad11Dec2020.Objects
{
    
    public class LinkedList
    {
        private static string PREFIX = "[LinkedList]";
        private static bool DEBUG = true;
        private static int SIZE = 100;
        
        private int[] _elements = new int[SIZE];
        private int _pointer = -1;
        private int _size;

        public LinkedList()
        {
            if (DEBUG) Log("Object created.");
        }

        public int Size() => _size;
        
        public bool IsEmpty() => Size() == 0;

        private static void Log(string line)
        {
            Console.WriteLine(PREFIX + " " + line);
        }

        public void Print()
        {
            if (IsEmpty())
            {
                if (DEBUG) Log("LinkedList empty. Did not print.");
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

        public bool MoveTo(int index)
        {
            if (index > Size())
            {
                if (DEBUG) Log("Stack overflow. Did not fetch.");
                return false;
            }
            
            if (index < 0)
            {
                if (DEBUG) Log("Stack underflow. Did not fetch.");
                return false;
            }
            
            _pointer = index;
            if (DEBUG) Log("Moved pointer to: " + _pointer);
            return true;
        }

        public void MoveFirst() => MoveTo(0);
        public void MoveLast() => MoveTo(Size() - 1);

        public int GetAt(int index)
        {
            if (index > Size())
            {
                if (DEBUG) Log("Stack overflow. Did not fetch.");
                return -1;
            }
            
            if (index < 0)
            {
                if (DEBUG) Log("Stack underflow. Did not fetch.");
                return -1;
            }

            return _elements[index];
        }

        public int GetCurrent() => GetAt(_pointer);
        public int GetFirst() => GetAt(0);
        public int GetLast() => GetAt(Size() - 1);

        public bool AddAt(int value, int index)
        {
            if (index > Size() || index >= SIZE)
            {
                if (DEBUG) Log("Stack overflow. Did not add.");
                return false;
            }
            
            if (index < 0)
            {
                if (DEBUG) Log("Stack underflow. Did not add.");
                return false;
            }
            
            int[] newElements = new int[Size() + 1];
            for (int i = 0; i < index; i++)
            {
                newElements[i] = _elements[i];
            }
            newElements[index] = value;
            for (int i = index; i < Size(); i++)
            {
                newElements[i + 1] = _elements[i];
            }
            
            _elements = newElements;
            _size++;
            if (DEBUG) Log("Added " + value + " at index " + index + ".");
            return true;
        }

        public bool Add(int item) => AddAt(item, ++_pointer);
        public bool AddFirst(int item) => AddAt(item, 0);
        public bool AddLast(int item) => AddAt(item, Size() - 1);

        public bool RemoveAt(int index)
        {
            if (index > Size())
            {
                if (DEBUG) Log("Stack overflow. Did not remove.");
                return false;
            }
            
            if (index < 0)
            {
                if (DEBUG) Log("Stack underflow. Did not remove.");
                return false;
            }

            if (index == _pointer) _pointer--;
            _size--;
            int result = _elements[index];
            Array.Copy(_elements, index + 1, _elements, index, _size - index);
            if (DEBUG) Log("Removed " + result + " at index " + index + ".");
            return true;
        }

        public bool Remove() => RemoveAt(_pointer);
        public bool RemoveFirst() => RemoveAt(0);
        public bool RemoveLast() => RemoveAt(Size() - 1);

    }

}
using System;
using System.Collections.Generic;
using System.Linq;


namespace DataStructure.Lib.Stack
{
    public class StackOnList<T> : ICloneable
    {
        private List<T> _items = new List<T>();

        public int Count => _items.Count;

        public bool IsEmpty => _items.Count == 0;

        public void Clear()
        {
            _items.Clear();
        }

        public void Push(T item)
        {
            _items.Add(item);
        }

        public T Pop()
        {
            if(Count > 0)
            {
                _items.Remove(_items.LastOrDefault());
                return _items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek() 
        {
            if (Count > 0)
            {
                return _items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public object Clone()
        {
            var newStack = new StackOnList<T>();
            newStack._items = new List<T>(_items);
            return newStack;
        }
    }
}

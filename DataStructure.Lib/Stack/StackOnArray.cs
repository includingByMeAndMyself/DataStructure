using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Lib.Stack
{
    public class StackOnArray<T>
    {
        private T[] _items;
        private int _current = 0;
        private int _size = 10;

        public int Count => _items.Length;

        public StackOnArray()
        {
            _items = new T[_size];
        }

        public StackOnArray(T data, int size = 10)
        {
            _items[_current] = data;
            _size = size;
        }

        public void Push(T data)
        {
            if(_current < _size)
            {
                _items[_current] = data;
                _current++;
            }
            else
            {
                throw new StackOverflowException("Stack is overflow");
            }
        }
    }
}

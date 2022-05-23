using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Lib.Stack
{
    public class LinkedStack<T>
    {  
        public Item<T> Head { get; set; }

        public int Count { get; set; }

        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }

        public LinkedStack(T data)
        {
            Head = new Item<T>(data);
            Count++;
        }

        public void Push(T data)
        {
            var item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }

        public T Pop()
        {

            if (Count > 0)
            {
                var item = Head;
                Head = Head?.Previous;
                Count--;
                return item.Data; 
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public T Peek()
        {
            if(Count > 0)
            {
                return Head.Data;
            }
            else
            {
                throw new NullReferenceException("Stack is empty"); 
            }
        }
    }
}

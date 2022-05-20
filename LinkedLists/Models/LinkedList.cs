using System.Collections;
using System.Collections.Generic;


namespace LinkedLists.Models
{
    public class LinkedList<T> : IEnumerable
    { 
        public Item<T> Head { get; private set; }
       
        public Item<T> Tail { get; private set; }

        public int Count { get; private set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public LinkedList(T data)
        {
            var item = new Item<T>(data);
            SetHeadAndTail(item);
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);
            
            if(Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(item);
            }
        }

        public void Delete(T data)
        {
            if(Head != null)
            {
                if (Head.Date.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while(current.Next != null)
                {
                    if (current.Date.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
        }

        private void SetHeadAndTail(Item<T> item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public int GetCount()
        {
            return Count;
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Date;
                current = current.Next;
            }
        }
    }
}

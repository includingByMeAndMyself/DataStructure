using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Lib.Lists
{
    public class CircularLinkedList<T>
    {
        public DuplexItem<T> Head { get; set; }

        public int Count { get; set; }

        public CircularLinkedList()
        {

        }

        public CircularLinkedList(T data)
        {
            SetDupluxItem(data);
        }

        public void SetDupluxItem(T data)
        {
            Head = new DuplexItem<T>(data);
            Head.Next = Head;
            Head.Previous = Head;
            Count++;
        }

        public void Add(T data)
        {
            if (Count == 0)
            {
                SetDupluxItem(data);
                return;
            }
            var item = new DuplexItem<T>(data);
            item.Next = Head;
            item.Previous = Head.Previous;
            Head.Previous.Next = item;
            Head.Previous = item;
            Count++;
        }

        public void Delete(T data) 
        {
            if (Head.Data.Equals(data))
            {
                Head.Next.Previous = Head.Previous;
                Head.Previous.Next = Head.Next;
                Count--;
                Head = Head.Next;
                return;
            }

            var current = Head.Next;
            for (int i = Count; i >= 0; i--)
            {
                if (current != null && current.Data.Equals(data)) 
                { 
                    current.Next.Previous = current.Previous;
                    current.Previous.Next = current.Next;
                    Count--;
                }
                current = current.Next;
            }
        }
    }
}

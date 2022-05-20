using System;


namespace LinkedLists.Models
{
    public class Item<T> 
    {
        private T _data = default(T);

        public T Date 
        {
            get => _data;
            set 
            {
                if(value != null)
                {
                    _data = value;
                }
                else
                {
                    throw new ArgumentNullException(nameof(value));
                }
            }
        }

        public Item<T> Next{ get; set; }

        public Item(T data)
        {
            _data = data;
        }

        public override string ToString()
        {
            return Date.ToString();
        }
    }
}

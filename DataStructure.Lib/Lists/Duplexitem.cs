
namespace DataStructure.Lib.Lists
{
    public class Duplexitem <T>
    {
        public T Data { get; set; }

        public Duplexitem<T> Previous { get; set; }

        public Duplexitem<T> Next { get; set; }

        public Duplexitem(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

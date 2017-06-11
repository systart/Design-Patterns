namespace TasarimDesenleri.GoFPatterns.StructuralClasses.BridgeExample
{
    public class StackArray
    {
        private int[] _items;
        private int _size = -1;

        public StackArray()
        {
            _items = new int[12];
        }

        public StackArray(int cells)
        {
            _items = new int[cells];
        }

        public virtual void Push(int i)
        {
            if (!isFull())
            {
                _items[++_size] = i;
            }
        }

        public bool IsEmpty()
        {
            return _size == -1;
        }

        public bool isFull()
        {
            return _size == _items.Length - 1;
        }

        public int Top()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return _items[_size];
        }

        public virtual int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return _items[_size--];
        }
    }
}

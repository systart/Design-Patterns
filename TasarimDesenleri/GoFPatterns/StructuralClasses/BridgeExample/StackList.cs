namespace TasarimDesenleri.GoFPatterns.StructuralClasses.BridgeExample
{
    public class StackList
    {
        private Node _last;
        public void Push(int i)
        {
            if (_last == null)
                _last = new Node(i);
            else
            {
                _last.next = new Node(i);
                _last.next.prev = _last;
                _last = _last.next;
            }
        }
        public bool IsEmpty()
        {
            return _last == null;
        }
        public bool IsFull()
        {
            return false;
        }
        public int Top()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return _last.value;
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            int ret = _last.value;
            _last = _last.prev;
            return ret;
        }
    }
}

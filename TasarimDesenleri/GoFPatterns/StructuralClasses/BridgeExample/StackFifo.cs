namespace TasarimDesenleri.GoFPatterns.StructuralClasses.BridgeExample
{
    public class StackFifo : StackArray
    {
        private StackArray _stackArray = new StackArray();
        public override int Pop()
        {
            while (!IsEmpty())
            {
                _stackArray.Push(base.Pop());
            }
            int ret = _stackArray.Pop();
            while (!_stackArray.IsEmpty())
            {
                Push(_stackArray.Pop());
            }
            return ret;
        }
    }
}

namespace TasarimDesenleri.GoFPatterns.StructuralClasses.BridgeExample
{
    public class StackHanoi : StackArray
    {
        private int _totalRejected = 0;
        public int reportRejected()
        {
            return _totalRejected;
        }
        public override void Push(int value)
        {
            if (!IsEmpty() && value > Top()) {
                _totalRejected++;
            } else {
                base.Push(value);
            }
        }
    }
}

namespace TasarimDesenleri.GoFPatterns.StructuralClasses.FacadeExample
{
    public class PointCartesian
    {
        private double _x, _y;
        public PointCartesian(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public void Move(int x, int y)
        {
            _x += x;
            _y += y;
        }

        public override string ToString()
        {
            return "(" + _x + " - " + _y + ")";
        }

        public double GetX()
        {
            return _x;
        }

        public double GetY()
        {
            return _y;
        }
    }
}

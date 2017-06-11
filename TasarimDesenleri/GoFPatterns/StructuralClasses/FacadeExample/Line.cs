namespace TasarimDesenleri.GoFPatterns.StructuralClasses.FacadeExample
{
    public class Line
    {
        private Point _o, _e;
        public Line(Point ori, Point end)
        {
            _o = ori;
            _e = end;
        }

        public void Move(int x, int y)
        {
            _o.Move(x, y);
            _e.Move(x, y);
        }

        public void Rotate(int angle)
        {
            _e.Rotate(angle, _o);
        }

        public override string ToString()
        {
            return "origin is " + _o + ", end is " + _e;
        }
    }
}

namespace TasarimDesenleri.GoFPatterns.StructuralClasses.FacadeExample
{
    public class PointPolar
    {
        private double _radius, _angle;

        public PointPolar(double radius, double angle)
        {
            _radius = radius;
            _angle = angle;
        }

        public void Rotate(int angle)
        {
            _angle += angle % 360;
        }

        public override string ToString()
        {
            return "[" + _radius + "@" + _angle + "]";
        }
    }
}

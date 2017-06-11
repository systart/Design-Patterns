using System;

namespace TasarimDesenleri.GoFPatterns.StructuralClasses.FacadeExample
{
    public class Point
    {
        private PointCartesian _pointCartesian;

        public Point(double x, double y)
        {
            _pointCartesian = new PointCartesian(x, y);
        }

        public override string ToString()
        {
            return _pointCartesian.ToString();
        }

        // 4. Wrapper maps
        public void Move(int x, int y)
        {
            _pointCartesian.Move(x, y);
        }

        public void Rotate(int angle, Point o)
        {
            double x = _pointCartesian.GetX() - o._pointCartesian.GetX();
            double y = _pointCartesian.GetY() - o._pointCartesian.GetY();
            PointPolar pointPolar = new PointPolar(Math.Sqrt(x * x + y * y), Math.Atan2(y, x) * 180 / Math.PI);
            // 4. Wrapper maps
            pointPolar.Rotate(angle);
            Console.WriteLine("  PointPolar is " + pointPolar);
            string str = pointPolar.ToString();
            int i = str.IndexOf('@');
            double r = Double.Parse(str.Substring(1, i-1));
            double a = Double.Parse(str.Substring(i + 1, str.Length - (i+2)));
            _pointCartesian = new PointCartesian(r * Math.Cos(a * Math.PI / 180) + o._pointCartesian.GetX(),
                r * Math.Sin(a * Math.PI / 180) + o._pointCartesian.GetY());
        }
    }
}

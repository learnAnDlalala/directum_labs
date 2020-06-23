namespace Figures
{
    using System;
    public class Circle : Shape
    {
        internal double Radius;
        public Circle(double x, double y, double radius)
            : base(x, y)

        {
            this.Radius = radius;
        }
        public double Length()
        {
            return 2 * Math.PI * this.Radius;
        }
        public override double Area()
        {
            return 0;
        }
    }
    public class Round : Circle
    {
        public Round(double x, double y, double radius)
        : base(x, y, radius)
        { }
        public override double Area()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
    public class Ring : Round
    {
        internal double Thickness;
        public Ring(double x, double y, double radius, double thickness)
            : base(x, y, radius)
        {
            this.Thickness = thickness;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(this.Radius, 2) - Math.PI * Math.Pow(this.Thickness, 2);
        }

    }
}

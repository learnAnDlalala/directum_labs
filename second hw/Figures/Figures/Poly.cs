namespace Figures
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Square : Shape
    {
        public double SideA;

        public Square(double x, double y, double side)
            : base(x, y)
        {
            this.SideA = side;

        }
        public virtual double Perimetr()
        {
            return 4 * this.SideA;
        }
        public override double Area()
        {
            return Math.Pow(this.SideA, 2);
        }
    }

    public class Rectangle : Square
    {
        public double SideB;
        public Rectangle(double x, double y, double side, double side2)
            : base(x, y, side)
        {
            this.SideB = side2;
        }
        public override double Perimetr()
        {
            return 2 * (this.SideA + this.SideB);
        }
        public override double Area()
        {
            return this.SideA * this.SideB;
        }
    }
    public class Triangle : Rectangle
    {
        public double SideC;
        public Triangle(double x, double y, double side, double side2, double side3)
            : base(x, y, side, side2)
        {
            this.SideC = side3;
        }
        public override double Perimetr()
        {
            return this.SideA + this.SideB + this.SideC;
        }
        public override double Area()
        {
            double halfPerimetr = this.Perimetr() / 2;
            return Math.Sqrt(halfPerimetr * (halfPerimetr - this.SideA) * (halfPerimetr - this.SideB) * (halfPerimetr - this.SideC));
        }
    }
}

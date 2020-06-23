namespace Figures
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public abstract class Shape
    {
        private double centerX;
        private double centerY;
        public Shape(double x, double y)
        {
            this.centerX = x;
            this.centerY = y;
        }
        public abstract double Area () ;
    }
}

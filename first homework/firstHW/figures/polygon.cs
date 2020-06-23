using System;

// Название файла с большой буквы и вынести классы в отдельные файлы.

namespace figures
{
    /// <summary>
    /// Class Square 
    /// </summary>
    public class Square : Shape
    {
        /// <summary>
        /// Value of all sides of square
        /// </summary>
        private double sideA;

        /// <summary>
        /// Get of Set value of side;
        /// </summary>
        public double SideA
        {
            get => this.sideA;
            set => this.sideA = value;
        }

        /// <summary>
        /// Area of square
        /// </summary>
        /// <returns>Area double</returns>
        public override double Area()
        {
            return Math.Pow(this.sideA, 2);
        }

        /// <summary>
        /// Summ of all sides;
        /// </summary>
        /// <returns>Perimetr double</returns>
        public virtual double Perimetr()
        {
            return 4 * this.sideA;
        }


        public Square(double _x, double _y, double _a)  // Откуда такая любовь к подчёркиваниям. Лучше обойтись без этого.
            : base(_x, _y)
        {
            this.sideA = _a;
        }
    }

    /// <summary>
    /// Rectangle
    /// </summary>
    public class Rectangle : Square // Почему прямоугольник наследник квадрата, ведь квадрат - частный случай прямоугольника.
    {
        /// <summary>
        /// Second side of rectangle
        /// </summary>
        private double sideB;

        /// <summary>
        /// Get or Set value of 2nd side;
        /// </summary>
        public double SideB
        {
            get => this.sideB;
            set => this.sideB = value;
        }

        /// <summary>
        /// Area of rectangle
        /// </summary>
        /// <returns>Area double</returns>
        public override double Area()
        {
            return this.SideA * this.sideB;
        }

        public override double Perimetr()
        {
            return 2 * (this.SideA * this.sideB);
        }

        public Rectangle(double _x, double _y, double _a, double _b)
            : base(_x, _y, _a)

        {
            this.sideB = _b;
        }
    }

    /// <summary>
    /// class Triangle
    /// </summary>
    public class Triangle : Rectangle // Треугольник наследуется от прямоугольника? Как это?
    {
        /// <summary>
        /// 3d side
        /// </summary>
        private double sideC;

        /// <summary>
        /// Get or Set value 3d side
        /// </summary>
        public double SideC
        {
            get => this.sideC;
            set => this.sideC = value;
        }

        /// <summary>
        /// Area calculated with half perimetr = p;
        /// </summary>
        /// <returns>Area double</returns>
        public override double Area()
        {
            var p = Perimetr();
            return Math.Sqrt(p * (p - this.SideA) * (p - this.SideB) * (p - sideC));
        }

        /// <summary>
        /// Sum of all sides;
        /// </summary>
        /// <returns>Perimetr double</returns>
        public override double Perimetr()
        {
            return this.SideA + this.SideB + this.sideC;
        }

        public Triangle(double _x, double _y, double _a, double _b, double _c)
            : base(_x, _y, _a, _b)
        {
            this.sideC = _c;
        }
    }
}
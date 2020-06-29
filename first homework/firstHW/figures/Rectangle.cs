namespace Figures
{
    /// <summary>
    /// Rectangle class
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Constructor rectangle
        /// </summary>
        /// <param name="x">coordinate x int</param>
        /// <param name="y">coordinate y int</param>
        /// <param name="a">1st side double</param>
        /// <param name="b">2nd side double</param>
        public Rectangle(int x, int y, double a, double b)
            : base(x, y)
        {
            this.SideA = a;
            this.SideB = b;
        }

        /// <summary>
        /// 1st side of Rectangle
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// 2nd side of Rectangle
        /// </summary>
        public double SideB { get; set; }

        /// <summary>
        /// Area of rectangle
        /// </summary>
        /// <returns>Area double</returns>
        public override double GetArea()
        {
            return this.SideA * this.SideB;
        }

        /// <summary>
        /// Return Sum of all sides
        /// </summary>
        /// <returns>Perimetr double</returns>
        public virtual double GetPerimetr()
        {
            return 2 * (this.SideA * this.SideB);
        }
    }
}

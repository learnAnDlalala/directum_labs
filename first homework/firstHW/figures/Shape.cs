namespace Figures
{
    using System.Drawing;
    /// <summary>
    /// Shape class is a parent class for all figures
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Center is a coordinate;
        /// </summary>
        private Point center;

        /// <summary>
        /// Sets coordinates of center figure;
        /// </summary>
        public Point CenterCoordinate
        {
            get => this.center;
        }

        /// <summary>
        /// Get Area
        /// </summary>
        /// <returns>Area type double</returns>
        public abstract double GetArea();


        /// <summary>
        /// Shape constructor
        /// </summary>
        /// <param name="x">coordinate x int</param>
        /// <param name="y">coordinate y int</param>
        public Shape(int x, int y)
        {
            this.center = new Point(x, y);
        }
    }
}
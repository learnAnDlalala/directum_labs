namespace figures
{
    /// <summary>
    /// Shape class is a parent class for all figures
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Center is a coordinate;
        /// </summary>
        private double[,] center;

        /// <summary>
        /// Area will change with a type of figure;
        /// </summary>
        private double area;

        /// <summary>
        /// Sets coordinates of center figure;
        /// </summary>
        public double CenterCoordinate
        {
            get => this.center[0, 0];
        }

        /// <summary>
        /// Get Area
        /// </summary>
        /// <returns>Area type double</returns>
        public virtual double Area()
        {
            return this.area;
        }

        public Shape(double _x, double _y)
        {
            this.center = new double[1, 2] {{_x, _y}};
        }
    }
}
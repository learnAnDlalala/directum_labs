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
        private double[,] center; // Почему здесь используется двумерный массив?

        /// <summary>
        /// Area will change with a type of figure;
        /// </summary>
        private double area;  // Где вычисляется это поле?

        /// <summary>
        /// Sets coordinates of center figure;
        /// </summary>
        public double CenterCoordinate  // Получается что координаты центра это одно число.
        {
            get => this.center[0, 0];
        }

        /// <summary>
        /// Get Area
        /// </summary>
        /// <returns>Area type double</returns>
        public virtual double Area()  // Лучше убрать реализацию и сделать абстрактным.
                                      // +Название метода должно передавать какое-то действие(содержать глагол). У нас может быть свойство Area, либо метод GetArea().
        {
            return this.area;
        }

        public Shape(double _x, double _y)
        {
            this.center = new double[1, 2] {{_x, _y}};  // Почему воздаётся массив 1 на 2?
        }
    }
}
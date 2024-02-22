namespace CalculateSquareForShapes
{
    /// <summary>
    /// Интерфейс для треугольника
    /// </summary>
    public interface ITriangle : IShape
    {
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <returns>Является ли треугольник прямоугольным</returns>
        public bool GetIsRightTriangle();
    }
}
namespace CalculateSquareForShapes
{
    /// <summary>
    /// Интерфейс для фигур
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Получение площади фигуры
        /// </summary>
        /// <returns>Площадь</returns>
        public abstract double GetSquare();
    }
}
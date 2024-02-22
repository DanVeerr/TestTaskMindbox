namespace CalculateSquareForShapes
{
    /// <summary>
    /// Абстрактный класс фигуры
    /// </summary>
    public abstract class Shape : IShape
    {
        ///<inheritdoc/>
        public abstract double GetSquare();
    }
}
namespace CalculateSquareForShapes
{
    public class Circle : Shape
    {
        private double Radius { init; get; }
        private double? Square { set; get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        ///<inheritdoc/>
        public override double GetSquare()
        {
            if (Radius < 0) throw new InvalidOperationException();

            if (!Square.HasValue) Square = Math.Pow(Radius, 2) * Math.PI;

            return Square.Value;
        }
    }
}
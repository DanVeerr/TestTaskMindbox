namespace CalculateSquareForShapes
{
    public class Triangle : Shape, ITriangle
    {
        public double FirstSide { init; get; }
        public double SecondSide { init; get; }
        public double ThirdSide { init; get; }
        private double? Square { set; get; }
        private bool? IsRightTriangle { set; get; }


        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        ///<inheritdoc/>
        public override double GetSquare()
        {
            if (FirstSide <= 0 || SecondSide <= 0 || ThirdSide <= 0) throw new InvalidOperationException();

            if (!Square.HasValue)
            {
                var perimiter = (FirstSide + SecondSide + ThirdSide) / 2;
                Square = Math.Sqrt(perimiter * (perimiter - FirstSide) * (perimiter - SecondSide) * (perimiter - ThirdSide));
            }

            return Square.Value;
        }

        ///<inheritdoc/>
        public bool GetIsRightTriangle()
        {
            if (!IsRightTriangle.HasValue)
            {
                var max = Math.Max(FirstSide, Math.Max(SecondSide, ThirdSide));
                var min = Math.Min(FirstSide, Math.Min(SecondSide, ThirdSide));

                IsRightTriangle = Math.Pow(max, 2) == Math.Pow(min, 2) + Math.Pow(FirstSide + SecondSide + ThirdSide - max - min, 2);
            }

            return IsRightTriangle.Value;
        }
    }
}
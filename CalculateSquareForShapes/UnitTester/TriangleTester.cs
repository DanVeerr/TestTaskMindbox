
namespace CalculateSquareForShapes.UnitTests
{
    public class TriangleTester
    {
        [SetUp]
        public void Setup() { }

        private static IEnumerable<double[]> ErrorSquareCaseTestData =>
            new List<double[]> 
            {
                new double[] { -1, 3, 3 },
                new double[] { 1, -1, 3 },
                new double[] { 61, 3, -3 }
            };

        [TestCaseSource(nameof(ErrorSquareCaseTestData))]
        public void ErrorSquareCaseTest(double firstSide, double secondSide, double thirdSide)
        {
            Assert.Catch<InvalidOperationException>(() => new Triangle(firstSide, secondSide, thirdSide).GetSquare());
        }

        private static IEnumerable<double[]> SuccessSquareCaseTestData =>
           new List<double[]> 
           {
                new double[] { 10, 20, 30 },
                new double[] { 200, 1, 7 },
                new double[] { 3, 4, 5 } 
           };

        [TestCaseSource(nameof(SuccessSquareCaseTestData))]
        public void SuccessSquareCaseTest(double firstSide, double secondSide, double thirdSide)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var perimiter = (firstSide + secondSide + thirdSide) / 2;
            var expectedValue = Math.Sqrt(perimiter * (perimiter - firstSide) * (perimiter - secondSide) * (perimiter - thirdSide));

            var square = triangle.GetSquare();

            Assert.That(square, Is.EqualTo(expectedValue));
        }

        private static IEnumerable<object[]> SuccessIsRightTriangleCaseTestData =>
           new List<object[]>
           {
                new object[] { 10, 20, 30, false },
                new object[] { 200, 1, 7, false },
                new object[] { 3, 4, 5, true }
           };

        [TestCaseSource(nameof(SuccessIsRightTriangleCaseTestData))]
        public void SuccessIsRightTriangleCaseTest(
            double firstSide,
            double secondSide,
            double thirdSide,
            bool expectedValue
           )
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var isRightTriangle = triangle.GetIsRightTriangle();

            Assert.That(expectedValue, Is.EqualTo(isRightTriangle));
        }
    }
}

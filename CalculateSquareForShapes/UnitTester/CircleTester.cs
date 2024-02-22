namespace CalculateSquareForShapes.UnitTests
{
    public class CircleTester
    {
        [SetUp]
        public void Setup() { }

        private static IEnumerable<double> ErrorSquareCaseTestData =>
            new List<double> { -1, -1000 };

        [TestCaseSource(nameof(ErrorSquareCaseTestData))]
        public void ErrorCaseTest(double radius)
        {
            Assert.Catch<InvalidOperationException>(() => new Circle(radius).GetSquare());
        }

        private static IEnumerable<double> SuccessSquareCaseTestData =>
           new List<double> { 5, 2500, 2500.17 };

        [TestCaseSource(nameof(SuccessSquareCaseTestData))]
        public void SuccessSquareCaseTest(double radius)
        {
            var circle = new Circle(radius);
            var expectedValue = Math.PI * Math.Pow(radius, 2);

            var square = circle.GetSquare();

            Assert.That(square, Is.EqualTo(expectedValue));
        }
    }
}

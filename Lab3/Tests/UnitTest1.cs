using Microsoft.VisualStudio.TestPlatform.TestHost;
using static Lab3.Program;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        private double accuracy = 0.01;
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            double a = 2;
            double b = -3;
            double c = -3;

            var expected = new List<double> { -0.69, 2.19 };

            //action
            var actual = Solver.SolveQuadraticEquation(a, b, c);

            //assert
            Assert.AreEqual(expected[0], actual[0], accuracy, $"1 корень не соответствует допустимой точности.");
            //CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            double a = 1;
            double b = -4;
            double c = 4;

            var expected = new List<double> { 2, 2 };

            //action
            var actual = Solver.SolveQuadraticEquation(a, b, c);

            //assert
            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            double a = 2;
            double b = 4;
            double c = 7;

            //action
            var actual = Solver.SolveQuadraticEquation(a, b, c);

            //assert
            CollectionAssert.AreEquivalent(null, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //arrange
            double a = 0;
            double b = 2;
            double c = 3;

            //action
            var actual = Solver.SolveQuadraticEquation(a, b, c);

            //assert
            CollectionAssert.AreEquivalent(null, actual);
        }
    }
}
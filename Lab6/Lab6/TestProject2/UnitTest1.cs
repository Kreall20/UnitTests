using Lab6;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1PositiveElements
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<double> list = new() { 2, 3, -1, -3, -1, -1 };
            List<double> expected = new() { 2, 3 };

            var actual = Program.PositivEelements(list);

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            List<double> list = new() { 2, 3, -1, -3, -1, -1 };
            List<double> expected = new() { 2 };

            var actual = Program.PositivEelements(list, 1);

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            List<double> list = new() { 2, -1, 3, -3, -1, -1 };
            List<double> expected = new() { 2 };

            var actual = Program.PositivEelements(list, 2);

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            List<double> list = new() { 2, 3, -1, 5, -3, -1, -1 };
            List<double> expected = new() { 2, 3, 5 };

            var actual = Program.PositivEelements(list, 4);

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            List<double> list = new() { 2, 3, -1, 5, -3, -1, -1 };
            List<double> expected = new() { 2, 3, 5 };

            var actual = Program.PositivEelements(list, list.Count - 1);

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            List<double> list = new() { 2, 3, -1, 5, -3, -1, -1 };
            List<double> expected = new() { 2, 3, 5 };

            var actual = Program.PositivEelements(list, list.Count);

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            List<double> list = new() { 2, 3, -1, 5, -3, -1, -1 };

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Program.PositivEelements(list, list.Count + 1));
        }
        [TestMethod]
        public void TestMethod8()
        {
            List<double> list = new() { 2, 3, -1, 5, -3, -1, -1 };
            List<double> expected = new() { };

            var actual = Program.PositivEelements(list, 0);

            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
    [TestClass]
    public class UnitTestClassColumnSum
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[,] matrix = { {1, 2, 3 },
                                 {4, 5, 6 }, 
                                 {7, 8, 9 } };

            List<double> expected = new List<double>();
            var actual = Program.Columnsum(matrix, 0, 0);

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double[,] matrix = { {1, 2, 3 },
                                 {4, 5, 6 },
                                 {7, 8, 9 } };

            List<double> expected = new() {1};
            var actual = Program.Columnsum(matrix, 1, 1);

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double[,] matrix = { {1, 2, 3 },
                                 {4, 5, 6 },
                                 {7, 8, 9 } };

            List<double> expected = new() {1, 2};
            var actual = Program.Columnsum(matrix, 2, 1);

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double[,] matrix = { {1, 2, 3 },
                                 {4, 5, 6 },
                                 {7, 8, 9 } };

            List<double> expected = new() { 1, 2, 3 };
            var actual = Program.Columnsum(matrix, 3, 1);

            CollectionAssert.AreEquivalent(expected, actual);
        }
        /*[TestMethod]
        public void TestMethod5()
        {
            double[,] matrix = { {1, 2, 3 },
                                 {4, 5, 6 },
                                 {7, 8, 9 } };

            List<double> expected = new() { 5 };
            var actual = Program.Columnsum(matrix, 1, 2);

            CollectionAssert.AreEquivalent(expected, actual);
        }*/
        [TestMethod]
        public void TestMethod6()
        {
            double[,] matrix = { {1, 2, 3 },
                                 {4, 5, 6 },
                                 {7, 8, 9 } };

            List<double> expected = new() { 12 };
            var actual = Program.Columnsum(matrix, 1, 3);

            CollectionAssert.AreEquivalent(expected, actual);
        }
/*        [TestMethod]
        public void TestMethod7()
        {
            double[,] matrix = { {1, 2, 3 },
                                 {4, 5, 6 },
                                 {7, 8, 9 } };

            List<double> expected = new() { 5, 7 };
            var actual = Program.Columnsum(matrix, 2, 2);

            CollectionAssert.AreEquivalent(expected, actual);
        }*/
        [TestMethod]
        public void TestMethod8()
        {
            double[,] matrix = { {1, 2, 3 },
                                 {4, 5, 6 },
                                 {7, 8, 9 } };

            List<double> expected = new() { 12, 15 };
            var actual = Program.Columnsum(matrix, 2, 3);

            CollectionAssert.AreEquivalent(expected, actual);
        }
/*        [TestMethod]
        public void TestMethod9()
        {
            double[,] matrix = { {1, 2, 3 },
                                 {4, 5, 6 },
                                 {7, 8, 9 } };

            List<double> expected = new() { 5, 7, 9 };
            var actual = Program.Columnsum(matrix, 3, 2);

            CollectionAssert.AreEquivalent(expected, actual);
        }*/
        [TestMethod]
        public void TestMethod10()
        {
            double[,] matrix = { {1, 2, 3 },
                                 {4, 5, 6 },
                                 {7, 8, 9 } };

            List<double> expected = new() { 12, 15, 18 };
            var actual = Program.Columnsum(matrix, 3, 3);

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void TestMethod11()
        {
            double[,] matrix = { {1, 2, 3 },
                                 {4, 5, 6 },
                                 {7, 8, 9 } };

            Assert.ThrowsException<IndexOutOfRangeException>(() => Program.Columnsum(matrix, 4, 1));

        }
    }
}
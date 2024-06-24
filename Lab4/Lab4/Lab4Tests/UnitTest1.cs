using Lab4;

namespace Lab4Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };
            double toSearch = 4;
            int expected = 5;

            var real = BinarySearch.FindElement(arr, toSearch);

            Assert.AreEqual(expected, real + 1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double[] arr = { 1, 3, 4, 5, 9, 11, 12 };
            double toSearch = 12;
            int expected = 7;

            var real = BinarySearch.FindElement(arr, toSearch);

            Assert.AreEqual(expected, real + 1);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double[] arr = { 12, 13, 15, 14, 19 };
            double toSearch = 13;
            int expected = 2;

            var real = BinarySearch.FindElement(arr, toSearch);

            Assert.AreEqual(expected, real + 1);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double[] arr = { };
            double toSearch = 1;
            int expected = -2;

            var real = BinarySearch.FindElement(arr, toSearch);

            Assert.AreEqual(expected, real);
        }
        [TestMethod]
        public void TestMethod5()
        {
            double[] arr = { 1, 2, 5, 1, 7, 1, 5, 5, 5 };
            double toSearch = 5;
            int expected = 5;

            var real = BinarySearch.FindElement(arr, toSearch);

            Assert.AreEqual(expected, real + 1);
        }
        [TestMethod]
        public void TestMethod6()
        {
            double[] arr = { 5 };
            double toSearch = 5;
            int expected = 1;

            var real = BinarySearch.FindElement(arr, toSearch);

            Assert.AreEqual(expected, real + 1);
        }
        [TestMethod]
        public void TestMethod7()
        {
            double[] arr = { 1, 2, 5, 1, 7, 1, 5, 5, 5 };
            double toSearch = 15;
            int expected = -1;

            var real = BinarySearch.FindElement(arr, toSearch);

            Assert.AreEqual(expected, real);
        }
        [TestMethod]
        public void TestMethod8()
        {
            double[] arr = { 1, 3, 4, 5, 9, 11, 12 };
            double toSearch = 4;
            int expected = 3;

            var real = BinarySearch.FindElement(arr, toSearch);

            Assert.AreEqual(expected, real + 1);
        }
        [TestMethod]
        public void TestMethod9()
        {
            double[] arr = { 1, 3, 4, 5, 9, 11, 12 };
            double toSearch = 9;
            int expected = 5;

            var real = BinarySearch.FindElement(arr, toSearch);

            Assert.AreEqual(expected, real + 1);
        }
        [TestMethod]
        public void TestMethod10()
        {
            double res = 0;
            Program.InputElementTest(ref res, "10");
            Assert.AreEqual(10, res);
        }
        [TestMethod]
        public void TestMethod11()
        {
            double res = 0;
            Assert.ThrowsException<ArgumentException>(() => Program.InputElementTest(ref res, "10sadflkj"));
        }
        [TestMethod]
        public void TestMethod12()
        {
            var list = new List<double>();
            bool flag = true;
            Program.InputArrayTest(ref list, ref flag, "10;11;45;14");
            Assert.AreEqual(true, flag);
        }
        [TestMethod]
        public void TestMethod13()
        {
            var list = new List<double>();
            bool flag = true;
            Program.InputArrayTest(ref list, ref flag, "10;11;45asdfasd;14");
            Assert.AreEqual(false, flag);
        }
    }
}
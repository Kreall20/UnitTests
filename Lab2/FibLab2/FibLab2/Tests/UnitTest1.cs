using Lab2console;
using Xunit.Sdk;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void FibonachiTest1()
        {
            //arrange
            int input = -1;
            long expected = -1;

            //action
            Fibonacci fibonachi = new Fibonacci();
            long actual = fibonachi.FibonachiByIndex(input);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void FibonachiTest2()
        {
            //arrange
            int input = 0;
            long expected = -1;

            //action
            Fibonacci fibonachi = new Fibonacci();
            long actual = fibonachi.FibonachiByIndex(input);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void FibonachiTest3()
        {
            //arrange
            int input = 1;
            long expected = 1;

            //action
            Fibonacci fibonachi = new Fibonacci();
            long actual = fibonachi.FibonachiByIndex(input);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void FibonachiTest4()
        {
            //arrange
            int input = 50;
            long expected = 12586269025;

            //action
            Fibonacci fibonachi = new Fibonacci();
            long actual = fibonachi.FibonachiByIndex(input);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FibonachiTest6()
        {
            //arrange
            int input = 51;
            long expected = -1;

            //action
            Fibonacci fibonachi = new Fibonacci();
            long actual = fibonachi.FibonachiByIndex(input);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FibonachiTest7()
        {
            //arrange
            int input = 25;
            long expected = 75025;

            //action
            Fibonacci fibonachi = new Fibonacci();
            long actual = fibonachi.FibonachiByIndex(input);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
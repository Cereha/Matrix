using NUnit.Framework;
using Consoleapp1;
namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMatrixSum()
        {
            var first = new Matrix();
            var second = new Matrix();
            var val = first + second;
            int[,] array2D = new int[2, 2] { { 2, 4 }, { 6, 8 } };
            Assert.AreEqual(val.getarray(), array2D);
        }
        [Test]
        public void TestMatrixMult()
        {
            var first = new Matrix();
            var second = new Matrix();
            var val = first * second;
            int[,] array2D = new int[2, 2] { { 7, 10 }, { 15, 22 } };
            Assert.AreEqual(val.getarray(), array2D);
        }
    }
}
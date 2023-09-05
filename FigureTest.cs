using FigureLibrary;

namespace TestProject4
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod]
        public void CalculateArea_0_0returned()
        {
            // arrange
            double x = 0;
            double expected = 0;
            // act
            Figure a = new Figure();
            double actual = a.CalculateArea(x);
            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CalculateArea_1_3returned()
        {
            // arrange
            double x = 1;
            double expected = 3.141592653589793;
            // act
            Figure a = new Figure();
            double actual = a.CalculateArea(x);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateArea_2_6returned()
        {
            // arrange
            double x = 2;
            double expected = 12.566370614359172;
            // act
            Figure a = new Figure();
            double actual = a.CalculateArea(x);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateArea_0and0and0_0returned()
        {
            // arrange
            double x = 0;
            double y = 0;
            double z = 0;
            // act
            Figure a = new Figure();
            // assert
            Assert.ThrowsException<ArgumentException>(() => a.CalculateArea(x, y, z));
        }

        [TestMethod]
        public void CalculateArea_1and1and1_0returned()
        {
            // arrange
            double x = 1;
            double y = 1;
            double z = 1;
            double expected = 0.4330127018922193;
            // act
            Figure a = new Figure();
            double actual = a.CalculateArea(x, y, z);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateArea_3and4and5_6returned()
        {
            // arrange
            double x = 3;
            double y = 4;
            double z = 5;
            double expected = 6;
            // act
            Figure a = new Figure();
            double actual = a.CalculateArea(x, y, z);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRightTriangle_3and4and5_1returned() {
            // arrange
            double x = 3;
            double y = 4;
            double z = 5;
            bool expected = true;
            // act
            Figure a = new Figure();
            bool actual = a.IsRightTriangle(x, y, z);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRightTriangle_1and1and1_0returned()
        {
            // arrange
            double x = 1;
            double y = 1;
            double z = 1;
            bool expected = false;
            // act
            Figure a = new Figure();
            bool actual = a.IsRightTriangle(x, y, z);
            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}

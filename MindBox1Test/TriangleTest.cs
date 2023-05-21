using Mindbox1;
using NUnit.Framework;

namespace Tests
{
    public partial class Tests
    {

        [Test]
        public void Square_1and2and3_0Returned()
        {
            //arrange
            Triangle triangle = new Triangle(1,2,3);

            //act
            var actual = triangle.Square();

            //assert
            Assert.AreEqual(0,actual);
        }
        [Test]
        public void IsRectangular_1and2and3_falseReturned()
        {
            //arrange
            Triangle triangle = new Triangle(1, 2, 3);

            //act
            var actual = triangle.IsRectangular();

            //assert
            Assert.AreEqual(false, actual);
        }
        
        [Test]
        public void Square_5and12and13_30Returned()
        {
            //arrange
            Triangle triangle = new Triangle(5, 12, 13);

            //act
            var actual = triangle.Square();

            //assert
            Assert.AreEqual(30, actual);
        }

        [Test]
        public void IsRectangular_5and12and13_trueReturned()
        {
            //arrange
            Triangle triangle = new Triangle(5, 12, 13);

            //act
            var actual = triangle.IsRectangular();

            //assert
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void Square_2and4and5_3dot8Returned()
        {
            //arrange
            double expected = 3.8d;
            Triangle triangle = new Triangle(2, 4, 5);
            
            //act
            double actual = triangle.Square();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsRectangular_2and4and5_trueReturned()
        {
            //arrange
            Triangle triangle = new Triangle(2, 4, 5);

            //act
            var actual = triangle.IsRectangular();

            //assert
            Assert.AreEqual(false, actual);
        }
    }
}

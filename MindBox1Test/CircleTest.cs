using Mindbox1;
using NUnit.Framework;

namespace Tests
{
    public partial class Tests
    {

        [Test]
        public void Square_10_314dot16Returned()
        {
            //arrange
            double expected = 314.16d;
            Circle circle = new Circle(10);

            //act
            var actual = circle.Square();

            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}
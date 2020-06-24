using Moq;
using NUnit.Framework;

namespace AbstarctClassOrderProcessing
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1PhysicalProduct()
        {
            // arrange
            var sut = new Mock<PaymentType>();

            sut.Setup(x => x.TypeOfTask()).Returns("Generate packing slip for shipping");

            // act
            var actual = sut.Object.TypeOfTask();

            // assert
            Assert.AreEqual("Generate packing slip for shipping", actual);
          
        }
    }
}
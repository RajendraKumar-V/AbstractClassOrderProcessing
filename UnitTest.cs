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

        [Test]
        public void TestBook()
        {
            // arrange
            var sut = new Mock<PaymentType>();

            sut.Setup(x => x.TypeOfTask()).Returns("Create a duplicate packing slip for the royality department");

            // act
            var actual = sut.Object.TypeOfTask();

            // assert
            Assert.AreEqual("Create a duplicate packing slip for the royality department", actual);

        }

        [Test]
        public void TestMembership()
        {
            // arrange
            var sut = new Mock<PaymentType>();

            sut.Setup(x => x.TypeOfTask()).Returns("activate that membership");

            // act
            var actual = sut.Object.TypeOfTask();

            // assert
            Assert.AreEqual("activate that membership", actual);

        }

        [Test]
        public void TestUpgradeMembership()
        {
            // arrange
            var sut = new Mock<PaymentType>();

            sut.Setup(x => x.TypeOfTask()).Returns("upgarde to membership");

            // act
            var actual = sut.Object.TypeOfTask();

            // assert
            Assert.AreEqual("upgarde to membership", actual);

        }

        [Test]
        public void TestMembershipOrUpgrade()
        {
            // arrange
            var sut = new Mock<PaymentType>();

            sut.Setup(x => x.TypeOfTask()).Returns("email the owner and inform them");

            // act
            var actual = sut.Object.TypeOfTask();

            // assert
            Assert.AreEqual("email the owner and inform them", actual);

        }

        [Test]
        public void TestVideo()
        {
            // arrange
            var sut = new Mock<PaymentType>();

            sut.Setup(x => x.TypeOfTask()).Returns("add a free first aid video");

            // act
            var actual = sut.Object.TypeOfTask();

            // assert
            Assert.AreEqual("add a free first aid video", actual);

        }

        [Test]
        public void TestPhysicalproductorbook()
        {
            // arrange
            var sut = new Mock<PaymentType>();

            sut.Setup(x => x.TypeOfTask()).Returns("generate a commission");

            // act
            var actual = sut.Object.TypeOfTask();

            // assert
            Assert.AreEqual("generate a commission", actual);

        }
    }
}
using NUnit.Framework;
using levelup;

namespace DotNetExample.Tests.Unit
{
    [TestFixture]
    public class CharacterTest
    {
        private Character? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new Character();
        }

        [Test]
        public void GetCharacterPosition()
        {

#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObj.CurrentPosition);
            testObj.CurrentPosition.Position.X.Should().BeGreaterThanOrEqualTo(1);
            testObj.CurrentPosition.Position.X.Should().BeLessThanOrEqualTo(10);
            testObj.CurrentPosition.Position.Y.Should().BeGreaterThanOrEqualTo(1);
            testObj.CurrentPosition.Position.Y.Should().BeLessThanOrEqualTo(10);
            
        }
    }
}
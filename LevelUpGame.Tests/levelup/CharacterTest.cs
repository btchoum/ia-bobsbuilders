using NUnit.Framework;
using levelup;
using FluentAssertions;

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
            testObj.CurrentPosition.X.Should().BeGreaterThanOrEqualTo(1);
            testObj.CurrentPosition.X.Should().BeLessThanOrEqualTo(10);
            testObj.CurrentPosition.Y.Should().BeGreaterThanOrEqualTo(1);
            testObj.CurrentPosition.Y.Should().BeLessThanOrEqualTo(10);
            
        }
    }
}
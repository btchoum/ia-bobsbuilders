using NUnit.Framework;
using levelup;
using FluentAssertions;
using LevelUpGame.levelup;

namespace DotNetExample.Tests
{
    [Ignore("Move functionality not yet implemented")]
    public class CharacterTest
    {
        [Test]
        public void MoveTest()
        {
            Character testObj = new Character();
            FakeMap fakemap = new FakeMap();
            GameController testGameController = new GameController();
            Position startPosition = testGameController.GetStatus().Position;
            testObj.Move(DIRECTION.EAST, fakemap);
            Position endPosition = testGameController.GetStatus().Position;
            int testPosition = (int)(startPosition.X) + 1;

            Assert.AreEqual((int)(endPosition.X), testPosition);
            Assert.AreEqual((int)(endPosition.Y), (int)(startPosition.Y));

        }

        [Test]
        public void MoveUpdatesPosition()
        {
            var character = new Character();
            var fakeMap = new FakeMap();
            var expectedPosition = new Position(5, 5);
            fakeMap.CalculatePositionShouldReturn(expectedPosition);

            character.Move(DIRECTION.EAST, fakeMap);

            character.CurrentPosition.Should().Be(expectedPosition);
        }

        [Test]
        public void MoveUpdatesMoveCount()
        {
            var character = new Character();
            var fakeMap = new FakeMap();

            character.Move(DIRECTION.EAST, fakeMap);
            character.Move(DIRECTION.NORTH, fakeMap);

            character.MoveCount.Should().Be(2);
        }
    }
}
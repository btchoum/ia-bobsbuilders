using NUnit.Framework;
using levelup;
using FluentAssertions;
using LevelUpGame.levelup;
using DotNetExample.Tests.Steps;

namespace DotNetExample.Tests
{
    public class CharacterTest
    {
        [Test]
        public void MoveTest()
        {
            Character testObj = new Character();
            FakeMap fakemap = new FakeMap();
            GameController testGameController = new GameController ();
            Position startPosition = testGameController.GetStatus().Position;
            testObj.Move(DIRECTION.EAST,fakemap);
            Position endPosition = testGameController.GetStatus().Position;
            int testPosition = (int)(startPosition.X) + 1; 

            Assert.AreEqual((int)(endPosition.X),testPosition);
            Assert.AreEqual((int)(endPosition.Y),(int)(startPosition.Y));

        }

    }
}
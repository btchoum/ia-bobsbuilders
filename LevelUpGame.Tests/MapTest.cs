using NUnit.Framework;
using levelup;
using LevelUpGame.levelup;

namespace DotNetExample.Tests.Steps;


    public class MapTest
    {
        [Test]
        public void calculatePosition()
        {
            Map map = new Map();
            Position pos = new Position();
            Position newPos = map.CalculatePosition(pos, DIRECTION.EAST);
            Assert.AreEqual(2, newPos.X);
        }

    }


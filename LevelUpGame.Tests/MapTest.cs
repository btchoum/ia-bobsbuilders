using NUnit.Framework;
using levelup;

namespace DotNetExample.Tests.Steps;


    public class MapTest
    {
        [Test]
        public void calculatePosition()
        {
            Map map = new Map();
            Position pos = new Position();
            Position newPos = map.calculatePosition(pos, 1);
            Assert.assertEquals(newPos.x, 2);
        }

    }


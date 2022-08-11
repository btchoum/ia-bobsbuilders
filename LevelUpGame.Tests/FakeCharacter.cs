using System;
using levelup;

namespace DotNetExample.Tests.Steps
{

    public class FakeCharacter : ICharacter
    {
        // This will be the dummy character for testing
        public string Name {get;}
        public int MoveCount {get; set;}
        public GameController.Position CurrentPosition {get; set;}
        public GameController.DIRECTION LastMoveDirection {get; private set;}
        public IMap LastMoveMap {get; private set;}


        public void Move( GameController.DIRECTION direction, IMap map) {
            LastMoveDirection = direction;
            LastMoveMap = map;
        }

        private void IncrementMoveCount()
        {
        }

        private void updatePosition(GameController.Position newPosition)
        {
        }

    }
}
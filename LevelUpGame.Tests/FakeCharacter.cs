using levelup;
using LevelUpGame.levelup;

namespace DotNetExample.Tests
{
    public class FakeCharacter : Character
    {
        // This will be the dummy character for testing
        public string Name { get; }
        public int MoveCount { get; set; }
        public Position CurrentPosition { get; set; }
        public DIRECTION LastMoveDirection { get; private set; }
        public Map LastMoveMap { get; private set; }

        public override void Move(DIRECTION direction, Map map)
        {
            LastMoveDirection = direction;
            LastMoveMap = map;
        }

        private void IncrementMoveCount()
        {
        }

        private void UpdatePosition(Position newPosition)
        {
        }
    }
}
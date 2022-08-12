using LevelUpGame.levelup;

namespace levelup
{
    public class Character
    {
        // Bob the Builder makes the Monters run away
        public Character()
        {
            Init();
        }

        private void Init()
        {
            Name = string.Empty;
        }

        public string? Name {get; set;}
        public int MoveCount {get; set;}
        public Position currentPosition {get; set;}

        public virtual void Move(DIRECTION direction, Map map) {

        }
        public Position GetPosition()
        {
            return new Position(0,0);
        }
        private void IncrementMoveCount()
        {
        }

        private void updatePosition(Position newPosition)
        {
            currentPosition = newPosition;
        }
    }
}
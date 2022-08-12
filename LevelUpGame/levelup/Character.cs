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
        public Position CurrentPosition {get; set;}

        public virtual void Move(DIRECTION direction, Map map) {}

        private void IncrementMoveCount()
        {
        }

        private void updatePosition(Position newPosition)
        {
        }
    }
}
using LevelUpGame.levelup;

namespace levelup
{
    public class Character
    {
        // Bob the Builder makes the Monters run away
        public Character()
        {
            init();
        }

        private void init()
        {
            this.Name = string.Empty;
        }

        public string? Name {get; set;}
        public int MoveCount {get; set;}
        public Position CurrentPosition {get; set;}

        public void Move(DIRECTION direction, Map map) {}

        private void IncrementMoveCount()
        {
        }

        private void updatePosition(Position newPosition)
        {
        }
    }
}
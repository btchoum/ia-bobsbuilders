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
        public virtual int MoveCount {get; set;}
        public virtual Position CurrentPosition {get; set;}

        public virtual void Move(DIRECTION direction, Map map) 
        {

        }

        private void IncrementMoveCount()
        {
        }

        private void updatePosition(Position newPosition)
        {
            CurrentPosition = newPosition;
        }
    }
}
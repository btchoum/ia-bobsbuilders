namespace levelup
{
    public class Character : ICharacter
    {
        // Bob the Builder makes the Monters run away
        public Character()
        {
            init();
        }
        private void init()
        {
            this.Name = String.Empty;
        }
        public string? Name {get; set;}
        public int MoveCount {get; set;}
        public GameController.Position CurrentPosition {get; set;}

        public void Move( GameController.DIRECTION direction, IMap map) {}

        private void IncrementMoveCount()
        {
        }

        private void updatePosition(GameController.Position newPosition)
        {
        }

    }
}
namespace levelup
{
    public class Character : ICharacter
    {
        // Bob the Builder makes the Monters run away
        public string Name {get;}
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
using LevelUpGame.levelup;

namespace levelup
{
    public class Map
    {
        public string Name {get;}
        private int xLimit;
        private int yLimit;

        public Position CalculatePosition(Position pos, DIRECTION dir) 
        {
            return new Position(0, 0);
        }

        private bool ValidatePosition()
        {
            return false;
        }
    }
}
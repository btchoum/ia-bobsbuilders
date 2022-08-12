using LevelUpGame.levelup;

namespace levelup
{
    public class Map
    {
        public string name {get;}
        private int xLimit;
        private int yLimit;

        public Position calculatePosition(Position pos, DIRECTION dir) 
        {
            return new Position(0, 0);
        }

        private bool validatePosition()
        {
            return false;
        }
    }
}
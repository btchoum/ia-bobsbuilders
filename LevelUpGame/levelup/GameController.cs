using LevelUpGame.levelup;

namespace levelup
{
    public class GameController
    {
        // TODO: If your stakeholder wants to call this CHARACTER, change var name for
        // low representational gap
        public readonly string DEFAULT_CHARACTER_NAME = "Character";
        private Map _map;
        private Character _character;

        GameStatus status = new GameStatus();

        public GameController() : this(new Map(), new Character())
        {

        }

        public GameController(Map map, Character character)
        {
            _map = map;
            _character = character;
            status.CharacterName = DEFAULT_CHARACTER_NAME;
        }

        // Pre-implemented to demonstrate ATDD
        // TODO: Update this if it does not match your design
        public void CreateCharacter(string name)
        {
            if (name != null && !name.Equals(""))
            {
                status.CharacterName = name;
            }
            else
            {
                status.CharacterName = DEFAULT_CHARACTER_NAME;
            }
        }

        public void StartGame()
        {
            // TODO: Implement startGame - Should probably create tiles and put the character
            // on them?
            // TODO: Should also update the game status?
        }

        public GameStatus GetStatus()
        {
            return status;
        }

        public void Move(DIRECTION directionToMove)
        {
            //TODO: Implement move - should call something on another class
            _character.Move(directionToMove, _map);
            //TODO: Should probably also update the game status
        }
    }
}
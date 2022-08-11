using System;
using levelup;

namespace DotNetExample.Tests.Steps
{
    public interface ICharacter
    {
        string Name {get;}
        int MoveCount {get; set;}
        GameController.Position CurrentPosition {get; set;}

        void Move( GameController.DIRECTION direction, IGameMap map);
        
    }

    public class FakeCharacter : ICharacter
    {
        // This will be the dummy character for testing
        public string Name {get;}
        public int MoveCount {get; set;}
        public GameController.Position CurrentPosition {get; set;}

        public void Move( GameController.DIRECTION direction, IGameMap map) {}

    }

    public interface IGameMap {}
}
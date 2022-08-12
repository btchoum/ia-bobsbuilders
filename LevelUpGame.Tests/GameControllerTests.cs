using NUnit.Framework;
using levelup;
using FluentAssertions;
using LevelUpGame.levelup;
using DotNetExample.Tests.Steps;

namespace DotNetExample.Tests;

public class GameControllerTests
{
    [Test]
    public void MoveShouldMoveTheCharacter()
    {
        FakeMap map = new FakeMap();
        FakeCharacter characterSpy = new FakeCharacter();

        GameController gameController = new GameController(map, characterSpy);
        gameController.Move(DIRECTION.NORTH);

        characterSpy.LastMoveDirection.Should().Be(DIRECTION.NORTH);
        characterSpy.LastMoveMap.Should().Be(map);
    }

    [Test]
    public void MoveShouldUpdateGameStatus()
    {
      
        FakeMap map = new FakeMap();
        FakeCharacter characterSpy = new FakeCharacter();

        GameController gameController = new GameController(map, characterSpy);
        
        GameStatus gameStatus = gameController.GetStatus();
      
        gameController.Move(DIRECTION.NORTH);

        gameStatus.MoveCount.Should().Be(25);
        
     //   characterSpy.LastMoveDirection.Should().Be(DIRECTION.NORTH);
     //   characterSpy.LastMoveMap.Should().Be(map);

    }
    
    public class TestableGameController : GameController
    {
        public TestableGameController(Map map, Character character) : base(map, character)
        {

        }
    }
}
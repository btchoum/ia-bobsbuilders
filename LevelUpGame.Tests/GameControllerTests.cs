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
        FakeCharacter fakeCharacter = new FakeCharacter();

        var expectedMoveCount = 25;
        var expectedPosition = new Position(1, 1);
        fakeCharacter.InjectMoveCount(expectedMoveCount);
        fakeCharacter.InjectPosition(expectedPosition);

        GameController gameController = new GameController(map, fakeCharacter);
      
        gameController.Move(DIRECTION.NORTH);
      
        GameStatus gameStatus = gameController.GetStatus();

        gameStatus.MoveCount.Should().Be(expectedMoveCount);
        gameStatus.Position.Should().Be(expectedPosition);
    }
    
    //public class TestableGameController : GameController
    //{
    //    public TestableGameController(Map map, Character character) : base(map, character)
    //    {

    //    }
    //}
}
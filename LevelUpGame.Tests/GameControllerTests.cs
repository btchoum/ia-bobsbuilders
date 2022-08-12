using NUnit.Framework;
using levelup;
using FluentAssertions;
using LevelUpGame.levelup;
using DotNetExample.Tests.Steps;

namespace DotNetExample.Tests;


public class GameControllerTests {


[Test]
public void MoveShouldMoveTheCharacter() {
    Map map = new FakeMap();
    FakeCharacter characterSpy = new FakeCharacter();

    GameController gameController = new GameController(map, characterSpy);
    gameController.Move(DIRECTION.NORTH);
    
    characterSpy.LastMoveDirection.Should().Be(DIRECTION.NORTH);
    characterSpy.LastMoveMap.Should().Be(map);

}

public class TestableGameController : GameController {
    
    public TestableGameController(Map map, Character character) : base(map, character){
        

    }
}

}
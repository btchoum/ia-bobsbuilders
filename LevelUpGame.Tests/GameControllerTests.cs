using NUnit.Framework;
using levelup;
using FluentAssertions;

namespace DotNetExample.Tests;


public class GameControllerTests {


[Test]
public void MoveShouldMoveTheCharacter() {
    IMap map = new FakeMap();
    FakeCharacter characterSpy = new FakeCharacter();

    GameController gameController = new GameController(map, characterSpy);
    gameController.move(DIRECTION.NORTH);
    
    characterSpy.LastMoveDirection.Should().Be(DIRECTION.NORTH);
    chracterSpy.LastMoveMap.Should().Be(map);

}

public class TestableGameController : GameController {
    
    public TestableGameController(IMap map, ICharacter character) : base(map, character){
        

    }
}

}
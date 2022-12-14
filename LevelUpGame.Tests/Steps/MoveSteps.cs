using System;
using FluentAssertions;
using levelup;
using LevelUpGame.levelup;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class MoveSteps
    {
        // private readonly ScenarioContext _scenarioContext;
        private GameController testObj = new GameController();

        private int startX;
        private int startY;
        private int startMoves;
        private int direction;

        public MoveSteps(ScenarioContext scenarioContext)
        {
            //   _scenarioContext = scenarioContext;
        }

        [Given(@"the character's starting position is (.*) (.*)")]
        public void GivenTheCharactersStartingPosition(int startX, int startY)
        {
            this.startX = startX;
            this.startY = startY;
        }

        [Given(@"the character's move count is (.*)")]
        public void GivenTheCharactersMoveCount(int startMoves)
        {
            this.startMoves = startMoves;
        }

        //TODO: come back and finish this method ...
        [When(@"the character inputs a (.*)")]
        public void WhenTheCharacterMovesInDirection (DIRECTION direction)
        {
            
            testObj.Move(direction);
           
        }

        [Then(@"the Game sets the character's newPosition to (.*) (.*)")]
        public void ThenTheGameSetstheCharacterPosition(int endX, int endY) {

           testObj.GetStatus().Position.X.Should().Be(endX);
           testObj.GetStatus().Position.Y.Should().Be(endY);
        }

        [Then(@"the game increments the move count to (.*)")]
        public void ThenTheGameIncrementsMoveCount(int endMoves)
        {
            
            testObj.GetStatus().MoveCount.Should().Be(endMoves);

        }
    }
}
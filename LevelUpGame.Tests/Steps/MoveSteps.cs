using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using FluentAssertions;
using levelup;

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

        [Given(@"the character's starting position (.*) (.*)")]
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
        public void GivenTheCharactersStartingPosition(int startX, int startY)
        {
            this.startX = startX;
            this.startY = startY;
        }

        [When(@"the character sets their name")]
        public void whenTheCharacterSetsTheirName()
        {
            testObj = new GameController();
            testObj.CreateCharacter(characterName);
        }
        [Then(@"the Game sets the character's name to (.*)")]
        public void ThenTheResultShouldBe(string characterNameOutput)
        {
            testObj.GetStatus().characterName.Should().Be(characterNameOutput);
        }
    }
}
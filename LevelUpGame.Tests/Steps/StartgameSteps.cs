using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using FluentAssertions;
using levelup;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class StartgameSteps
    {
        // private readonly ScenarioContext _scenarioContext;
        private GameController testObj = new GameController();

   

        public StartgameSteps(ScenarioContext scenarioContext)
        {
            //   _scenarioContext = scenarioContext;
        }

        [Given(@"the character is created")]
        public void GivenTheStartPositionIs()
        {
            //Comment
        }

        [When(@"the player starts the game")]
        public void whenThePlayerStartstheGame()
        {
            testObj = new GameController();
            testObj.StartGame();
        }

        [Then(@"the Game creates the map and sets the character position")]
        public void ThenTheResultShouldBe()
        {
            int startX = testObj.GetStatus().Position.X;
            int startY = testObj.GetStatus().Position.Y;

            startX.Should().BeGreaterThanOrEqualTo(1);
            startX.Should().BeLessThanOrEqualTo(10);
            startY.Should().BeGreaterThanOrEqualTo(1);
            startY.Should().BeLessThanOrEqualTo(10);
        }
    }
}
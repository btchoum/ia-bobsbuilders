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
        public void GivenTheStartPositionIs(int startX, int startY)
        {
         
        }

        [When(@"the player starts the game")]
        public void whenThePlayerStartstheGame()
        {
            testObj = new GameController();
            testObj.StartGame();
        }
        [Then(@"the Game creates the map and sets the character position to (.*) (.*)")]
        public void ThenTheResultShouldBe(int characterX, int characterY)
        {
            bool xvalid = false;
            bool yvalid = false;
            int startX = testObj.GetStatus().Position.X;
            int startY = testObj.GetStatus().Position.Y;
            if (startX >=0 && startX <=9)
            {
                xvalid = true;
            }
            if (startY >=0 && startY <=9)
            {
                yvalid = true;
            }
            xvalid.Should.Be(true);
            yvalid.Should.Be(true);
        }
    }
}
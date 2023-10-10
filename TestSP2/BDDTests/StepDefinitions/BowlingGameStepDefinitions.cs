using TwoKatas;
namespace BDDTests.StepDefinitions
{
    [Binding]
    public sealed class BowlingGameStepDefinitions
    {
        BowlingGame game = new BowlingGame();
        int actual = 0;

        [Given("the player knocks down 10 pins with 1 roll")]
        public void GivenThePlayerKnocksDown10PinsWith1Roll()
        {
            game.roll(10);
        }

        [When("the player rolls the next 2 balls")]
        public void WhenThePlayerRollsTheNext2Balls()
        {
            game.roll(6);
            game.roll(3);
        }

        [Then("the amount of pins knocked down by those 2 balls is added as bonus")]
        public void ThenTheAmountOfPinsKnockedDownByThose2BallsIsAddedAsBonus()
        {
            actual = game.score();
            Assert.Equal(28, actual);
        }

        [Given("the player knocks down 10 pins with 2 rolls")]
        public void GivenThePlayerKnocksDown10PinsWith2Rolls()
        {
            game.roll(5);
            game.roll(5);
        }

        [When("the player rolls the next ball")]
        public void WhenThePlayerRollsTheNextBall()
        {
            game.roll(4);
        }

        [Then("the amount of pins knocked down by that ball is added as bonus")]
        public void ThenTheAmountOfPinsNockedDownByThatBallIsAddedAsBonus()
        {
            actual = game.score();
            Assert.Equal(18, actual);
        }

        
    }
}
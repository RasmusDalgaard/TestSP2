using TwoKatas;

namespace BDDTests.StepDefinitions
{
    [Binding]
    public class BowlingGameStepDefinitions
    {
        private BowlingGame _game;
        private int _score;

        [Given(@"fresh bowling game")]
        public void GivenFreshBowlingGame()
        {
            _game = new BowlingGame();
            _game.score().Should().Be(0);
        }

        [When(@"the player knocks down (.*) pins with one roll")]
        public void WhenThePlayerKnocksDownPinsWithOneRoll(int p0)
        {
            _game.roll(p0);
        }

        [When(@"then the player rolls the next two balls and hits (.*) pins and (.*) pins")]
        public void WhenThenThePlayerRollsTheNextTwoBallsAndHitsPinsAndPins(int p0, int p1)
        {
            _game.roll(p0);
            _game.roll(p1);
        }

        [Then(@"the score should be (.*)")]
        public void ThenTheScoreShouldBe(int p0)
        {
            _score = _game.score();
            _score.Should().Be(p0);
        }

        [Given(@"new game")]
        public void GivenNewGame()
        {
            _game = new BowlingGame();
            _game.score().Should().Be(0);
        }

        [When(@"the player knocks down (.*) pins with the first roll and (.*) with the second roll")]
        public void WhenThePlayerKnocksDownPinsWithTheFirstRollAndWithTheSecondRoll(int p0, int p1)
        {
            _game.roll(p0);
            _game.roll(p1);
        }

        [When(@"then the player knocks down (.*) pins on the next roll")]
        public void WhenThenThePlayerKnocksDownPinsOnTheNextRoll(int p0)
        {
            _game.roll(p0);
        }

        [Then(@"total score should be (.*)")]
        public void ThenTotalScoreShouldBe(int p0)
        {
            _score = _game.score();
            _score.Should().Be(p0);
        }

        [Given(@"bowling game")]
        public void GivenBowlingGame()
        {
            _game = new BowlingGame();
            _game.score().Should().Be(0);
        }

        [When(@"player rolls (.*) times and hits (.*) pins")]
        public void WhenPlayerRollsTimesAndHitsPins(int p0, int p1)
        {
            for (int i = 0; i < p0; i++)
            {
                _game.roll(p1);
            }
        }

        [Then(@"final score should be (.*)")]
        public void ThenFinalScoreShouldBe(int p0)
        {
            _score = _game.score();
            _score.Should().Be(p0);
        }
    }
}

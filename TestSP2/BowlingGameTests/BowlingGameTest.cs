using TwoKatas;

namespace BowlingGameTests
{
    public class BowlingGameTest
    {
        BowlingGame game = new BowlingGame();

        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                game.roll(pins);
            }
        }

        private void rollSpare()
        {
            game.roll(5);
            game.roll(5);
        }

        private void rollStrike()
        {
            game.roll(10);
        }

        [Fact]
        public void TestGutterGame()
        {
            rollMany(20, 0);
            Assert.Equal(0, game.score());
        }

        [Fact]
        public void testAllOnes()
        {
            rollMany(20, 1);
            Assert.Equal(20, game.score());
        }

        [Fact]
        public void testOneSpare()
        {
            rollSpare();
            game.roll(3);
            rollMany(17, 0);
            Assert.Equal(16, game.score());
        }
        [Fact]
        public void testOneStrike()
        {
            rollStrike();
            game.roll(3);
            game.roll(4);
            rollMany(16, 0);
            Assert.Equal(24, game.score());
        }

        [Fact]
        public void testPerfectGame()
        {
            rollMany(12, 10);
            Assert.Equal(300, game.score());
        }
    }
}
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Tennis.Tests
{
    [TestFixture]
    public class TennisGameTests
    {
        [Test]
        public void GivenPlayerOneScored_WhenScoreIsLoveLove_ThenScoreShouldBeFifteenLove()
        {
            // Arrange
            var game = new TennisGame("Player1", "Player2");

            // Act
            var actual = game.PrintScore();

            // Assert
            Assert.That(actual, Is.EqualTo("Fifteen-Love"));
        }
    }
}

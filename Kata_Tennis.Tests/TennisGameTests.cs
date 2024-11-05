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
        private TennisGame _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new TennisGame("Player1", "Player2");
        }

        [Test]
        public void GivenPlayerOneScored_WhenScoreIsLoveLove_ThenScoreShouldBeFifteenLove()
        {
            // Arrange
            _sut.Player1Scored();

            // Act
            var actual = _sut.PrintScore();

            // Assert
            Assert.That(actual, Is.EqualTo("15-Love"));
        }
        [Test]
        public void GivenPlayerOneScoredTwoTimes_WhenScoreIsLoveLove_ThenScoreShouldBeThirtyLove()
        {
            // Arrange
            _sut.Player1Scored();
            _sut.Player1Scored();

            // Act
            var actual = _sut.PrintScore();

            // Assert
            Assert.That(actual, Is.EqualTo("30-Love"));
        }
        [Test]
        public void GivenPlayerOneScoredThreeTimes_WhenScoreIsLoveLove_ThenScoreShouldBeFortyLove()
        {
            // Arrange
            _sut.Player1Scored();
            _sut.Player1Scored();
            _sut.Player1Scored();

            // Act
            var actual = _sut.PrintScore();

            // Assert
            Assert.That(actual, Is.EqualTo("40-Love"));
        }
    }
}

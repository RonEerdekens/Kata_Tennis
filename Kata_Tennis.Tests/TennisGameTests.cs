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

        private void AddScores(int player1Score, int player2Score)
        {
            for (int i = 0; i < player1Score; i++)
            {
                _sut.Player1Scored();
            }
            for (int i = 0; i < player2Score; i++)
            {
                _sut.Player2Scored();
            }
        }

        [TestCase(1, 0, "15-Love")]
        [TestCase(2, 0, "30-Love")]
        [TestCase(3, 0, "40-Love")]
        [TestCase(0, 1, "Love-15")]
        [TestCase(0, 2, "Love-30")]
        [TestCase(0, 3, "Love-40")]
        [TestCase(1, 1, "15-15")]
        [TestCase(2, 2, "30-30")]
        [TestCase(1, 2, "15-30")]
        [TestCase(1, 3, "15-40")]
        [TestCase(2, 1, "30-15")]
        [TestCase(2, 3, "30-40")]
        [TestCase(3, 2, "40-30")]
        [TestCase(3, 1, "40-15")]
        [Category("Normal Score")]
        public void GivenPlayerOneScoredAndOrPlayerTwoScored_WhenScoreIsLoveLove_ThenScoreShouldBeCorrect(int player1Score, int player2Score, string expected)
        {
            // Arrange
            AddScores(player1Score, player2Score);

            // Act
            var actual = _sut.PrintScore();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(3, 3, "Deuce")]
        [Category("Deuce Score")]
        public void GivenPlayerOneScoredThreeTimesAndPlayerTwoScoredTreeTimes_WhenScoreIsLoveLove_ThenScoreShouldBeDeuce(int player1Score, int player2Score, string expected)
        {
            // Arrange
            AddScores(player1Score, player2Score);

            // Act
            var actual = _sut.PrintScore();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(4, 3, "Advantage Player1")]
        [TestCase(5, 4, "Advantage Player1")]
        [TestCase(6, 5, "Advantage Player1")]
        [TestCase(7, 6, "Advantage Player1")]
        [TestCase(3, 4, "Advantage Player2")]
        [TestCase(4, 5, "Advantage Player2")]
        [TestCase(5, 6, "Advantage Player2")]
        [TestCase(6, 7, "Advantage Player2")]
        [Category("Advantage Score")]
        public void GivenPlayerOneScoredOrPlayerTwoScored_WhenScoreIsDeuce_ThenScoreShouldBeAdvantagePlayerName(int player1Score, int player2Score, string expected)
        {
            // Arrange
            AddScores(player1Score, player2Score);

            // Act
            var actual = _sut.PrintScore();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(4, 4, "Deuce")]
        [TestCase(5, 5, "Deuce")]
        [TestCase(6, 6, "Deuce")]
        [TestCase(7, 7, "Deuce")]
        [Category("Deuce Score")]
        public void GivenPlayerOneScoredOrPlayerTwoScored_WhenScoreIsAdvantage_ThenScoreShouldBeDeuce(int player1Score, int player2Score, string expected)
        {
            // Arrange
            AddScores(player1Score, player2Score);

            // Act
            var actual = _sut.PrintScore();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(4, 0, "Player1 Wins")]
        [TestCase(4, 1, "Player1 Wins")]
        [TestCase(4, 2, "Player1 Wins")]
        [TestCase(0, 4, "Player2 Wins")]
        [TestCase(1, 4, "Player2 Wins")]
        [TestCase(2, 4, "Player2 Wins")]
        [Category("Win Score")]
        public void GivenPlayerOneScoredOrPlayerTwoScored_WhenScoreIsNotAdvantageOrNotDeuceAndWillWin_ThenScoreShouldBeWinPlayerName(int player1Score, int player2Score, string expected)
        {
            // Arrange
            AddScores(player1Score, player2Score);

            // Act
            var actual = _sut.PrintScore();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(5, 3, "Player1 Wins")]
        [TestCase(6, 4, "Player1 Wins")]
        [TestCase(7, 5, "Player1 Wins")]
        [TestCase(3, 5, "Player2 Wins")]
        [TestCase(4, 6, "Player2 Wins")]
        [TestCase(5, 7, "Player2 Wins")]
        [Category("Win Score")]
        public void GivenPlayerOneScoredOrPlayerTwoScored_WhenScoreIsAdvantageAndWillWin_ThenScoreShouldBeWinPlayerName(int player1Score, int player2Score, string expected)
        {
            // Arrange
            AddScores(player1Score, player2Score);

            // Act
            var actual = _sut.PrintScore();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(6, 3, "Invalid Score")]
        [TestCase(3, 6, "Invalid Score")]
        [TestCase(7, 4, "Invalid Score")]
        [TestCase(4, 7, "Invalid Score")]
        [TestCase(10,1, "Invalid Score")]
        [TestCase(1, 10, "Invalid Score")]
        [Category("Invalid Score")]
        public void GivenPlayerOneScoredOrPlayerTwoScored_WhenScoreIsInvalid_ThenScoreShouldBeInvalidScore(int player1Score, int player2Score, string expected)
        {
            // Arrange
            AddScores(player1Score, player2Score);

            // Act
            var actual = _sut.PrintScore();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

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
        public void GivenPlayerOneScoredAndOrPlayerTwoScored_WhenScoreIsLoveLove_ThenScoreShouldBeCorrect(int player1Score, int player2Score, string expected)
        {
            // Arrange
            for (int i = 0; i < player1Score; i++)
            {
                _sut.Player1Scored();
            }
            for (int i = 0; i < player2Score; i++)
            {
                _sut.Player2Scored();
            }

            // Act
            var actual = _sut.PrintScore();

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

       
    }
}

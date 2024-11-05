using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Tennis
{
    public class TennisGame
    {
        private readonly string _player1Name;
        private readonly string _player2Name;
        private int _player1Score;
        private int _player2Score;


        public TennisGame(string player1Name, string player2Name)
        {
            _player1Name = player1Name;
            _player2Name = player2Name;
            _player1Score = 0;
            _player2Score = 0;
        }

        public string PrintScore()
        {
            return "Fifteen-Love";
        }
    }
}

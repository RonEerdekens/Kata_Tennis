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
        public void Player1Scored()
        {
            _player1Score++;
        }
        public void Player2Scored()
        {
            _player2Score++;
        }

        public string PrintScore()
        {
            if (IsInvalidScore())
            {
                return "Invalid Score";
            }
            if (IsWon())
            {
                return $"{(_player1Score > _player2Score ? _player1Name : _player2Name)} Wins";
            }
            if (IsAdvantage())
            {
                return $"Advantage {(_player1Score > _player2Score ? _player1Name : _player2Name)}";
            }
            if (IsDeuce())
            {
                return "Deuce";
            }

            return $"{ScoreToString(_player1Score)}-{ScoreToString(_player2Score)}";
        }

        private bool IsDeuce()
        {
            return _player1Score >= 3 && _player2Score >= 3 && _player1Score == _player2Score;
        }
        private bool IsAdvantage()
        {
            if (_player1Score >= 3 && _player2Score >= 3 && _player1Score > _player2Score)
            {
                return _player1Score - _player2Score == 1;
            }
            if (_player1Score >= 3 && _player2Score >= 3 && _player1Score < _player2Score)
            {
                return _player2Score - _player1Score == 1;
            }
            return false;
        }
        private bool IsWon()
        {
            if (_player1Score >= 4 && _player1Score - _player2Score >= 2)
            {
                return true;
            }
            if (_player2Score >= 4 && _player2Score - _player1Score >= 2)
            {
                return true;
            }

            return false;
        }
        private bool IsInvalidScore()
        {
            if((_player1Score - _player2Score) >= 3 || (_player2Score - _player1Score) >= 3)
            {
                if ((_player1Score <= 4 && _player2Score >= 5) || (_player2Score <= 4 && _player1Score >= 5))
                {
                    return true;
                }
                if(_player1Score >= 5 || _player2Score >= 5)
                {
                    return true;
                }
            }

            return false;
        }

        public bool GameOver()
        {
            return IsWon();
        }

        private string ScoreToString(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love";
                case 1:
                    return "15";
                case 2:
                    return "30";
                case 3:
                    return "40";
                default:
                    return "Invalid score";
            }
        }
    }
}

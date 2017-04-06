using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dactylo9
{
    public class Game
    {
        private string _playerName;
        private string _gameDuration;
        private string _goalText;

        private int _mistakes;
        private DateTime _startTime;
        private int _successfullCharacters;
        private bool _gameHasStarted;
        public string GoalText
        {
            get { return _goalText; }
            set { _goalText = value; }
        }
        public int SuccessfullCharacters
        {
            get { return _successfullCharacters; }
            set { _successfullCharacters = value; }
        }
        public int Mistakes
        {
            get { return _mistakes; }
            set { _mistakes = value; }
        }
        public string PlayerName
        {
            get { return _playerName; }
            set { _playerName = value; }
        }
        public string GameDuration
        {
            get { return _gameDuration; }
            set { _gameDuration = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="textToWrite">The text the user should write to complete the game</param>
        public Game(string textToWrite)
        {
            this.GoalText = textToWrite;
            this._gameHasStarted = false;
        }

        public void StartGame()
        {
            if (!this._gameHasStarted)
            {
                _startTime = DateTime.Now;
                this._gameHasStarted = true;
            }
        }

        public void AddPlayer(string playerName)
        {
            this.PlayerName = playerName;
        }
        public void AddMistake()
        {
            this.Mistakes += 1;
        }
        public void AddSuccessfullCharacter()
        {
            this.SuccessfullCharacters += 1;
        }
        public double GetElapsedTime()
        {
            if (this._gameHasStarted)
            {
                double elapsedTime = (DateTime.Now - this._startTime).TotalSeconds;
                return elapsedTime;
            }
            else
            {
                return 0;
            }
        }
        public bool IsFinished()
        {
            if (this.GoalText.Length == this.SuccessfullCharacters)
            {
                this.GameDuration = Math.Round(GetElapsedTime()).ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

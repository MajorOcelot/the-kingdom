using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKingdom
{
    internal class PlayerCharacter
    {
        private string _playerName;
        private string _playerRace;
        private string _playerClass;
        private string _playerGender;
        private int _playerAge;

        public PlayerCharacter() 
        {
            _playerName = PlayerName;
            _playerRace = PlayerRace;
            _playerClass = PlayerClass;
            _playerGender = PlayerGender;
            _playerAge = PlayerAge;
        }

        public string PlayerName { get { return _playerName; } set { _playerName = value; } }

        public string PlayerRace { get { return _playerRace; } set { _playerRace = value; } }

        public string PlayerClass { get { return _playerClass; } set { _playerClass = value; } }

        public string PlayerGender { get { return _playerGender; } set { _playerGender = value; } }

        public int PlayerAge { get { return _playerAge; } set { _playerAge = value; } }
    }
}

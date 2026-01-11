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

        private int _playerHealth = 75;
        private int _playerMana = 25;

        public PlayerCharacter() 
        {
            _playerName = PlayerName;
            _playerRace = PlayerRace;
            _playerClass = PlayerClass;
            _playerGender = PlayerGender;
            _playerAge = PlayerAge;
            _playerHealth = PlayerHealth;
            _playerMana = PlayerMana;
        }

        public string PlayerName { get { return _playerName; } set { _playerName = value; } }

        public string PlayerRace { get { return _playerRace; } set { _playerRace = value; } }

        public string PlayerClass { get { return _playerClass; } set { _playerClass = value; } }

        public string PlayerGender { get { return _playerGender; } set { _playerGender = value; } }

        public int PlayerAge { get { return _playerAge; } set { _playerAge = value; } }

        public int PlayerHealth { get { return _playerHealth; } set { _playerHealth = value; } }

        public int PlayerMana { get { return _playerMana; } set { _playerMana = value; } }
    }
}

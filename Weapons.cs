using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKingdom
{
    internal class Weapons
    {
        private WeaponType _weapon;

        public Weapons()
        {
            _weapon = (WeaponType)Weapon;
        }

        public int Weapon { get { return (int)_weapon; } set { _weapon = (WeaponType)value; } }

        enum WeaponType
        {
            Dagger = 0,
            SwordShield = 1,
            Mace = 2,
            TwoHandedSword = 3,
            Staff = 4,
            Wand = 5,
            Tomebook = 6,
            BrassKnuckles = 7
        }
    }
}

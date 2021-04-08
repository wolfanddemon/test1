using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1.Equipment.Weapon;
using ClassLibrary1.Equipment.Armor;

namespace ClassLibrary1
{
    public class Player
    {
        private IWeapon _weapon;
        private IArmor _armor;

        private static Player _player;
        private Player()
        {
        }
        public static Player GetPlayer()
        {
            if(_player == null)
            {
                _player = new Player();
            }
            return _player;
        }

    }
}

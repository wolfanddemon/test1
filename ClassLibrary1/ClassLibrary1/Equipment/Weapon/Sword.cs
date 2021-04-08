using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Equipment.Weapon
{
    public class Sword:IWeapon
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int AttackSpeed { get; set; }
        public int AttackDistance { get; set; }
        public WeaponSkill[] WeaponSkills { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Equipment.Weapon
{
    public enum WeaponSkill
    {
        DoubleAttack = 0
    }

    interface IWeapon
    {
        string Name { get; set; }
        int Attack { get; set; }
        int AttackSpeed { get; set; }
        int AttackDistance { get; set; }
        WeaponSkill[] WeaponSkills { get; set; }
    }
}

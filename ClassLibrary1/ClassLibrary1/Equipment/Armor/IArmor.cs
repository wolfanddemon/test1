using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Equipment.Armor
{
    public enum ArmorSkill
    {
        PhysicalDefenseUp = 0
    }

    interface IArmor
    {
        string Name { get; set; }
        int PhysicalDefense { get; set; }
        int MagicalDefense { get; set; }
        ArmorSkill[] ArmorSkills { get; set; }
    }
}

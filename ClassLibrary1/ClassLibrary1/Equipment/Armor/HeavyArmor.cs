using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Equipment.Armor
{
    public class HeavyArmor:IArmor
    {
        public string Name { get; set; }
        public int PhysicalDefense { get; set; }
        public int MagicalDefense { get; set; }
        public ArmorSkill[] ArmorSkills { get; set; }
    }
}

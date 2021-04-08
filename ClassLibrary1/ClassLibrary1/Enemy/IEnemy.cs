using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Enemy
{
    interface IEnemy
    {
        int Hp { get; set; }
        int Mp { get; set; }
        int Attack { get; set; }
        int PhysicalDefense { get; set; }
        int MagicalDefense { get; set; }
        int Speed { get; set; }
    }
}

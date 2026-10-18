using System;
using System.Collections.Generic;
using System.Text;

namespace CombatRobot
{
    internal interface IRepairable
    {
        public void Repair(int amount);
        public int GetArmorStatus();
    }
}

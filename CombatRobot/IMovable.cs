using System;
using System.Collections.Generic;
using System.Text;

namespace CombatRobot
{
    internal interface IMovable
    {
        public void Move(int x, int y);
        public void GetCurrentSpeed();
    }
}

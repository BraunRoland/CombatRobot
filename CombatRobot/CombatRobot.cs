using System;
using System.Collections.Generic;
using System.Text;

namespace CombatRobot
{
    internal class CombatRobot : IRepairable, IMovable
    {
        private int x;
        private int y;
        private int speed;
        private int armor;

        public CombatRobot(int x, int y, int armor)
        {
            this.x = x;
            this.y = y;
            this.armor = armor;
            this.speed = 0;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Armor { get => armor; set => armor = value; }
        public int Speed { get => speed; set => speed = value; }

        public int GetArmorStatus()
        {
            return this.Armor;
        }

        public void GetCurrentSpeed()
        {
            Console.WriteLine($"A robot gyorsasága: {this.Speed} km/h");
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Repair(int amount)
        {
            this.Armor += amount;
        }
    }
}

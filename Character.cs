using System;
using PA4_laineykersey;
using PA4_laineykersey.Interfaces;

namespace PA4_laineykersey
{
    public class Character
    {
        public Character(string playerName, string charName, int maxPower, double health, int attackStrength, int defensePower, IAttack attackBehavior, IDefend defendBehavior)
        {
            this.PlayerName = playerName;
            this.CharName = charName;
            this.MaxPower = maxPower;
            this.Health = health;
            this.AttackStrength = attackStrength;
            this.DefensePower = defensePower;
            this.attackBehavior = attackBehavior;
            this.defendBehavior = defendBehavior;

        }
        public Character()
        {

        }
        public string PlayerName { get; set; }
        public string CharName { get; set; }
        public int MaxPower { get; set; }
        public double Health { get; set; }
        public int AttackStrength { get; set; }
        public int DefensePower { get; set; }
        public IAttack attackBehavior { get; set; }
        public IDefend defendBehavior { get; set; }
        
        public int RandMax()
        {
            Random r = new Random();
            MaxPower = r.Next(1, 100);
            return MaxPower;
        }
        public int RandAttackStrength()
        {
            Random r = new Random();
            AttackStrength = r.Next(1, MaxPower);
            return AttackStrength;
        }
        public int RandDefensePower()
        {
            Random r = new Random();
            DefensePower = r.Next(1, MaxPower);
            return DefensePower;

        }
        public void Stats()
        {
            System.Console.WriteLine($"{CharName} Stats:");
            System.Console.WriteLine("---------------------");
            System.Console.WriteLine($"Health: {Health}");
            System.Console.WriteLine($"Max Power: {MaxPower}");
            System.Console.WriteLine($"AttackStrength: {AttackStrength}");
            System.Console.WriteLine($"Defensive Power: {DefensePower}");
        }
    }
}
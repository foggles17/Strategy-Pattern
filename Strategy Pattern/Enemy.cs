using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Enemy
    {
        public int type;
        public int health;
        public int maxHealth;
        public int level;

        public const int ROCK = 0;
        public const int PAPER = 1;
        public const int SCISSORS = 2;
        Random generator = new Random();
        public Enemy(int round)
        {
            level = round;
            maxHealth = level * 10;
            health = maxHealth;
            type = generator.Next(3);
        }
        public Enemy(int round, int type) : this(round)
        {
            type = generator.Next(3);
        }
        public string attack(Fighter foe)
        {
            foe.health -= (level) * typeMultiplier(foe);
            if (foe.health < 0)
            {
                foe.health = 0;
                foe.magic = 0;
            }
            return "";
        }
        public int typeMultiplier(Fighter foe)
        {
            if (this.type == foe.type)
            {
                return 2;
            }
            if (this.type == (foe.type + 1) % 3)
            {
                return 4;
            }
            else
            {
                return 1;
            }
        }
        public bool isDead()
        {
            return (health == 0);
        }
        public string typeToString()
        {
            switch (type)
            {
                case 0:
                    return "Rock";
                case 1:
                    return "Paper";
                case 2:
                    return "Scissors";
                default:
                    return "Enemy";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Fighter
    {
        public Form1 environment;
        public int type;
        public int level;
        public int maxHealth;
        public int health;
        public int magic;
        public int magicRegenRate;

        public const int ROCK = 0;
        public const int PAPER = 1;
        public const int SCISSORS = 2;

        public readonly string[] attackNames = 
            { "Pebble Throw", "Boulder Drop", "Cover", "Intense Cover", "Snip", "Sever" };

        public string attackName;

        public Fighter(int type)
        {
            this.type = type;
            level = 1;
            maxHealth = 10 * level + 10;
            health = maxHealth;
            magic = 15;
            magicRegenRate = 5;
            attackName = "";
        }

        public bool isDead()
        {
            return (health == 0);
        }

        public override string ToString()
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
                    return "Fighter";
            }
        }
        public void levelUp()
        {
            level++;
            maxHealth = 10 * level + 10;
            health = maxHealth;
        }
        public string goToNextTurn()
        {
            int healthRegained = 0;
            if(!isDead())
            {
                health += level;
                healthRegained = level;
                if (health > maxHealth)
                {
                    healthRegained = (maxHealth - (health - healthRegained));
                    health = maxHealth;
                }
                magic += magicRegenRate;
            }

            return this + " regained "+healthRegained +" health and generated " + magicRegenRate + " magic.";
        }
        public int typeMultiplier(Enemy foe)
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
        public void weakAttack(Enemy foe)
        {
            attackName = attackNames[type * 2];
            foe.health -= level * typeMultiplier(foe);
            if (foe.health < 0)
                foe.health = 0;
            magic -= 10;
        }
        public void strongAttack(Enemy foe)
        {
            attackName = attackNames[type * 2 + 1];
            foe.health -= level * typeMultiplier(foe) * 2;
            if (foe.health < 0)
                foe.health = 0;
            magic -= 20;
        }
    }
}

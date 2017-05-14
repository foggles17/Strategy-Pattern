using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy_Pattern
{
    public partial class Form1 : Form
    {
        public Enemy currentEnemy;
        public Fighter currentFighter;
        public Fighter rockFighter;
        public Fighter paperFighter;
        public Fighter scissorsFighter;
        int round;
        public Form1()
        {
            InitializeComponent();
            round = 1;
            currentEnemy = new Enemy(round);
            rockFighter = new Fighter(Fighter.ROCK);
            paperFighter = new Fighter(Fighter.PAPER);
            scissorsFighter = new Fighter(Fighter.SCISSORS);
            currentFighter = rockFighter;
            fighterComboBox.Items.Add(rockFighter);
            fighterComboBox.Items.Add(paperFighter);
            fighterComboBox.Items.Add(scissorsFighter);
            round = 1;
            updateLabels();
            addText("Welcome to the game.\n");
            addText(enemyText());
        }
        private void addText(string text)
        {
            outputTextBox.AppendText(text + "\n");
            outputTextBox.ScrollToCaret();
        }
        private string enemyText()
        {
            return "There is a " + currentEnemy.typeToString() +" type enemy with " 
                + currentEnemy.health + "/" + currentEnemy.maxHealth + " health.";
        }
        private void updateLabels()
        {
            rockLevelLabel.Text = "" + rockFighter.level;
            paperLevelLabel.Text = "" + paperFighter.level;
            scissorsLevelLabel.Text = "" + scissorsFighter.level;

            rockHealthLabel.Text = "" + rockFighter.health + "/" + rockFighter.maxHealth;
            paperHealthLabel.Text = "" + paperFighter.health + "/" + paperFighter.maxHealth;
            scissorsHealthLabel.Text = "" + scissorsFighter.health + "/" + scissorsFighter.maxHealth;

            rockMagicLabel.Text = "" + rockFighter.magic;
            paperMagicLabel.Text = "" + paperFighter.magic;
            scissorsMagicLabel.Text = "" + scissorsFighter.magic;
        }

        private void weakAttackButton_Click(object sender, EventArgs e)
        {
            if (fighterComboBox.SelectedItem != null)
            {
                currentFighter = (Fighter)fighterComboBox.SelectedItem;
                if (!currentFighter.isDead())
                {
                    if (currentFighter.magic >= 10)
                    {
                        attack(false);
                    }
                    else
                    {
                        addText(currentFighter + "has too little magic!");
                    }
                }
                else
                {
                    addText(currentFighter + " is dead!");
                }
            }
        }

        private void strongAttackButton_Click(object sender, EventArgs e)
        {
            if (fighterComboBox.SelectedItem != null)
            {
                currentFighter = (Fighter)fighterComboBox.SelectedItem;
                if (!currentFighter.isDead())
                {
                    if (currentFighter.magic >= 20)
                    {
                        attack(true);
                    }
                    else
                    {
                        addText(currentFighter + " has too little magic!");
                    }
                }
                else
                {
                    addText(currentFighter + " is dead!");
                }
            }
        }

        private void autoButton_Click(object sender, EventArgs e)
        {
            Strategy myStrat;

            int rockDamage = 0;
            bool rockStrong = false;
            if(!rockFighter.isDead())
            {
                if(rockFighter.magic >= 20)
                {
                    rockDamage = rockFighter.level * rockFighter.typeMultiplier(currentEnemy) * 2;
                    if (rockDamage < 2 * currentEnemy.health)
                    {
                        rockStrong = true;
                    }
                    else
                    {
                        rockDamage /= 2;
                    }
                }
                else if(rockFighter.magic >= 10)
                {
                    rockDamage = rockFighter.level * rockFighter.typeMultiplier(currentEnemy) * 1;
                }
            }

            int paperDamage = 0;
            bool paperStrong = false;
            if (!paperFighter.isDead())
            {
                if (paperFighter.magic >= 20)
                {
                    paperDamage = paperFighter.level * paperFighter.typeMultiplier(currentEnemy) * 2;
                    if (paperDamage < 2 * currentEnemy.health)
                    {
                        paperStrong = true;
                    }
                    else
                    {
                        paperDamage /= 2;
                    }
                }
                else if (paperFighter.magic >= 10)
                {
                    paperDamage = paperFighter.level * paperFighter.typeMultiplier(currentEnemy) * 1;
                }
            }

            int scissorsDamage = 0;
            bool scissorsStrong = false;
            if (!scissorsFighter.isDead())
            {
                if (scissorsFighter.magic >= 20)
                {
                    scissorsDamage = scissorsFighter.level * scissorsFighter.typeMultiplier(currentEnemy) * 2;
                    if (scissorsDamage < 2 * currentEnemy.health)
                    {
                        scissorsStrong = true;
                    }
                    else
                    {
                        scissorsDamage /= 2;
                    }
                }
                else if (scissorsFighter.magic >= 10)
                {
                    scissorsDamage = scissorsFighter.level * scissorsFighter.typeMultiplier(currentEnemy) * 1;
                }
            }
            myStrat = new DoNothingStrategy(this);
            if (!(rockDamage == 0 && paperDamage == 0 && scissorsDamage == 0))
            {
                if (rockDamage >= paperDamage && rockDamage >= scissorsDamage)
                {
                    if (rockStrong)
                        myStrat = new StrongRockStrategy(this);
                    else
                        myStrat = new WeakRockStrategy(this);
                }
                else if (paperDamage >= scissorsDamage)
                {
                    if (paperStrong)
                        myStrat = new StrongPaperStrategy(this);
                    else
                        myStrat = new WeakPaperStrategy(this);
                }
                else
                {
                    if (scissorsStrong)
                        myStrat = new StrongScissorsStrategy(this);
                    else
                        myStrat = new WeakScissorsStrategy(this);
                }
            }
            myStrat.enact();
        }
        public void doNothing()
        {
            if(currentFighter.isDead())
            {
                if (!rockFighter.isDead())
                    currentFighter = rockFighter;
                else if (!paperFighter.isDead())
                    currentFighter = paperFighter;
                else if (!scissorsFighter.isDead())
                    currentFighter = scissorsFighter;
            }
            enemyTurn();
            if (rockFighter.isDead() && paperFighter.isDead() && scissorsFighter.isDead())
            {
                addText("All of your fighters are dead.");
                addText("");
                addText("You made it to round " + round + ".");
                weakAttackButton.Enabled = false;
                strongAttackButton.Enabled = false;
                doNothingButton.Enabled = false;
                fighterComboBox.Enabled = false;
            }
            else
            {
                addText("");
                addText(rockFighter.goToNextTurn());
                addText(paperFighter.goToNextTurn());
                addText(scissorsFighter.goToNextTurn());
                updateLabels();
            }
        }
        public void attack(bool strong)
        {
            if (strong)
                currentFighter.strongAttack(currentEnemy);
            else
                currentFighter.weakAttack(currentEnemy);
            addText(currentFighter + " used " + currentFighter.attackName + ".");
            if(currentFighter.typeMultiplier(currentEnemy) == 1)
            {
                addText("It wasn't very effective.");
            }
            else if (currentFighter.typeMultiplier(currentEnemy) == 4)
            {
                addText("It was super effective!");
            }
            addText("Reduced the enemy's health to " + currentEnemy.health + "/" + currentEnemy.maxHealth + ".");
            if (currentEnemy.isDead())
            {
                currentFighter.levelUp();
                addText(currentFighter + " defeated the enemy and leveled up to level " + currentFighter.level + "!");
                round++;
                addText("");
                addText("ROUND " + round);
                addText("");
                currentEnemy = new Enemy(round);
                addText(enemyText());
            }
            else
            {
                addText("");
                enemyTurn();
            }
            if (rockFighter.isDead() && paperFighter.isDead() && scissorsFighter.isDead())
            {
                addText("All of your fighters are dead.");
                addText("");
                addText("You made it to round " + round + ".");
                weakAttackButton.Enabled = false;
                strongAttackButton.Enabled = false;
                doNothingButton.Enabled = false;
                fighterComboBox.Enabled = false;
            }
            else
            {
                addText("");
                addText(rockFighter.goToNextTurn());
                addText(paperFighter.goToNextTurn());
                addText(scissorsFighter.goToNextTurn());
                updateLabels();
            }
        }
        private void enemyTurn()
        {
            currentEnemy.attack(currentFighter);
            addText("The enemy attacked your fighter, leaving it at " + currentFighter.health + "/" + currentFighter.maxHealth + " health.");
            if (currentFighter.isDead())
            {
                addText(currentFighter + " died!");
            }
        }
        private void doNothingButton_Click(object sender, EventArgs e)
        {
            doNothing();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPt1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character Hero = new Character();
            Character Monster = new Character();

            Hero.Name = "Hiro";
            Hero.Health = 100;
            Hero.DamageMaximum = 25;
            Hero.AttackBonus = true;

            Monster.Name = "Gort";
            Monster.Health = 85;
            Monster.DamageMaximum = 20;
            Monster.AttackBonus = false;

            Dice dice = new Dice();


            while (Hero.Health > 0 && Monster.Health > 0)
            {
                int monsterDamage = Monster.Attack(dice);
                int heroRemainingHealth = Hero.Defend(monsterDamage);

                resultLabel.Text += String.Format("{0} attacks {1} for {2} damage, leaving him with {3} health!<br /><br />", Monster.Name, Hero.Name, monsterDamage, heroRemainingHealth);

                int heroDamage = Hero.Attack(dice);
                int monsterRemainingHealth = Monster.Defend(heroDamage);

                resultLabel.Text += String.Format("Battle continues, {0} strikes {1} for {2} damage, leaving him with {3} health!<br /><br />", Hero.Name, Monster.Name, heroDamage, monsterRemainingHealth);

            }

            displayResult(Hero, Monster);
            
        }


        
        public void displayResult(Character opponenent1, Character opponent2)
        {
            if (opponenent1.Health > 0 && opponent2.Health < 0)
            resultLabel.Text += String.Format("The winner is {0} having vanquished {1}!", opponenent1.Name, opponent2.Name);
            else if (opponent2.Health > 0 && opponenent1.Health < 0)
            resultLabel.Text += String.Format("The winner is {0} having vanquished {1}", opponent2.Name, opponenent1.Name);
            else
            resultLabel.Text += "They both died!";
        }


        public class Character
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMaximum { get; set; }
            public bool AttackBonus { get; set; }

            

            public int Attack(Dice dice)
            {
                dice.Sides = this.DamageMaximum;

                int inflictedDamage = dice.Roll();
                return inflictedDamage;
            }

            public int Defend(int inflictedDamage)
            {
                this.Health -= inflictedDamage;

                return Health;
            }
        }


        public class Dice
        {
            Random random = new Random();
            public int Sides { get; set; }

            public int Roll()
            {
                int roll = random.Next(1, Sides);
                return roll;
            }

        }
    }
}
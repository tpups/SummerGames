using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Threading;

namespace SummerGames.Models
{
    public class Orc : Enemies
    {   
        public Orc()
        {
            name = "Orc";
            strength = 10;
            health = 200;
            healthMax = 200;
        }
        public int RandomOrcAttack(Player name1)
        {
            Random rand = new Random();
            int attack = rand.Next(1,6);
            if(attack == 1)
            {
                this.Attack(name1);
            }
            if(attack == 2)
            {
                this.Club_Bash(name1);
            }
            if(attack == 3)
            {
                this.Attack(name1);
            }
            if(attack == 4)
            {
                this.Attack(name1);
            }
            if(attack == 5)
            {
                this.Attack(name1);
            }
            return attack;
        }
        public int Attack(Player name1)
        {
            Random rand = new Random();
            int attack = rand.Next(1 * strength, 3 * strength);
            name1.health = name1.health - attack;
            return attack;
        }
        public int Club_Bash(Player name1)
        {
            Random rand = new Random();
            int club_bash = rand.Next(7 * strength, 10 * strength);
            name1.health = name1.health - club_bash;
            return club_bash;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur_Project
{
    internal class Dinosaur
    {
        //member variables
        public string name;
        public int health;
        public int attackPower;
        
        //constructor
        public Dinosaur (string name, int health, int attackPower)
        {
            this.name = name;
            this.health = health;
            this.attackPower = attackPower;
            
        }

        //member methods

       public void attack (Robot robotToAttack)
        {
            robotToAttack.health -= attackPower;
        }
    }
}

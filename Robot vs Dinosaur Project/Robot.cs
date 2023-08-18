using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur_Project
{
    internal class Robot
    {
        //member variables
        public string name;
        public int health;
        public Weapon activeWeapon;

        //constructor
        public Robot (string name, int health)
        {
            
            activeWeapon = new Weapon();
            this.health = health;
            this.name = name;
        }

        //member method

        public void attack(Dinosaur dinosaurToAttack)
        {
            dinosaurToAttack.health -= activeWeapon.attackPower;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_vs_Dinosaur_Project
{
    internal class Weapon
    {
        //member variables
        public string activeWeapon;
        public int attackPower;

        //constructor
        public Weapon ()
        {
            activeWeapon = "Spear";
            attackPower = 15;
        }

    }
}

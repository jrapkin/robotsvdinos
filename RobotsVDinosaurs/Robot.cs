using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    class Robot
    {
        //member Variables AKA Class Properties (HAS A)
        public string Name;
        public int Health;
        public int PowerLevel;
        Weapon weapon;
        public int AttackPower;
        

        // Constructor (SPAWNER)
        public Robot(string robotName)
        {
            Name = robotName;
            Health = 100;
            PowerLevel = 100;
            AttackPower = 5;

        }

        // Member Methods (CAN DO)
        public void Equip(Weapon newFoundWeapon)
        {
            weapon = newFoundWeapon;
            AttackPower += newFoundWeapon.AttackPower;
        }

        // a robot attacks

        public void Attack()
        {

        }
        //and takes damage
        public void TakeDamage()
        {

        }
    }
}

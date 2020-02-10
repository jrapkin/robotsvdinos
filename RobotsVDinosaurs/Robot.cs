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
        public Weapon weapon;
        public int AttackPower;
        public int WeaponAttackPower;
        

        // Constructor (SPAWNER)
        public Robot()
        {
            Name = "Test Robot";
            Health = 100;
            PowerLevel = 100;
            AttackPower = 5;
            Equip();
        }

        // Member Methods (CAN DO)
        public void Equip()
        {
            weapon =  new Weapon(20);
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

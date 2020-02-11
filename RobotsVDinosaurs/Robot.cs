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
        //public int WeaponAttackPower;
        // public Battlefield Battlefield;

        // Constructor (SPAWNER)
        public Robot(string name)
        {
            Name = name;
            Health = 100;
            PowerLevel = 100;
            AttackPower = 10;
            //WeaponAttackPower = 0;
        }



        // Member Methods (CAN DO)
        public void Equip(Weapon weapon)
        {
            this.weapon = weapon;

        }

        // a robot attacks


    }
}

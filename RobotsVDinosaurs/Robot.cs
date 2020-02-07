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
        string name;
        int health;
        int powerLevel;
        Weapon weapon;  

        // Constructor (SPAWNER)
        public Robot(string name)
        {
            this.name = name;
            health = 100;
            powerLevel = 100;
            weapon = new Weapon();

        }

        // Member Methods (CAN DO)

        public string InitializeRobot()
        {
          
            Console.WriteLine("A wild robot named " + name + " has appeared!");
            Console.WriteLine(name + " is searching for a weapon...");
            Console.WriteLine(name + " has found a sword, an axe, and a plasma cannon! Which should it choose?");

            string selectedWeaponType = Console.ReadLine();

            return selectedWeaponType;
        }
    }
}

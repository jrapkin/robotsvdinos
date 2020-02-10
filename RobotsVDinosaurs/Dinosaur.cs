using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    class Dinosaur
    {        
        //member Variables (HAS A)
        public string Name;
        public int Health;
        public int Energy;
        public int AttackPower;
        string type = "T-Rex";

        // Constructor (SPAWNER)
        public Dinosaur()
        {
            Name = "Test Dino";
            Health = 100;
            Energy = 100;
            AttackPower = 5;
            //type = type;
        } 

        // Member Methods (CAN DO)


    }
}

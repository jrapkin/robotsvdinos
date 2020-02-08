using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    class Battlefield
    {

        //member Variables AKA Class Properties (HAS A)
        List<Robot> fleet;
        // Constructor (SPAWNER)
        public Battlefield()
        {
            fleet = new List<Robot>();

        }
        // Member Methods (CAN DO)
        //dinosaurs and robots spawn
        public void SpawnRobot()
        {
            Robot spawnedRobot = new Robot();
            fleet.Add(spawnedRobot);
        }

        public void FillFactionTeam()
        {
            for (int i = 0; i < 3; i++)
            {
                SpawnRobot();
            }
        }
    }
}

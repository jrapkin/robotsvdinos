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
        public List<Robot> Fleet;
        public List<Dinosaur> Herd;
        public List<Weapon> Weapons;
        // Constructor (SPAWNER)
        public Battlefield()
        {
            Fleet = new List<Robot>();
            Herd = new List<Dinosaur>();
            FillFactionTeam();
        }
        // Member Methods (CAN DO)
        //dinosaurs and robots spawn
        public void SpawnRobot()
        {
            Robot spawnedRobot = new Robot();
            Fleet.Add(spawnedRobot);
        }
        public void SpawnDinosaur()
        {
            Dinosaur spawnedDinosaur = new Dinosaur();
            Herd.Add(spawnedDinosaur);
        }

        public void FillFactionTeam()
        {
            for (int i = 0; i < 3; i++)
            {
                SpawnRobot();
                SpawnDinosaur();
            }
        }

    }
}

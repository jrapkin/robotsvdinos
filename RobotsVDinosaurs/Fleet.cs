using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
	class Fleet
	{
		//Member Variables
		public List<Robot> FleetOfRobots;


		public Fleet()
		{
			FleetOfRobots = new List<Robot>();
			SpawnRobot();

		}
		//methods
		public void SpawnRobot()
		{
			Robot optimusPrime = new Robot("OptimusPrime");
			FleetOfRobots.Add(optimusPrime);

			Robot ironGiant = new Robot("The Iron Giant");
			FleetOfRobots.Add(ironGiant);

			Robot voltron = new Robot("Voltron");
			FleetOfRobots.Add(voltron);
		}
	}
}

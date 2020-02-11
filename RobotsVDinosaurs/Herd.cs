using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
	class Herd
	{
		//Member Variables
		public List<Dinosaur> HerdOfDinosaurs;

		public Herd()
		{
			HerdOfDinosaurs = new List<Dinosaur>();
			SpawnDinosaur();
		}
		//methods
		public void SpawnDinosaur()
		{
			Dinosaur tRex = new Dinosaur("Louie");
			HerdOfDinosaurs.Add(tRex);

			Dinosaur stegasaurus = new Dinosaur("RubberDuckie");
			HerdOfDinosaurs.Add(stegasaurus);

			Dinosaur velociraptor = new Dinosaur("Raptor");
			HerdOfDinosaurs.Add(velociraptor);
		
		}
	}
}

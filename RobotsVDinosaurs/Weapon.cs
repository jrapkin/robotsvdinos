using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    class Weapon
    {
        //member Variables AKA Class Properties (HAS A)
        public string weaponType;
        public int attackPower;
        

        // Constructor (SPAWNER)
        public Weapon()
        {
            /*weaponType = UserWeaponSelection();
            attackPower = SetAttackPower();*/
        }
        // Member Methods (CAN DO)

        /*private string UserWeaponSelection()
        {
        }*/


        //a list of weapons
        List<string> listOfWeapons = new List<string>();


        

    }
}

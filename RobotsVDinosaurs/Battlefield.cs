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
        public List<Weapon> BattlefieldWeapons;
        public Weapon Weapon;
        public Fleet Fleet;
        public Herd Herd;
        // public Game Game;

        // Constructor (SPAWNER)
        public Battlefield()
        {
            BattlefieldWeapons = new List<Weapon>();
            Fleet = new Fleet();
            Herd = new Herd();
            // Game = new Game();
        }
        // Member Methods (CAN DO)
        public void RobotAttackTurn()
        {
            for (int i = 0; i < (Fleet.FleetOfRobots.Count); i++)
            {
                string userInput = TakeUserInput();//this else statement will skip a turn
                int attacker = 0;
                if (Fleet.FleetOfRobots[i].Health >= 0)
                {
                    //robot's turn to attack

                    if (userInput == "attack")
                    {
                        attacker = 0;
                        int attackingParty = 0;
                        int attackedParty = 0;
                        int damageDealt = 0;
                        SearchForWeapon();
                        damageDealt = CalculateAttackDamage(Fleet.FleetOfRobots[attackingParty].AttackPower, Fleet.FleetOfRobots[attackingParty].weapon.AttackPower);
                        DealAttackDamage(attacker, attackedParty, damageDealt);
                        Console.WriteLine($"{Fleet.FleetOfRobots[0].Name} dealt {damageDealt} to {Herd.HerdOfDinosaurs[0].Name}.");
                        break;
                    }
                    else if (userInput == "retreat")
                    {
                        Console.WriteLine("You live to fight another day, you sissy.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid selection");
                    }
                }
                else
                {
                    Fleet.FleetOfRobots.RemoveAt(i);
                }


            }
        }
        public string TakeUserInput()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }


        public void DinosaurAttackTurn()
        {
            for (int i = 0; i < (Herd.HerdOfDinosaurs.Count); i++)
            {
                string userInput = TakeUserInput();
                if (Herd.HerdOfDinosaurs[i].Health >= 0)
                {
                    //dinosaur's turn to attack

                    if (userInput == "attack")
                    {
                        int attacker = 1;
                        int attackingParty = 0;
                        int attackedParty = 0;
                        int damageDealt = 0;
                        damageDealt = CalculateAttackDamage(Herd.HerdOfDinosaurs[attackingParty].AttackPower, Herd.HerdOfDinosaurs[attackingParty].AttackPower);
                        DealAttackDamage(attacker, attackedParty, damageDealt);
                        Console.WriteLine($"you dealt {damageDealt} to {Fleet.FleetOfRobots[0].Name}.");
                        break;
                    }
                    else if (userInput == "retreat")
                    {
                        Console.WriteLine("You live to fight another day, you sissy.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid selection");
                    }
                }
                else
                {
                    Herd.HerdOfDinosaurs.RemoveAt(i);
                }

            }
        }
        public void SearchForWeapon()
        {
            bool userInputCheck = true;
            do
            {
                Console.WriteLine($"{Fleet.FleetOfRobots[0].Name} is searching for a weapon...");
                Console.WriteLine($"{Fleet.FleetOfRobots[0].Name} has found a laser gun, a plasma sword, and a plasma cannon! Which should it choose?");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "Laser Gun":
                        Weapon = new Weapon(20, "Laser Gun");
                        Console.WriteLine($"{Fleet.FleetOfRobots[0].Name} picked up a {Weapon.WeaponType} .");
                        Console.WriteLine($"The {userInput} has a attack power of {Weapon.AttackPower} .");
                  //      BattlefieldWeapons.Add(Weapon);
                        Fleet.FleetOfRobots[0].Equip(Weapon);
                        userInputCheck = !userInputCheck;
                        break;
                    case "laser gun":
                        Weapon = new Weapon(20, "Laser Gun");
                        Console.WriteLine($"{Fleet.FleetOfRobots[0].Name} picked up a {Weapon.WeaponType}.");
                        Console.WriteLine($"The {userInput} has a attack power of {Weapon.AttackPower} .");
                        //      BattlefieldWeapons.Add(Weapon);
                        Fleet.FleetOfRobots[0].Equip(Weapon);
                        userInputCheck = !userInputCheck;
                        break;
                    case "Plasma Sword":
                        Weapon = new Weapon(35, "Plsama Sword");
                        Console.WriteLine($"{Fleet.FleetOfRobots[0].Name} picked up a {Weapon.WeaponType}.");
                        Console.WriteLine($"The {userInput} has a attack power of {Weapon.AttackPower} .");
                        //    BattlefieldWeapons.Add(Weapon);
                        Fleet.FleetOfRobots[0].Equip(Weapon);
                        userInputCheck = !userInputCheck;
                        break;
                    case "plasma sword":
                        Weapon = new Weapon(35, "Plasma Sword");
                        Console.WriteLine($"{Fleet.FleetOfRobots[0].Name} picked up a {Weapon.WeaponType}.");
                        Console.WriteLine($"The {userInput} has a attack power of {Weapon.AttackPower} .");
                        //   BattlefieldWeapons.Add(Weapon);
                        Fleet.FleetOfRobots[0].Equip(Weapon);
                        userInputCheck = !userInputCheck;
                        break;
                    case "Plasma Cannon":
                        Weapon = new Weapon(40, "Plasma Cannon");
                        Console.WriteLine($"{Fleet.FleetOfRobots[0].Name} picked up a {Weapon.WeaponType}.");
                        Console.WriteLine($"The {userInput} has a attack power of {Weapon.AttackPower} .");
                        // BattlefieldWeapons.Add(Weapon);
                        Fleet.FleetOfRobots[0].Equip(Weapon);
                        userInputCheck = !userInputCheck;
                        break;
                    case "plasma cannon":
                        Weapon = new Weapon(40, "Plasma Cannon");
                        Console.WriteLine($"{Fleet.FleetOfRobots[0].Name} picked up a {Weapon.WeaponType}.");
                        Console.WriteLine($"The {userInput} has a attack power of {Weapon.AttackPower} .");
                        // BattlefieldWeapons.Add(Weapon);
                        Fleet.FleetOfRobots[0].Equip(Weapon);
                        userInputCheck = !userInputCheck;
                        break;
                    default:
                        Console.WriteLine($"{Fleet.FleetOfRobots[0].Name} can't find a weapon! \n Help {Fleet.FleetOfRobots[0].Name} find a weapon");
                        break;


                }
            }
            while (userInputCheck == true);
           
        }
        public int CalculateAttackDamage(int attackersAttackPower, int weaponsAttackPower)
        {
            int totalAttackPower = 0;
            totalAttackPower += attackersAttackPower + weaponsAttackPower;

            return totalAttackPower;
        }
        public void DealAttackDamage(int attackerCheck, int attackedParty, int damageDealt)
        {

            if (attackerCheck == 0)
            {
                Herd.HerdOfDinosaurs[attackedParty].Health -= damageDealt;

            }
            else if (attackerCheck == 1)
            {
                Fleet.FleetOfRobots[attackedParty].Health -= damageDealt;
            }


        }




    }
}

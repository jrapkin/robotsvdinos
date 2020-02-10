using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    class Game
    {
        Robot newRobot;
        Battlefield Battlefield;
        Weapon Weapon;
        //Where I want to run Robots V Dinosaurs 
        /// <summary>
        /// This is where core of game logic will be held
        /// </summary>
        /// 


        public void RunTheGame()
        {
            //Welcome message - presents start / quit
            WelcomeMessage();

            //take user input


            //read user input if nEW gAME Spawn Battlefield  (Setup New Game in Valid State  (Ready to begin) if no, quit game, if neither, prompt for valid input
            NewGame();

            //Game Paint Picture (Set virtual stage)
            SetStage();

            // Loop / Itteration BEGIN?
            //Present User Options / Actions

/*            BattleNarration();
*/
            //Read User Input
            BattleEngine();

            // Attack (damage, stamina cost)
            Console.ReadLine();
            // Loop Itteration End

            //quit game



        }





        public void Attack()
        {
            CalculateAttackDamage(Battlefield.Fleet[0].AttackPower, 3);
        }
       

        //Welcome user to the game, ask if they want to play
        private void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Robots Versus Dinosaurs!");
            Console.WriteLine("Do you want to start a new game?");

        }
        // read user input

        private string TakeUserInput()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }

        private void NewGame()
        {
            bool newGameCheck = false;

            do
            {
                string userInput = TakeUserInput();

                switch (userInput)
                {
                    case "yes":
                        InitializeBattlefield();
                        newGameCheck = !newGameCheck;
                        break;

                    case "Yes":
                        InitializeBattlefield();
                        newGameCheck = !newGameCheck;
                        break;

                    case "1":
                        InitializeBattlefield();
                        newGameCheck = !newGameCheck;
                        break;

                    case "no":
                        QuitGame();
                        newGameCheck = !newGameCheck;
                        break;

                    case "No":
                        QuitGame();
                        newGameCheck = !newGameCheck;
                        break;

                    case "2":
                        QuitGame();
                        newGameCheck = !newGameCheck;
                        break;

                    default:
                        Console.WriteLine("Please make a valid selection. Press 1 to start a new game. Press 2 to exit the game.");
                        break;
                }

            }
            while (newGameCheck == false);

        }

        //Spawn an initial instance of the battlefield to which the user can then begin playing.
        private void InitializeBattlefield()
        {
            Battlefield = new Battlefield();
        }

        //Set stage/ paint picture
        private void SetStage()
        {
            Console.WriteLine("It is a beautiful sunny day in the lushious planes of planet Earth. The pterodactyls are screetching, the stegosauruses are roaming the planes.");
            Console.WriteLine("A fleet of robots have appeared to invade planet Earth! \n");
            Console.WriteLine("A herd of dinosaurs spotted the robots on their turf! The dinosaurs move to attack!");
        }

   /*     private void BattleNarration()
        {
            Console.WriteLine("Would you like to attack or retreat?");
        }
*/
        public void BattleEngine()
        {
            while (Battlefield.Fleet.Count != 0 || Battlefield.Herd.Count != 0)
            {
                Console.WriteLine("The robots have a chance to act! Will they attack or retreat?");

                RobotAttackTurn();
                Console.WriteLine("The dinosaurs have a chance to act! Will they attack or retreat?");
                DinosaurAttackTurn();
            }
        }

        private void RobotAttackTurn()
        {
            for (int i = 0; i < (Battlefield.Fleet.Count); i++)
            {
                string userInput = TakeUserInput();//this else statement will skip a turn
                if (Battlefield.Fleet[i].Health > 0)
                {
                    //robot's turn to attack

                    if (userInput == "attack")
                    {
                        int attackingParty = 0;
                        int attackedParty = 0;
                        int damageDealt = 0;
                        damageDealt = CalculateAttackDamage(Battlefield.Fleet[attackingParty].AttackPower, Battlefield.Fleet[attackingParty].weapon.AttackPower);
                        DealAttackDamage(attackedParty, damageDealt);
                        Console.WriteLine($"you dealt {damageDealt} to {Battlefield.Herd[0].Name}.");
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
                    Battlefield.Fleet.RemoveAt(i);
                }

                
            }
        }

        private void DinosaurAttackTurn()
        {
            for (int i = 0; i < (Battlefield.Fleet.Count); i++)
            {
                string userInput = TakeUserInput();
                if (Battlefield.Herd[i].Health > 0)
                {
                    //dinosaur's turn to attack

                    if (userInput == "attack")
                    {
                        int attackingParty = 0;
                        int attackedParty = 0;
                        int damageDealt = 0;
                        damageDealt = CalculateAttackDamage(Battlefield.Herd[attackingParty].AttackPower, Battlefield.Herd[attackingParty].AttackPower);
                        DealAttackDamage(attackedParty, damageDealt);
                        Console.WriteLine($"you dealt {damageDealt} to {Battlefield.Fleet[0].Name}.");
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
                    Battlefield.Herd.RemoveAt(i);
                }
                
            }
        }
    

    public int CalculateAttackDamage(int attackersAttackPower, int weaponsAttackPower)
        {
            int totalAttackPower = 0;
            totalAttackPower += attackersAttackPower + weaponsAttackPower;

            return totalAttackPower;
        }        
        public void DealAttackDamage(int attackedParty, int damageDealt)
        {
            Battlefield.Herd[attackedParty].Health -= damageDealt;

        }

        private void QuitGame()
        {
            Console.WriteLine("Thank you for checking out Robots versus Dinosaurs. \n Play again soon!");
            Console.ReadLine();
        }

        //Once battlefield is spawned, give the user a choice of who attacks first, either the robots or the dinosaurs

        //Depending on user choice, narrate which mob is attacking

        /*      public void SearchForWeapon()
              {
                  bool userInputCheck = true;
                  do
                  {
                      Console.WriteLine(Robot.name + " is searching for a weapon...");
                      Console.WriteLine(Robot.name + " has found a sword, an axe, and a plasma cannon! Which should it choose?");
                      string userInput = Console.ReadLine();

                      switch (userInput)
                      {
                          case "Axe": 
                              weapon = new Weapon(12, "Axe");
                              Console.WriteLine(Robot.name + " picked up a " + userInput + ".");
                              Console.WriteLine("The" + userInput + "has a attack power of " + weapon.AttackPower + ".");
                              userInputCheck = !userInputCheck;
                              break;
                          case "axe":
                              weapon = new Weapon(12, "Axe");
                              Console.WriteLine(Robot.name + " picked up a " + userInput);
                              Console.WriteLine("The " + userInput + "has a attack power of " + weapon.AttackPower + ".");
                              userInputCheck = !userInputCheck;
                              break;
                          case "Sword":
                              weapon = new Weapon(15, "Sword");
                              Console.WriteLine(Robot.name + " picked up a " + userInput);
                              Console.WriteLine("The " + userInput + "has a attack power of " + weapon.AttackPower + ".");
                              userInputCheck = !userInputCheck;
                              break;
                          case "sword":
                              weapon = new Weapon(15, "Sword");
                              Console.WriteLine(Robot.name + " picked up a " + userInput);
                              Console.WriteLine("The " + userInput + "has a attack power of " + weapon.AttackPower + ".");
                              userInputCheck = !userInputCheck;
                              break;
                          case "Plasma Cannon":
                              weapon = new Weapon(25, "Plasma Cannon");
                              Console.WriteLine(Robot.name + " picked up a " + userInput);
                              Console.WriteLine("The " + userInput + "has a attack power of " + weapon.AttackPower + ".");
                              userInputCheck = !userInputCheck;
                              break;
                          case "plasma cannon":
                              weapon = new Weapon(25, "Plasma Cannon");
                              Console.WriteLine(Robot.name + " picked up a " + userInput);
                              Console.WriteLine("The " + userInput + " has a attack power of " + weapon.AttackPower + ".");
                              userInputCheck = !userInputCheck;
                              break;
                          default:
                              Console.WriteLine(Robot.name + " can't find a weapon!" + "\n" + "Help " + name + " find a weapon");
                              break;


                      }
                  }
                  while (userInputCheck == true);
                  Console.ReadLine();
              }*/
    }
}

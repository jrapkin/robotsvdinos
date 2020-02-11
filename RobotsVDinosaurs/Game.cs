using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    class Game
    {
        Robot Robot;
        Battlefield Battlefield;
        Weapon Weapon;
        Fleet Fleet;
        Herd Herd;
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

            //Read User Input
            BattleEngine();

            NewGame();

            // Attack (damage, stamina cost)

            // Loop Itteration End

            //quit game



        }



       

        //Welcome user to the game, ask if they want to play
        private void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Robots Versus Dinosaurs!");
            Console.WriteLine("Do you want to start a new game?");

        }
        // read user input

        public string TakeUserInput()
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
            Fleet = new Fleet();
            Herd = new Herd();
        }

        //Set stage/ paint picture
        private void SetStage()
        {
            Console.WriteLine("It is a beautiful sunny day in the lushious planes of planet Earth. The pterodactyls are screetching, the stegosauruses are roaming the planes.");
            Console.WriteLine("A fleet of robots have appeared to invade planet Earth! \n");
            Console.WriteLine("A herd of dinosaurs spotted the robots on their turf! The dinosaurs move to attack!");
        }


        public void BattleEngine()
        {

            while (Fleet.FleetOfRobots.Count != 0 && Herd.HerdOfDinosaurs.Count != 0)
            {

                Console.WriteLine("The robots have a chance to act! Will they attack or retreat?");
                Battlefield.RobotAttackTurn();
                if (Fleet.FleetOfRobots.Count != 0 && Herd.HerdOfDinosaurs.Count != 0)
                {
                    Console.WriteLine("The dinosaurs have a chance to act! Will they attack or retreat?");
                    Battlefield.DinosaurAttackTurn();
                }
                if (Fleet.FleetOfRobots.Count == 0)
                    
                { 
                    string winningMobType = "dinosaurs";
                    string losingMobType = "robots";
                    EndGameMessage(winningMobType, losingMobType);
                    
                }
                else if (Herd.HerdOfDinosaurs.Count == 0)
                {
                    string winningMobType = "robots";
                    string losingMobType = "dinosaurs";
                    EndGameMessage(winningMobType, losingMobType);
                } 
            }
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
     
     
        private void EndGameMessage(string winningMobType, string losingMobType)
        {
            Console.WriteLine($"The Battle has ended! The {winningMobType} have successfully defeated the {losingMobType}! \n Would you like to play again?");
            
        }


        private void QuitGame()
        {
            Console.WriteLine("Thank you for checking out Robots versus Dinosaurs. \n Play again soon!");
            Console.ReadLine();
        }



    }
}

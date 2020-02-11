using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    class Game
    {
        Battlefield Battlefield;
        Weapon Weapon;
        
        //Where I want to run Robots V Dinosaurs 
        /// <summary>
        /// This is where core of game logic will be held
        /// </summary>
        /// 
        public Game()
        {
            Battlefield = new Battlefield();
        }

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


            //quit game



        }



       

        //Welcome user to the game, ask if they want to play
        private void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Robots Versus Dinosaurs!");
            Console.WriteLine("Do you want to start a new game?");

        }
        // read user input

        private void NewGame()
        {
            bool newGameCheck = false;

            do
            {
                string userInput = Battlefield.TakeUserInput();

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


        public void BattleEngine()
        {

            while (Battlefield.Fleet.FleetOfRobots.Count != 0 && Battlefield.Herd.HerdOfDinosaurs.Count != 0)
            {

                Console.WriteLine("The robots have a chance to act! Will they attack or retreat?");
                Battlefield.RobotAttackTurn();
                if (Battlefield.Fleet.FleetOfRobots.Count != 0 && Battlefield.Herd.HerdOfDinosaurs.Count != 0)
                {
                    
                    Console.WriteLine("The dinosaurs have a chance to act! Will they attack or retreat?");
                    Battlefield.DinosaurAttackTurn();
                }
                if (Battlefield.Fleet.FleetOfRobots.Count == 0)
                    
                { 
                    string winningMobType = "dinosaurs";
                    string losingMobType = "robots";
                    EndGameMessage(winningMobType, losingMobType);
                    
                }
                else if (Battlefield.Herd.HerdOfDinosaurs.Count == 0)
                {
                    string winningMobType = "robots";
                    string losingMobType = "dinosaurs";
                    EndGameMessage(winningMobType, losingMobType);
                } 
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

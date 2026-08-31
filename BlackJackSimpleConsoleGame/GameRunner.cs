using System.Net.Mime;

namespace BlackJackSimpleConsoleGame;

public class GameRunner
{
    public void RunGame()
    {
        // Bools for checking player conditions
        bool playerHolds = false;
        bool playerLoose = false;
        bool playerWins = false;
        
        // Player and dealer object
        Players playerAndDealer = new Players();

        void PlayerLooseOrWinInput()
        {
            Console.WriteLine("\ntype 1 to continue a new round or type 2 to exit");
            string? input = Console.ReadLine();
            if (input == "1")
            {
                // Resets values
                playerAndDealer.PlayerValue = 0;
                playerAndDealer.DealerValue = 0;
                playerWins = false;
                playerLoose = false;
                playerHolds = false;
                playerAndDealer.RemoveAllCards();
                
                // Clears console and starts a new game
                Console.ResetColor();
                Console.Clear();
                StartGame();
            }
            else if (input == "2")
            {
                System.Environment.Exit(1);
            }
        }

        // The game loop
        void StartGame()
        {
            Console.WriteLine("Welcome, This is a simple Black Jack console game");
            Console.WriteLine("Please enter your username: ");

            // The question mark is there to make it nullable
            string? userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hello {userName}");

            /* Checks if user wrote anything for their username
            While they have not written anything
            The program will keep asking them to input a username */
            while (userName == null || userName == "")
            {
                Console.WriteLine("Please enter your username: ");
                userName = Console.ReadLine();
                if (userName != null && userName != "")
                {
                    break;
                }
            }

            // We instantiate objects
            playerAndDealer.DealerDrawsCards();
            playerAndDealer.PlayerDrawCards();
            
            // While the playerHolds and playerLoose is false do this
            while (!playerHolds && !playerLoose && !playerWins)
            {
                Console.WriteLine("Do you want to draw a card type - 1\nOr don't draw a card type - 2");
                Console.WriteLine("To start a new round type - 3");
                string? playerInput = Console.ReadLine();
                playerInput = playerInput.Trim();

                if (playerInput == "1")
                {
                    Console.Clear();
                
                    // Cards gets drawn
                    playerAndDealer.DealerDrawsCards();
                    playerAndDealer.PlayerDrawCards();
                
                    // Winning and loose logic
                    (playerWins) = playerAndDealer.IfDealerBust(playerWins);
                    (playerLoose) = playerAndDealer.IfPlayerBust(playerLoose);
                    
                    if (playerWins)
                    {
                        PlayerLooseOrWinInput();
                    }

                    if (playerLoose)
                    {
                        PlayerLooseOrWinInput();
                    }
                }
                if (playerInput == "2")
                {
                    Console.Clear();
                    
                    // Cards gets drawn
                    playerAndDealer.DealerDrawsCards();
                    playerAndDealer.ShowPlayerCards();
                    
                    // If player holds
                    playerHolds = playerAndDealer.Hold(playerHolds);
                    
                    // Wining and loose logic
                    (playerWins) = playerAndDealer.CheckWins(playerWins);
                    (playerLoose) = playerAndDealer.CheckLoss(playerLoose);
                    (playerWins) = playerAndDealer.IfDealerBust(playerWins);
                    (playerLoose) = playerAndDealer.IfPlayerBust(playerLoose);
                    
                    if (playerWins)
                    {
                        PlayerLooseOrWinInput();
                    }

                    if (playerLoose)
                    {
                        PlayerLooseOrWinInput();
                    }
                }
                if (playerInput == "3")
                {
                    // Resets values
                    playerAndDealer.PlayerValue = 0;
                    playerAndDealer.DealerValue = 0;
                    playerWins = false;
                    playerLoose = false;
                    playerHolds = false;
                    playerAndDealer.RemoveAllCards();
                    
                    // Clears the console and starts a new game
                    Console.Clear();
                    StartGame();
                }
            }
            
        }
        
        StartGame();
        
    }

}
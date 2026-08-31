namespace BlackJackSimpleConsoleGame;

public class GameRunner
{
    public void RunGame()
    {
        // Bools for checking player conditions
        bool playerHolds = false;
        bool playerLoose = false;
        bool playerWins = false;
        
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
        Players dealer = new Players();
        dealer.DealerDrawsCards();
        Players player = new Players();
        player.PlayerDrawCards();
        
        // While the playerHolds and playerLoose is false do this
        while (!playerHolds && !playerLoose && !playerWins)
        {
            Console.WriteLine("Do you want to draw a card type - 1\nOr don't draw a card type - 2");
            string? playerInput = Console.ReadLine();
            playerInput = playerInput.Trim();
        
            if (playerInput == "1")
            {
                Console.Clear();
                
                // Cards gets drawn
                dealer.DealerDrawsCards();
                player.PlayerDrawCards();
                
                // Winning and loose logic
                playerLoose = player.IfPlayerBust(playerLoose);
                playerWins = dealer.IfDealerBust(playerWins);
            }
            if (playerInput == "2")
            {
                Console.Clear();
                dealer.DealerDrawsCards();
                player.ShowPlayerCards();
                playerHolds = player.Hold(playerHolds);
            }
        }

    }

}
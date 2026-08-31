namespace BlackJackSimpleConsoleGame;

public class Players : GameLogic
{
    private int _playerValue;
    private int _dealerValue;
    
    // Method shows the players card
    public void ShowPlayerCards()
    {
        Console.WriteLine($"You have {_playerValue} points");
        Console.WriteLine($"Here is the cards you have drawn: ");
        Console.WriteLine("#############################");
        
        // foreach card in the PlayerCards list, show the cards rank and suit
        foreach (Card playerCards in PlayerCards)
        {
            Console.WriteLine($"    Rank: {playerCards.Rank} Suit: {playerCards.Suit}");
        }
        Console.WriteLine("#############################");
    }
    public void ShowDealerCards()
    {
        Console.WriteLine($"Dealer has {_dealerValue} points");
        Console.WriteLine($"Here is the cards the dealer have drawn: ");
        
        Console.WriteLine("#############################");
        foreach (Card dealerCards in DealerCards)
        {
            Console.WriteLine($"    Rank: {dealerCards.Rank} Suit: {dealerCards.Suit}");
        }
        Console.WriteLine("#############################\n");
    }

    public void PlayerDrawCards()
    {
        // Using a tuple to group the two values and make them equal, to the returned value from the DrawCard method 
        (PlayerCards, _playerValue) = DrawCard(PlayerCards, _playerValue);
        ShowPlayerCards();
    }
    public void DealerDrawsCards()
    {
        if (_dealerValue >= 17)
        {
            ShowDealerCards();
        }
        else
        {
            (DealerCards, _dealerValue) = DrawCard(DealerCards, _dealerValue);
            ShowDealerCards();
        }
    }
    
    public bool Hold(bool playerHolds)
    {
        Console.WriteLine($"You have {_playerValue} in total");
        return !playerHolds;
    }

    public bool IfPlayerBust(bool playerLoose)
    {
        // If the player has over 21 points, return bool false and display loose text
        if (_playerValue > 21)
        {
            ShowPlayerCards();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You Loose!");
            Console.WriteLine($"You have {_playerValue} points in total");
            return !playerLoose;
        }
        return playerLoose;
    }
    
    public bool PlayerMessage(bool playerWins, string userName)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{userName} has won!");
        return playerWins;
    }

    public bool IfDealerBust(bool playerWins)
    {
        if (_dealerValue > 21)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You have won!");
            playerWins = true;
        }
        return playerWins;
    }
}
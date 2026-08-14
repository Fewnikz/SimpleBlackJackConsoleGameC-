namespace BlackJackSimpleConsoleGame;

public class PlayerLogic : GameLogic
{
    private int _playerValue;
    
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

    public void PlayerDrawCards()
    {
        // Using a tuple to group the two values and make them equal, to the returned value from the DrawCard method 
        (PlayerCards, _playerValue) = DrawCard(PlayerCards, _playerValue);
        ShowPlayerCards();
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
    
}
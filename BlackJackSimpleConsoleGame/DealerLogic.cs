namespace BlackJackSimpleConsoleGame;

public class DealerLogic : GameLogic
{
    private int _dealerValue;

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
    
    public void DealerDrawsCards()
    {
        // Using a tuple to group the two values and make them equal, to the returned value from the DrawCard method 
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
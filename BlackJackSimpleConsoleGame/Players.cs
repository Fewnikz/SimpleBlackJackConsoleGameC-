namespace BlackJackSimpleConsoleGame;

public class Players : GameLogic
{
    public int PlayerValue;
    public int DealerValue;
    
    // Method shows the players card
    public void ShowPlayerCards()
    {
        Console.WriteLine($"You have {PlayerValue} points");
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
        Console.WriteLine($"Dealer has {DealerValue} points");
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
        (PlayerCards, PlayerValue) = DrawCard(PlayerCards, PlayerValue);
        ShowPlayerCards();
    }
    public void DealerDrawsCards()
    {
        if (DealerValue >= 17)
        {
            ShowDealerCards();
        }
        else
        {
            (DealerCards, DealerValue) = DrawCard(DealerCards, DealerValue);
            ShowDealerCards();
        }
    }
    
    public bool Hold(bool playerHolds)
    {
        Console.WriteLine($"You have {PlayerValue} in total");
        return !playerHolds;
    }

    public bool IfPlayerBust(bool playerLoose)
    {
        // If the player has over 21 points, return bool false and display loose text
        if (PlayerValue > 21)
        {
            Console.Write("\x1b[38;2;255;0;0m");
            Console.WriteLine("You Loose!");
            Console.WriteLine($"You have {PlayerValue} points in total");
            return !playerLoose;
        }
        return playerLoose;
    }

    public bool IfDealerBust(bool playerWins)
    {
        if (DealerValue > 21 && PlayerValue <= 21)
        {
            Console.Write("\x1b[38;2;0;255;0m");
            Console.WriteLine($"You have won!");
            return true;
        } 
        
        if (DealerValue > 21 && PlayerValue > 21)
        {
            return false;
        }
        
        return playerWins;
    }
    
    // Method that checks who has won
    public bool CheckWins(bool playerWins)
    {
        if (PlayerValue > DealerValue)
        {
            Console.Write("\x1b[38;2;0;255;0m");
            Console.WriteLine($"You have won!");
            return true;
        }
        return playerWins;
    }
    
    public bool CheckLoss(bool playerLoose)
    {
        if (PlayerValue < DealerValue && DealerValue <= 21)
        {
            Console.Write("\x1b[38;2;255;0;0m");
            Console.WriteLine($"You have lost!");
            return true;
        }

        if (PlayerValue == DealerValue)
        {
            Console.Write("\x1b[38;2;255;0;0m");
            Console.WriteLine($"You have lost!");
            return true;
        }
        return playerLoose;
    }

    public void RemoveAllCards()
    {
        PlayerCards.Clear();
        DealerCards.Clear();
    }
}
namespace BlackJackSimpleConsoleGame;

public class GameLogic : CardDeck
{
    public int CalculateValue(string rank, int value)
    {
        // Tries to see if the rank can be parsed to an int value
        if (int.TryParse(rank, out int rankValue))
        {
            value += rankValue;
        }
        
        switch (rank)
        {
            case "J":
                value += 10;
                break;
            case "Q":
                value += 10;
                break;
            case "K":
                value += 10;
                break;
        }

        if (rank == "A")
        {
            if (value >= 11)
            {
                value += 1;
            }
            if (value <= 11)
            {
                value += 11;
            }
        }
        
        return value;
    }
    
    public (List<Card>, int) DrawCard(List<Card> playerTurnCards, int playerTurnValue)
    {
        if (CardCollection.Count == 0)
        {
            CardCollection = CreateCards(CardCollection);
        }
        
        // Takes a random number from 1 to 52 by using the length of the CardCollection list
        Random randomNumber = new Random();
        int randomCardNumber =  randomNumber.Next(CardCollection.Count);
        
        // Removes the drawn card object from the CardCollection so it can't be drawn again
        // Returns the object from CardCollection list to the chosen list
        playerTurnValue = CalculateValue(CardCollection[randomCardNumber].Rank, playerTurnValue);
        playerTurnCards.Add(CardCollection[randomCardNumber]);
        CardCollection.RemoveAt(randomCardNumber);
        return (playerTurnCards,  playerTurnValue);
    }
}
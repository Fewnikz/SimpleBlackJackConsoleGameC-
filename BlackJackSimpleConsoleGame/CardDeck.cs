using System.Globalization;

namespace BlackJackSimpleConsoleGame;

public class CardDeck
{
    // Array for looping through the ranks and suits. So I don't need to code like yandere dev... or whatever his name is
    static string[] _rank = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
    static string [] _suit = {"Club", "Diamond", "Heart", "Spade"};
    
    // Loops through the rank and suits array and adds Card object to cardDeck parameter
    public static List<Card> CreateCards (List<Card> cardDeck)
    {
        foreach (string ranks in _rank)
        {
            foreach (string suits in _suit)
            {
                cardDeck.Add(new Card(ranks, suits));
            }
        }
        return cardDeck;
    }
    
    // The cards that the player has
    public List<Card> PlayerCards = new List<Card>();
    
    // The cards that the dealer has
    public List<Card> DealerCards = new List<Card>();
    
    // A list for all the cards in the game
    public List<Card> CardCollection = new List<Card>();

}
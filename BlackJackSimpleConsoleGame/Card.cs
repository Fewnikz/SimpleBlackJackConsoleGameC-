using System;
namespace BlackJackSimpleConsoleGame;

public class Card
{
    public string Rank;
    public string Suit;

    // Making a Constructor to make the code more clean
    public Card(string rank, string suit)
    {
        Rank = rank;
        Suit = suit;
    }
}
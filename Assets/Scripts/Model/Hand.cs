using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Hand
{
    private readonly List<Card> cards;

    public Hand()
    {
        cards = new List<Card>();
    }

    public void addCard(Card card)
    {
        cards.Add(card);
    }

    public void reset()
    {
        cards.RemoveAll();
    }
}

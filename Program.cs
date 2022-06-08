// Playing Card 
// Author : Andrei C.

using OOP_Playing_Card;

Deck MyDeck = new Deck();

Console.WriteLine(MyDeck.Count);

MyDeck.Shuffle(6);


while (MyDeck.Count > 0)
{
    Console.WriteLine(MyDeck.DrawCard().ToString());
}

Console.WriteLine(MyDeck.Count);
using CardDraw;
using System;

public class Example
{
    public static void Main(string[] args)
    {
        Deck deck1 = new Deck();
        deck1.Shuffle();
        for (int i = 0; i < 4; i++)
        {
            Console.Write("{0, -19}", deck1.DealCard());
            if ((i + 1) % 4 == 0)
                Console.WriteLine();
        }
        Console.ReadLine();
    }
}

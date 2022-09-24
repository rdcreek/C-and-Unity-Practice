using System;
using ConsoleCards;

namespace ProgrammingAssignment3
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programming Assignment 3
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                // DON'T SHUFFLE THE DECK
                Deck deck = new Deck();

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
                Card player1 = deck.TakeTopCard();
                Card player2 = deck.TakeTopCard();
                Card player3 = deck.TakeTopCard();
                Card player4 = deck.TakeTopCard();

                Card player1T2 = deck.TakeTopCard();
                Card player2T2 = deck.TakeTopCard();
                Card player3T2 = deck.TakeTopCard();
                Card player4T2 = deck.TakeTopCard();
                // deal 1 more card to players 2 and 3
                Card player2T3 = deck.TakeTopCard();
                Card player3T3 = deck.TakeTopCard();

                // flip all the cards over
                player1.FlipOver();
                player2.FlipOver(); 
                player3.FlipOver();
                player4.FlipOver();

                player1T2.FlipOver();
                player2T2.FlipOver();
                player3T2.FlipOver();
                player4T2.FlipOver();

                player2T3.FlipOver();
                player3T3.FlipOver(); 
                
                // print the cards for player 1
                Console.WriteLine(player1.Rank + "," + player1.Suit);
                Console.WriteLine(player1T2.Rank + "," + player1T2.Suit);
                // print the cards for player 2
                Console.WriteLine(player2.Rank + "," + player2.Suit);
                Console.WriteLine(player2T2.Rank + "," + player2T2.Suit);
                Console.WriteLine(player2T3.Rank + "," + player2T3.Suit);

                // print the cards for player 3
                Console.WriteLine(player3.Rank + "," + player3.Suit);
                Console.WriteLine(player3T2.Rank + "," + player3T2.Suit);
                Console.WriteLine(player3T3.Rank + "," + player3T3.Suit);

                // print the cards for player 4
                Console.WriteLine(player4.Rank + "," + player4.Suit);
                Console.WriteLine(player4T2.Rank + "," + player4T2.Suit);
                

                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace HILO
{
    public class Director
    {
        //Responsabilities: Guess if it higher or lower
        //Has asociated a score 
        //Choose to Play again 
        //Display what's happening
        List<Card> Cards = new List<Card>();
        bool KeepPlaying = true;
        int Score = 0;
        string Guess;
        int TotalScore = 300;

        public Director()
        {
            for (int i=0;i<2;i++)
            {
                Card SingleCard = new Card();
                Cards.Add(SingleCard);
            }
        }

        //methods
        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (KeepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Ask for the guess to the player.
        /// </summary>
        public void GetInputs()
        {
            Console.WriteLine($"The current card is {Cards[0].Value}");
            Console.WriteLine("What is your guess(h/l)? ");
            foreach (Card singlecard in Cards)
            {
                singlecard.MakeCard();
                //card[0] is current and card[1] is next
            Guess = Console.ReadLine();
            }
        }

        /// <summary>
        /// Update player score and choose the next card
        /// </summary>
        public void DoUpdates()
        {
            Score = 0;
            TotalScore +=Score;
        }

        /// <summary>
        /// Display the card and the score. Also asks if they want to continue.
        /// </summary>
        public void DoOutputs()
        {
            if (!KeepPlaying){return;}
            Console.WriteLine($"Your Score is {TotalScore}");
            Console.WriteLine($"The next card was {Cards[1].Value}");
            KeepPlaying = (TotalScore>0);

        }
    
    }
}
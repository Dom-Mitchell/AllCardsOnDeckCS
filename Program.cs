using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static List<string> DeckCreation()
        {
            // var suits = new List<string>() { "Clubs", "Spades", "Queens", "Diamonds" };
            // var ranks = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            // Variables
            // 52 cards
            // 4 suits
            // 13 cards per suit
            var deck = new List<string>();
            var suits = new List<string>();
            var ranks = new List<string>();
            var i = 0;

            for (i = 0; i < 4; i++)
            {
                if (!suits.Contains("Clubs") || !suits.Contains("Diamonds") || !suits.Contains("Hearts") || !suits.Contains("Spades"))
                {
                    suits.Add("Clubs");
                    suits.Add("Diamonds");
                    suits.Add("Hearts");
                    suits.Add("Spades");
                }
                //else if (!suits.Contains("Diamonds"))
                //{
                //  suits.Add("Diamonds");
                //}
                //else if (!suits.Contains("Hearts"))
                //{
                //  suits.Add("Hearts");
                //}
                //else
                //{
                //  suits.Add("Spades");
                //}
                //Console.WriteLine(suits);
            }

            for (i = 0; i < 13; i++)
            {
                if (!ranks.Contains("Ace") || !ranks.Contains("2") || !ranks.Contains("3") || !ranks.Contains("4") || !ranks.Contains("5") || !ranks.Contains("6") || !ranks.Contains("7") || !ranks.Contains("8") || !ranks.Contains("9") || !ranks.Contains("10") || !ranks.Contains("Jack") || !ranks.Contains("Queen") || !ranks.Contains("King"))
                {
                    ranks.Add("Ace");
                    ranks.Add("2");
                    ranks.Add("3");
                    ranks.Add("4");
                    ranks.Add("5");
                    ranks.Add("6");
                    ranks.Add("7");
                    ranks.Add("8");
                    ranks.Add("9");
                    ranks.Add("10");
                    ranks.Add("Jack");
                    ranks.Add("Queen");
                    ranks.Add("King");
                }
                //else if (!ranks.Contains("2"))
                //{
                //  ranks.Add("2");
                //}
                //else if (!ranks.Contains("3"))
                //{
                //  ranks.Add("3");
                //}
                //else if (!ranks.Contains("4"))
                //{
                //  ranks.Add("4");
                //}
                //else if (!ranks.Contains("5"))
                //{
                //  ranks.Add("5");
                //}
                //else if (!ranks.Contains("6"))
                //{
                //  ranks.Add("6");
                //}
                //else if (!ranks.Contains("7"))
                //{
                //  ranks.Add("7");
                //}
                //else if (!ranks.Contains("8"))
                //{
                //  ranks.Add("8");
                //}
                //else if (!ranks.Contains("9"))
                //{
                //  ranks.Add("9");
                //}
                //else if (!ranks.Contains("10"))
                //{
                //  ranks.Add("10");
                //}
                //else if (!ranks.Contains("Jack"))
                //{
                //  ranks.Add("Jack");
                //}
                //else if (!ranks.Contains("Queen"))
                //{
                //  ranks.Add("Queen");
                //}
                //else
                //{
                //  ranks.Add("King");
                //}
                //Console.WriteLine(ranks);
            }

            foreach (var cardRanks in ranks)
            {
                foreach (var cardSuits in suits)
                {
                    var card = $"{cardRanks} of {cardSuits}";
                    Console.WriteLine($"{card}");
                    deck.Add(card);
                }
            }

            return deck;
        }

        static void ShuffleDeck()
        {
            var i = 0;
            var deck = DeckCreation();

            for (i = deck.Count - 1; i >= 0; i--)
            {
                //indexTwo equal to random # in range 0 to index
                var indexTwo = new Random().Next(0, i);

                // Swap index  of deck with indexTwo
                var swapCards = deck[i];
                deck[i] = deck[indexTwo];
                deck[indexTwo] = swapCards;
                //Console.WriteLine(deck[indexTwo]);
            }

            foreach (var shuffledCard in deck)
            {
                Console.WriteLine($"{shuffledCard}");
            }
        }

        static void Main(string[] args)
        {
            // Variables
            // 52 cards in a deck
            // 4 suits
            // 13 cards per suit
            var deck = new List<string>();
            var suits = new List<string>();
            var ranks = new List<string>();
            var i = 0;

            for (i = 0; i < 4; i++)
            {
                if (!suits.Contains("Clubs") || !suits.Contains("Diamonds") || !suits.Contains("Hearts") || !suits.Contains("Spades"))
                {
                    suits.Add("Clubs");
                    suits.Add("Diamonds");
                    suits.Add("Hearts");
                    suits.Add("Spades");
                }
                //     //else if (!suits.Contains("Diamonds"))
                //     //{
                //     //  suits.Add("Diamonds");
                //     //}
                //     //else if (!suits.Contains("Hearts"))
                //     //{
                //     //  suits.Add("Hearts");
                //     //}
                //     //else
                //     //{
                //     //  suits.Add("Spades");
                //     //}
                //     //Console.WriteLine(suits);
            }

            for (i = 0; i < 13; i++)
            {
                if (!ranks.Contains("Ace") || !ranks.Contains("2") || !ranks.Contains("3") || !ranks.Contains("4") || !ranks.Contains("5") || !ranks.Contains("6") || !ranks.Contains("7") || !ranks.Contains("8") || !ranks.Contains("9") || !ranks.Contains("10") || !ranks.Contains("Jack") || !ranks.Contains("Queen") || !ranks.Contains("King"))
                {
                    ranks.Add("Ace");
                    ranks.Add("2");
                    ranks.Add("3");
                    ranks.Add("4");
                    ranks.Add("5");
                    ranks.Add("6");
                    ranks.Add("7");
                    ranks.Add("8");
                    ranks.Add("9");
                    ranks.Add("10");
                    ranks.Add("Jack");
                    ranks.Add("Queen");
                    ranks.Add("King");
                }
                //     else if (!ranks.Contains("2"))
                //     {
                //       ranks.Add("2");
                //     }
                //     else if (!ranks.Contains("3"))
                //     {
                //       ranks.Add("3");
                //     }
                //     else if (!ranks.Contains("4"))
                //     {
                //       ranks.Add("4");
                //     }
                //     else if (!ranks.Contains("5"))
                //     {
                //       ranks.Add("5");
                //     }
                //     else if (!ranks.Contains("6"))
                //     {
                //       ranks.Add("6");
                //     }
                //     else if (!ranks.Contains("7"))
                //     {
                //       ranks.Add("7");
                //     }
                //     else if (!ranks.Contains("8"))
                //     {
                //       ranks.Add("8");
                //     }
                //     else if (!ranks.Contains("9"))
                //     {
                //       ranks.Add("9");
                //     }
                //     else if (!ranks.Contains("10"))
                //     {
                //       ranks.Add("10");
                //     }
                //     else if (!ranks.Contains("Jack"))
                //     {
                //       ranks.Add("Jack");
                //     }
                //     else if (!ranks.Contains("Queen"))
                //     {
                //       ranks.Add("Queen");
                //     }
                //     else
                //     {
                //       ranks.Add("King");
                //     }
                //     Console.WriteLine(ranks);
            }

            foreach (var cardRanks in ranks)
            {
                foreach (var cardSuits in suits)
                {
                    var card = $"{cardRanks} of {cardSuits}";
                    //Console.WriteLine($"{card}");
                    deck.Add(card);
                }
            }

            for (i = deck.Count - 1; i >= 0; i--)
            {
                //indexTwo equal to random # in range 0 to index
                var indexTwo = new Random().Next(0, i);

                //Swap index  of deck with indexTwo
                var swapCards = deck[i];
                deck[i] = deck[indexTwo];
                deck[indexTwo] = swapCards;
                //Console.WriteLine(deck[indexTwo]);
            }

            foreach (var shuffledCard in deck)
            {
                Console.WriteLine($"{shuffledCard}");
            }

            //DeckCreation();
            //Console.WriteLine();
            //ShuffleDeck();

        }
    }
}
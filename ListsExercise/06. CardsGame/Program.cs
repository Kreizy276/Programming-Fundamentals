using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (player1.Count > 0 && player2.Count > 0)
            {
                int card1 = player1[0];
                int card2 = player2[0];

                player1.RemoveAt(0);
                player2.RemoveAt(0);

                if(card1 > card2)
                {
                    player1.Add(card1);
                    player1.Add(card2);
                }
                else if(card1 < card2)
                {

                    player2.Add(card1);
                    player2.Add(card2);
                }
            }

            if(player1.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {player1.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {player2.Sum()}");
            }
        }
    }
}

using System;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public int[] MainGame()
        {
            var die = new Die();
            int die1 = die.Roll();
            Console.WriteLine("Roll: " + Convert.ToString(die1));
            int die2 = die.Roll();
            Console.WriteLine("Roll: " + Convert.ToString(die2));
            int die3 = die.Roll();
            Console.WriteLine("Roll: " + Convert.ToString(die3));

            int dieTotal = die1 + die2 + die3;
            Console.WriteLine("Sum of die: " + Convert.ToString(dieTotal));

            int[] numbers = { die1, die2, die3, dieTotal };
            return numbers;

        }
        
    }
}

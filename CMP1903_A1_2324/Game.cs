using System;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public int[] MainGame()
        {   
            // Instantiates new die object
            var die = new Die();
            
            // Calls rolls method and assigns it to three die variables, the value rolled is outputted.
            int die1 = die.Roll();
            Console.WriteLine("Roll: " + Convert.ToString(die1));
            int die2 = die.Roll();
            Console.WriteLine("Roll: " + Convert.ToString(die2));
            int die3 = die.Roll();
            Console.WriteLine("Roll: " + Convert.ToString(die3));
            
            // Sum of die is calculated and summed up.
            int dieTotal = die1 + die2 + die3;
            Console.WriteLine("Sum of die: " + Convert.ToString(dieTotal));
            
            // Assigns all four variables to an array to be returned into Testing.cs
            int[] numbers = { die1, die2, die3, dieTotal };
            return numbers;

        }
        
    }
}

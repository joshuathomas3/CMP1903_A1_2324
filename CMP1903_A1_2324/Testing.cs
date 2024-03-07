using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        static void Main(string[] args)
        {   
            // New Game object is instantiated and values and sum of die are returned to array
            Game game = new Game();
            int[] numbers = game.MainGame();
            
            // Loop to test the individual die roll (first three items in the array) are between 1 and 6 inclusive
            for (int i = 0; i < 3; i++)
            {
                Debug.Assert(1 <= numbers[i] && numbers[i] <= 6);
            }
            
            // Loop to test the sum of die rolls are between 3 and 18 inclusive
            Debug.Assert(3 <= numbers[3] && numbers[3] <= 18);

        }

    }
}

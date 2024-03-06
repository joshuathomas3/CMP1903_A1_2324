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
            Game game = new Game();
            int[] numbers = game.MainGame();

            for (int i = 0; i < 3; i++)
            {
                Debug.Assert(1 <= numbers[i] && numbers[i] <= 6);
            }
            
            Debug.Assert(3 <= numbers[3] && numbers[3] <= 18);
            
            
        }

    }
}

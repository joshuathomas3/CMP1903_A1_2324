using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //Property
        private int _value;

        public int Value
        {
            get
            {
                return _value;
            }
            private set
            {
                _value = value;
            }
        }
        
        //Method
        public int Roll()
        {
            Random random = new Random();
            _value = random.Next(1, 7);
            return _value;
        }

    }
}

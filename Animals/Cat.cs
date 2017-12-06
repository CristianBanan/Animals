using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Cat : Animal
    {
        public override string Name()
        {
            return "Cat";
        }
        public override string Voice()
        {
            return  "Meow-meow!";
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
     abstract class Animal
    {
        // Code review: breaks encapsulation
       

        public virtual string Name()
        {
           return "not defined";
        }

        public virtual string Voice()
        {
            return "not defined";
        }

        

        public override string ToString()
        {
            return Name() + " makes " + Voice(); 
        }
           
    }
}

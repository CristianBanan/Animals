using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code review: Dog should know itself what sounds it makes whitout telling it from outside
            // for example: you cannot tell a Cat to woof, right?
            Animal dog = new Dog();

            Animal cat = new Cat();

            Animal cow = new Cow();

            Animal frog = new Frog();

            Animal fish = new Fish();

            List<Animal> list = new List<Animal>();
            list.Add(dog);
            list.Add(cat);
            list.Add(cow);
            list.Add(frog);
            list.Add(fish);

            foreach(Animal a in list)
            {
                Console.WriteLine(a.ToString()); 
            }

            Console.ReadLine();


        }
    }
}

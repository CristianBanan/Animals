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
            Animal dog = new Animal("Dog", "Woof-woof");

            Animal cat = new Animal("Cat", "Meow!");

            Animal cow = new Animal("Cow", "Moo!");

            Animal frog = new Animal("Frog", "Craok!");

            Animal fish = new Animal("Fish", "Blub!");

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

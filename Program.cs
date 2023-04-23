using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theadventure2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("you are a son of a millionare");
            Console.WriteLine("now that your father passed away you are a owner of everything he owned");
            Console.WriteLine("are you hungry? (y/n)");

            Console.Write("> ");
            string Choice = Console.ReadLine();

            if (Choice == "y")
            {
                Console.WriteLine("you went to the kitchen");
                Console.WriteLine("as you walk in you see a dead man laying on the table");
                Console.WriteLine("This is the end of the demo, thanks for playing");
                Console.ReadLine();
            }
            else if (Choice == "n")
            {
                Console.WriteLine("You saw a dead man in your bed room, but before you ran away, a killer appeard and killed you (bad ending 1)");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("invalid input");
                Console.ReadLine();
            }

        }
    }
}
